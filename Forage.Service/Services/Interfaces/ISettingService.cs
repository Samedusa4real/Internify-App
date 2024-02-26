using Forage.Service.Dtos.Settings;
using Forage.Service.Responses;
using Forage.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Services.Interfaces
{
    public interface ISettingService
    {
        public Task<ApiResponse> CreateAsync(SettingPostDto dto);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync();
        public Task<ApiResponse> UpdateAsync(int id, SettingUpdateDto dto);
        public Task<ApiResponse> RemoveAsync(int id);
        public Task<SettingVM> GetSetting();
    }
}
