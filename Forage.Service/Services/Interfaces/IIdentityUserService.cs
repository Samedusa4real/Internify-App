using Forage.Core.Entities;
using Forage.Service.Dtos.Accounts;
using Forage.Service.Dtos.Common.ResponsesDtos;
using Forage.Service.Dtos.Tokens;
using Forage.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Services.Interfaces
{
    public interface IIdentityUserService
    {
        public Task<List<AllUserGetDto>> GetAllUsers();
        public Task<BaseReponse> Register(RegisterPartnerDto registerDto, string role);
        public Task<BaseReponse> RegisterForIntern(RegisterInternDto registerDto, string role);

        public Task<TokenResponseDto> Login(LoginDto loginDto, int accessTokenLifeTime, string role = null);
        public Task<ApiResponse> Login(LoginDto loginDto);
        public Task<ApiResponse> LogOut();

        //public Task<BaseReponse> AddExternalUser(AddExternalUserDto dto);

        public Task<TokenResponseDto> GoogleAuthorize(string token);
        public Task<ApiResponse> GetAllUser(string role);
        public Task<ApiResponse> Create(AppUser user, string password, bool isAdmin);
        public Task<ApiResponse> GetAllAdmin();
        public Task<ApiResponse> Update(UpdateDto dto, AppUser? updated);

        public Task<ApiResponse> GetCurrentUser();

        public Task<object> UpdateUser(UpdateDto dto);
    }
}
