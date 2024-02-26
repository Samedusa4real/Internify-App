using AutoMapper;
using Forage.Core.Entities;
using Forage.Core.Repositories;
using Forage.Service.Dtos.HelpMessageType;
using Forage.Service.Dtos.Settings;
using Forage.Service.Extensions;
using Forage.Service.Responses;
using Forage.Service.Services.Interfaces;
using Forage.Service.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Forage.Service.Services.Implementations
{
    public class SettingService : ISettingService
    {
        private readonly ISettingRepository _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _evn;
        private readonly IHttpContextAccessor _http;
        private readonly IIdentityUserService _userservice;

        public SettingService(ISettingRepository repository, IMapper mapper, IWebHostEnvironment evn, IHttpContextAccessor http, IIdentityUserService userservice)
        {
            _repository = repository;
            _mapper = mapper;
            _evn = evn;
            _http = http;
            _userservice = userservice;
        }
        public async Task<ApiResponse> CreateAsync(SettingPostDto dto)
        {
            Setting Setting = _mapper.Map<Setting>(dto);
            Setting.Logo = dto.Logo.CreateImage(_evn.WebRootPath, "Images/Settings");
            Setting.LogoUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
                + $"Images/Settings/{Setting.Logo}";

            Setting.AboutImage = dto.AboutImage.CreateImage(_evn.WebRootPath, "Images/Settings");
            Setting.AboutImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
                + $"Images/Settings/{Setting.AboutImage}";


            await _repository.AddAsync(Setting);
            await _repository.SaveAsync();

            return new ApiResponse
            {
                StatusCode = 201,
                items = Setting
            };
        }

        public async Task<ApiResponse> GetAllAsync()
        {
            IEnumerable<Setting> Companies = await _repository.GetAllAsync(x => !x.IsDeleted);
            return new ApiResponse
            {
                items = Companies,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Setting? Setting = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (Setting == null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
            SettingUpdateDto dto = _mapper.Map<SettingUpdateDto>(Setting);
            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Setting Setting = await _repository.GetAsync(x => x.Id == id);
            if (Setting is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Setting.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Setting
            };
        }

        public async Task<SettingVM> GetSetting()
        {
            SettingVM settingVM = new SettingVM();
         
            if (_http.HttpContext.User.Identity.IsAuthenticated)
            {
                var result = await _userservice.GetCurrentUser();
                settingVM.AppUser = (AppUser)result.items;
            }

            return settingVM;
        }

        public async Task<ApiResponse> UpdateAsync(int id, SettingUpdateDto dto)
        {
            Setting Setting = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (Setting is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }

            if (dto.logoo is not null)
            {
                Setting.Logo = dto.logoo.CreateImage(_evn.WebRootPath, "Images/Settings");
                Setting.LogoUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
                    + $"Images/Settings/{Setting.Logo}";
            }


            if (dto.image is not null)
            {
                Setting.AboutImage = dto.image.CreateImage(_evn.WebRootPath, "Images/Settings");
                Setting.AboutImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
                    + $"Images/Settings/{Setting.AboutImage}";
            }


            Setting.UpdatedAt = DateTime.UtcNow.AddHours(4);
            Setting.AboutText = dto.AboutText;
            Setting.Address = dto.Address;
            Setting.Phone1 = dto.Phone1;
            Setting.Email = dto.Email;
            if(dto.Phone2 != null)
            {
                Setting.Phone2 = dto.Phone2;
            }
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Setting
            };
        }
    }
}
