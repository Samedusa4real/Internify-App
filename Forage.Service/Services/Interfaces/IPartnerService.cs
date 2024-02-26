using Forage.Service.Dtos.Partners;
using Forage.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Services.Interfaces
{
    public interface IPartnerService
    {
        public Task<ApiResponse> CreateAsync(PartnerPostDto dto);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync();
        public Task<ApiResponse> UpdateAsync(int id, PartnerUpdateDto dto);
        public Task<ApiResponse> RemoveAsync(int id);
    }
}
