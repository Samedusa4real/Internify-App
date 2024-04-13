using Forage.Service.Dtos.Courses;
using Forage.Service.Dtos.InternCourseTests;
using Forage.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Services.Interfaces
{
    public interface ICourseService
    {
        public Task<ApiResponse> CreateAsync(CoursePostDto dto);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync(int? companyId = null, int? internId = null, int? courseCategoryId = null, int? courseLevelId = null, string? courseName = null, List<int>? skillIds = null);
        public Task<ApiResponse> UpdateAsync(int id, CourseUpdateDto dto);
        public Task<ApiResponse> RemoveAsync(int id);
        public Task<ApiResponse> CreateLessonTestAsync(InternCourseTestPostDto dto);
        public Task<ApiResponse> GetAllTestAsync();
        public Task<ApiResponse> RemoveTestAsync(int id);
    }
}
