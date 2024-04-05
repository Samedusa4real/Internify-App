using Forage.Service.Dtos.AboutLanguages;
using Forage.Service.Dtos.Abouts;
using Forage.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Services.Interfaces
{
    public interface IAboutLanguageService
    {
        public Task<ApiResponse> CreateAsync(AboutLanguagePostDto dto);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync();
        public Task<ApiResponse> UpdateAsync(int id, AboutLanguagePutDto dto);
        public Task<ApiResponse> RemoveAsync(int id);
    }
}
