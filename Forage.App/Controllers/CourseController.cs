using Forage.Service.Dtos.Courses;
using Forage.Service.Dtos.InternCourseTests;
using Forage.Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forage.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _service;

        public CourseController(ICourseService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] int? companyId = null, [FromQuery] int? internId = null, [FromQuery] int? courseCategoryId = null, [FromQuery] int? courseLevelId = null, [FromQuery] string? courseName = null, [FromQuery] List<int>? skillIds = null)
        {
            var result = await _service.GetAllAsync(companyId, internId, courseCategoryId, courseLevelId, courseName, skillIds);
            return StatusCode(result.StatusCode, result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetAsync(id);
            return StatusCode(result.StatusCode, result);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CoursePostDto dto)
        {
            var result = await _service.CreateAsync(dto);
            return StatusCode(result.StatusCode, result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.RemoveAsync(id);
            return StatusCode(result.StatusCode);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromForm] CourseUpdateDto dto)
        {
            var result = await _service.UpdateAsync(id, dto);
            return StatusCode(result.StatusCode, result);
        }
        [HttpPost("internCourseTest")]
        public async Task<IActionResult> CreateLessonTest([FromForm] InternCourseTestPostDto dto)
        {
            var result = await _service.CreateLessonTestAsync(dto);
            return StatusCode(result.StatusCode, result);
        }
    }
}
