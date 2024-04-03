using Forage.Service.Dtos.InternCourses;
using Forage.Service.Dtos.Interns;
using Forage.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Services.Interfaces
{
    public interface IInternService
    {
        public Task<ApiResponse> CreateAsync(InternPostDto dto);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync(int? companyId = null);
		public Task<ApiResponse> GetDetailAsync(int id);
		public Task<ApiResponse> UpdateAsync(int id, InternUpdateDto dto);
        public Task<ApiResponse> RemoveAsync(int id);
        public Task<ApiResponse> AddCourseToInternAsync(InternCoursePostDto dto);
        public Task<ApiResponse> DeleteCourseFromInternAsync(int internId, int courseId);

    }
}
