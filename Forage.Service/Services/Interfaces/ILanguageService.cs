using Forage.Service.Dtos.Abouts;
using Forage.Service.Dtos.Languages;
using Forage.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Services.Interfaces
{
    public interface ILanguageService
    {
        public Task<ApiResponse> CreateAsync(LanguagePostDto dto);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync();
        public Task<ApiResponse> UpdateAsync(int id, LanguageUpdateDto dto);
        public Task<ApiResponse> RemoveAsync(int id);
    }
}
