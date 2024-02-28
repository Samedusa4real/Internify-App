using Forage.Core.Entities;
using Forage.Service.Dtos.Accounts;
using Forage.Service.Dtos.Common.ResponsesDtos;
using Forage.Service.Dtos.Tokens;
using Forage.Service.Exceptions;
using Forage.Service.Exceptions.AuthExceptions;
using Forage.Service.Responses;
using Forage.Service.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Services.Implementations
{
    public class IdentityUserService : IIdentityUserService
    {
       private readonly UserManager<AppUser> _userManager;
        readonly SignInManager<AppUser> _signInManager;
        readonly ITokenHandler _tokenHandler;
        readonly IAuthService _authService;
        readonly RoleManager<IdentityRole> RoleManager;
        readonly IHttpContextAccessor _http;
        private readonly ICompanyService _companyService;
        readonly IConfiguration _configuration;
        public IdentityUserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ITokenHandler tokenHandler, IAuthService authService, IConfiguration configuration, RoleManager<IdentityRole> roleManager, IHttpContextAccessor http, ICompanyService companyService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenHandler = tokenHandler;
            _authService = authService;
            _configuration = configuration;
            RoleManager = roleManager;
            _http = http;
            _companyService = companyService;
        }


        public async Task<ApiResponse> GetCurrentUser()
        {
            var userName = _http.HttpContext?.User.Identity.Name;
            AppUser? appUser = default;
            if (!string.IsNullOrWhiteSpace(userName))
            {
                appUser = await _userManager.FindByNameAsync(userName);

                if (appUser != null)
                {
                    return new ApiResponse{ StatusCode = 200, items = appUser };
                }
            }

            return new ApiResponse { StatusCode = 403  };
        }

        public async Task<object> UpdateUser(UpdateDto dto)
        {
            var userName = _http.HttpContext?.User.Identity.Name;
            AppUser? appUser = default;
            if (!string.IsNullOrWhiteSpace(userName))
            {
                appUser = await _userManager.FindByNameAsync(userName);

                appUser.UserName = dto.UserName;
                appUser.Email = dto.Email;

                await _userManager.UpdateAsync(appUser);
                if (!string.IsNullOrWhiteSpace(dto.Password))
                {
                    var token = await _userManager.GeneratePasswordResetTokenAsync(appUser);
                    var result = await _userManager.ResetPasswordAsync(appUser, token, dto.Password);
                }
                var loginResult = await Login(new LoginDto { Email = dto.Email, Password = dto.Password }, 100);
                return loginResult;
            }

            return new BaseReponse { StatusCode = 403 };
        }
     
        public async Task<BaseReponse> Register(RegisterPartnerDto registerDto, string role)
        {
            var user = await _userManager.FindByEmailAsync(registerDto.Email);
            if (user is not null)
            {
                return new()
                {
                    StatusCode = 404,
                    Message = "This User Already exists"
                };
            }

            var companyExists = await _companyService.CompanyExistsByName(registerDto.CompanyName);
            if (companyExists)
            {
                return new BaseReponse
                {
                    StatusCode = 400,
                    Message = "This Company Name is already registered."
                };
            }

            user = new AppUser()
            {
                Id = Guid.NewGuid().ToString(),
                Email = registerDto.Email,
                UserName = registerDto.Username,
            };
            IdentityResult result = await _userManager.CreateAsync(user, registerDto.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    return new() 
                    {
                        StatusCode = 404,
                        Message = error.Description
                    };
                }
            }
            await _userManager.AddToRoleAsync(user, role);
            user = await _userManager.FindByEmailAsync(registerDto.Email);
            return new()
            {
                UserId = user.Id.ToString(),
                StatusCode = (int)HttpStatusCode.OK,
                Message = "User Succesfully Registered"
            };
        }
        public async Task<ApiResponse> Update(UpdateDto dto, AppUser? updated)
        {
            var user = await _userManager.FindByNameAsync(_http.HttpContext.User.Identity.Name);
            if (updated is not null)
            {
                user = updated;
            }
            if (user is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
                user.Email = dto.Email;
                user.UserName = dto.UserName;
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    return new ApiResponse
                    {
                        StatusCode = 400,
                        Description = item.Description
                    };
                }
            }
            if (!string.IsNullOrWhiteSpace(dto.Password))
            {
                result = await _userManager.ChangePasswordAsync(user, dto.CurrentPassword, dto.Password);
                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        return new ApiResponse
                        {
                            StatusCode = 400,
                            Description = item.Description
                        };
                    }
                }
            }
            if (updated is null)
            {
                await _signInManager.SignInAsync(user, true);
            }
            return new ApiResponse
            {
                StatusCode = 203
            };
        }

        public async Task<TokenResponseDto> GoogleAuthorize(string token)
        {
            if (ValidateGoogleToken(token))
            {

                var jwtToken = new JwtSecurityToken(token);
                var emailClaim = jwtToken.Claims.First(c => c.Type == "email");

                string email = emailClaim.Value;

                var user = await _userManager.FindByEmailAsync(email);
                if (user != null)
                {
                    TokenResponseDto tokenResponseDto = await _tokenHandler.CreateAccessTokenAsync(user, 40);
                    await _authService.UpdateRefreshToken(user, tokenResponseDto.RefreshToken, tokenResponseDto.Expiration, 5);
                    return tokenResponseDto;
                }
                else
                {

                    var result = await Register(new RegisterPartnerDto
                    {
                        Email = email,
                        Username = jwtToken.Claims.First(c => c.Type == "given_name").Value,
                        Password = "Google123@",
                        ConfirmedPassword = "Google123@"
                    }, "User");

                    if (result.StatusCode == 200)
                    {
                        user = await _userManager.FindByEmailAsync(email);
                        TokenResponseDto tokenResponseDto = await _tokenHandler.CreateAccessTokenAsync(user, 40);
                        await _authService.UpdateRefreshToken(user, tokenResponseDto.RefreshToken, tokenResponseDto.Expiration, 5);
                        return tokenResponseDto;
                    }
                }
            }
            return new TokenResponseDto();
        }


        private async Task<IEnumerable<JsonWebKey>> GetGoogleSigningKeys()
        {
            using var httpClient = new HttpClient();

            var jsonResponse = await httpClient.GetStringAsync(_configuration["GoogleAuth:GoogleCerts"]);
            var googleKeys = JsonConvert.DeserializeObject<GoogleJsonWebKeys>(jsonResponse);
            return googleKeys.Keys;
        }
		public async Task<ApiResponse> GetAllAdmin()
		{
			var users = await _userManager.Users.ToListAsync();
			List<AppUser> admins = new List<AppUser>();
			foreach (var user in users)
			{
				if (await _userManager.IsInRoleAsync(user, "Admin"))
				{
					admins.Add(user);
				}
			}
			return new ApiResponse
			{
				StatusCode = 203,
				items = admins
			};
		}
		public async Task<ApiResponse> GetAllUser(string role)
		{
			List<AppUser> users = new List<AppUser>();
				foreach (var user in await _userManager.Users.Include(x=>x.Interns).Include(x=> x.Companies).Where(x=>x.Interns.Count == 0 && x.Companies.Count ==0).ToListAsync())
				{
					if (await _userManager.IsInRoleAsync(user, role))
					{
						users.Add(user);
					}
				}
			return new ApiResponse
			{
				StatusCode = 200,
				items = users
			};
		}
		public async Task<ApiResponse> Create(AppUser user, string password, bool isAdmin)
		{
			await _userManager.CreateAsync(user, password);

			if (isAdmin)
			{
				await _userManager.AddToRoleAsync(user, "Admin");

			}
			else
				await _userManager.AddToRoleAsync(user, "User");

			return new ApiResponse
			{
				StatusCode = 203,
			};
		}
		private bool ValidateGoogleToken(string tokenId)
        {
            var googleKeys = GetGoogleSigningKeys().Result;

            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = _configuration["GoogleAuth:ValidIssuer"],
                ValidateAudience = true,
                ValidAudience = _configuration["GoogleAuth:ValidAudience"],
                ValidateLifetime = true,
                IssuerSigningKeys = googleKeys,
                ValidateIssuerSigningKey = true,
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            try
            {
                SecurityToken validatedToken;
                ClaimsPrincipal principal = tokenHandler.ValidateToken(tokenId, validationParameters, out validatedToken);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public async Task<TokenResponseDto> Login(LoginDto loginDto, int accessTokenLifeTime, string role = null)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user is null)
            {
                throw new LoginFailedException();
            }

            if (role != null)
            {
                var roles = await _userManager.GetRolesAsync(user);
                if (!roles.Contains("Admin"))
                {
                    throw new LoginFailedException();
                }
            }

            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, true);
            if (!result.Succeeded)
            {
                throw new LoginFailedException();
            }
            TokenResponseDto tokenResponseDto = await _tokenHandler.CreateAccessTokenAsync(user, accessTokenLifeTime);
            await _authService.UpdateRefreshToken(user, tokenResponseDto.RefreshToken, tokenResponseDto.Expiration, 5);
            return tokenResponseDto;
        }
        public async Task<ApiResponse> Login(LoginDto dto)
        {
            AppUser appUser = await _userManager.FindByEmailAsync(dto.Email);
            if (appUser is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Email or password is not correct"
                };
            }
            if (!await _userManager.IsInRoleAsync(appUser, "Admin") && !await _userManager.IsInRoleAsync(appUser, "SuperAdmin"))
            {
                return new ApiResponse
                {
                    StatusCode = 400,
                    Description = "Access Failed"
                };
            }
            var result = await _signInManager.PasswordSignInAsync(appUser, dto.Password, true, true);
            if (!result.Succeeded)
            {
                if (result.IsLockedOut)
                {
                    return new ApiResponse
                    {
                        StatusCode = 400,
                        Description = "Your account blocked 5 minutes"
                    };
                }
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Username or password is not correct "
                };
            }
            return new ApiResponse
            {
                StatusCode = 200,
                items = appUser
            };
        }

        //public async Task<BaseReponse> AddExternalUser(AddExternalUserDto dto)
        //{

        //    return await Register(new()
        //    {
        //        Email = dto.Email,
        //        Surname = dto.Surname,
        //        Name = dto.Name,
        //        Password = dto.Password,
        //        ConfirmedPassword = dto.Password
        //    }, "User");
        //}
        public async Task<ApiResponse> Remove(string id)
        {
            AppUser? appUser = await _userManager.FindByIdAsync(id);
            if (appUser is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
            await _userManager.DeleteAsync(appUser);
            return new ApiResponse
            {
                StatusCode = 203,
            };
        }
        public async Task<ApiResponse> LogOut()
        {
            await _signInManager.SignOutAsync();
            return new ApiResponse
            {
                StatusCode = 203
            };
        }
        private string GenerateUniqueUsername(string name, string surname)
        {
            string uniqueNumber = DateTime.Now.Ticks.ToString();
            uniqueNumber += new Random().Next(10000000, 99999999).ToString();
            uniqueNumber = uniqueNumber.Substring(uniqueNumber.Length - 8);
            return name + surname + uniqueNumber;
        }

        public async Task<List<AllUserGetDto>> GetAllUsers()
        {
            var userList = await _userManager.Users.Select(c => new AllUserGetDto()
            {
                Id = c.Id,
                Username = c.UserName,
                Email = c.Email
            }).ToListAsync();
            return userList;
        }
    }

    public class GoogleJsonWebKeys
    {
        public List<JsonWebKey> Keys { get; set; }
    }

}
