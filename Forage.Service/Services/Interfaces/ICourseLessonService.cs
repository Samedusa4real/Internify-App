using Forage.Service.Dtos.CourseLessons;
using Forage.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Services.Interfaces
{
    public interface ICourseLessonService
    {
        public Task<ApiResponse> CreateAsync(CourseLessonPostDto dto);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync(int? courseId = null);
        public Task<ApiResponse> UpdateAsync(int id, CourseLessonUpdateDto dto);
        public Task<ApiResponse> RemoveAsync(int id);
    }
}
