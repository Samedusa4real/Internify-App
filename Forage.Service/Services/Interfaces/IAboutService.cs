using Forage.Service.Dtos.Abouts;
using Forage.Service.Dtos.PrivacyNotice;
using Forage.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Services.Interfaces
{
    public interface IAboutService
    {
        public Task<ApiResponse> CreateAsync(AboutPostDto dto);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync();
        public Task<ApiResponse> UpdateAsync(int id, AboutUpdateDto dto);
        public Task<ApiResponse> RemoveAsync(int id);
    }
}
