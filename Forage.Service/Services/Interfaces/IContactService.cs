using Forage.Service.Dtos.CompanyIndustryFields;
using Forage.Service.Dtos.Contact;
using Forage.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Services.Interfaces
{
    public interface IContactService
    {
        public Task<ApiResponse> CreateAsync(ContactPostDto dto);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync();
    }
}
