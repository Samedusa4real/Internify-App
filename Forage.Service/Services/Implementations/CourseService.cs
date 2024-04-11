using AutoMapper;
using Forage.Core.Entities;
using Forage.Core.Repositories;
using Forage.Data.Context;
using Forage.Service.Dtos.Courses;
using Forage.Service.Dtos.InternCourseTests;
using Forage.Service.Extensions;
using Forage.Service.Responses;
using Forage.Service.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Forage.Service.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly IInternCourseTestRepository _internCourseTestRepository;
        private readonly ICourseRepository _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _evn;
        private readonly IHttpContextAccessor _http;
        private readonly ISkillRepository _skillRepository;
        private readonly ICourseSkillRepository _courseSkillRepository;
        private readonly ForageAppDbContext _context;
        public CourseService(IInternCourseTestRepository internCourseTestRepository ,ICourseRepository repository, IMapper mapper, IWebHostEnvironment evn, IHttpContextAccessor http, ISkillRepository skillRepository, ICourseSkillRepository courseSkillRepository, ForageAppDbContext context)
        {
            _internCourseTestRepository = internCourseTestRepository;
            _repository = repository;
            _mapper = mapper;
            _evn = evn;
            _http = http;
            _skillRepository = skillRepository;
            _courseSkillRepository = courseSkillRepository;
            _context = context;
        }
        public async Task<ApiResponse> CreateAsync(CoursePostDto dto)
        {
            Course Course = _mapper.Map<Course>(dto);
            Course.AboutImage = dto.AboutImage.CreateImage(_evn.WebRootPath, "Images/Courses");
            Course.AboutImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
                + $"/Images/Courses/{Course.AboutImage}";
            foreach (var item in dto.SkillIds)
            {
                if (!await _skillRepository.isExsist(x => x.Id == item))
                {
                    return new ApiResponse
                    {
                        StatusCode = 404,
                        Description = "Invalid Skill Id"
                    };
                }
                CourseSkill CourseSkill = new CourseSkill
                {
                    CreatedAt = DateTime.Now,
                    Course = Course,
                    SkillId = item
                };
                await _courseSkillRepository.AddAsync(CourseSkill);
                Course.CourseSkills?.Add(CourseSkill);
            }
            await _repository.AddAsync(Course);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Course
            };
        }
        
        public async Task<ApiResponse> GetAllAsync(int? companyId = null, int? internId = null, int? courseCategoryId = null, int? courseLevelId = null, string? courseName = null, List<int>? skillIds = null)
        {
            IEnumerable<Course> courses = await _repository
                                            .GetAllAsync(x => (!companyId.HasValue || x.CompanyId == companyId) &&
                                                            (!internId.HasValue || x.InternCourses.Any(ic => ic.InternId == internId)) &&
                                                            (!courseCategoryId.HasValue || x.CourseCategoryId == courseCategoryId) &&
                                                            (!courseLevelId.HasValue || x.CourseLevelId == courseLevelId) &&
                                                            (courseName == null || x.Name.Contains(courseName)) &&
                                                            (!skillIds.Any() || x.CourseSkills.Any(cs => skillIds.Contains(cs.SkillId))) &&
                                                            !x.IsDeleted, "CourseLevel", "Company", "InternCourses.Intern", "CourseSkills.Skill", "CourseLessons");

            return new ApiResponse
            {
                items = courses,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Course? Course = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted,"CourseSkills");
            if (Course == null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
            CourseUpdateDto dto = _mapper.Map<CourseUpdateDto>(Course);
            dto.SkillIds = new List<int>();
			foreach (var item in Course.CourseSkills)
			{
				dto.SkillIds.Add(item.SkillId);
			}
			return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Course Course = await _repository.GetAsync(x => x.Id == id);
            if (Course is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Course.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Course
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, CourseUpdateDto dto)
        {
            Course Course = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (Course is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            if (dto.file is not null)
            {
                Course.AboutImage = dto.file.CreateImage(_evn.WebRootPath, "Images/Courses");
                Course.AboutImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
                    + $"Images/Courses/{Course.AboutImage}";
            }
            List<CourseSkill> RemoveableSkill = await _context.CourseSkills.
              Where(x => !dto.SkillIds.Contains(x.SkillId) && x.CourseId == Course.Id).ToListAsync();

            _context.CourseSkills.RemoveRange(RemoveableSkill);
            foreach (var item in dto.SkillIds)
            {
                if (_context.CourseSkills.Where(x => x.CourseId == id && x.SkillId == item).Count() > 0)
                    continue;

                await _courseSkillRepository.AddAsync(new CourseSkill
                {
                    CourseId = id,
                    SkillId = item,
                });
            }
            Course.UpdatedAt = DateTime.UtcNow.AddHours(4);
            Course.Name = dto.Name;
            Course.CourseDuration = dto.CourseDuration;
            Course.About = dto.About;
            Course.CompanyId = dto.CompanyId;
            Course.CourseCategoryId = dto.CourseCategoryId;
            Course.CourseLevelId = dto.CourseLevelId;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Course
            };
        }

        public async Task<ApiResponse> CreateLessonTestAsync(InternCourseTestPostDto dto)
        {
            InternCourseTest test = new InternCourseTest
            {
                Message = dto.Message,
                CourseId = dto.CourseId,
                CourseLessonId = dto.CourseLessonId,
                InternId = dto.InternId,
                TestFile = dto.TestFile.CreateImage(_evn.WebRootPath, "Files/InternLessonTest"),
                TestFileUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
                + $"Files/InternLessonTest/{dto.TestFile.CreateImage(_evn.WebRootPath, "Files/InternLessonTest")}",
            };

            await _internCourseTestRepository.AddAsync(test);
            await _internCourseTestRepository.SaveAsync();

            return new ApiResponse
            {
                StatusCode = 201,
                items = test
            };
        }

        public async Task<ApiResponse> GetAllTestAsync()
        {
            IEnumerable<InternCourseTest> CourseTests = await _internCourseTestRepository.GetAllAsync(x => !x.IsDeleted);
            return new ApiResponse
            {
                items = CourseTests,
                StatusCode = 200
            };
        }
    }
}
