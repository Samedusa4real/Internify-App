﻿using AutoMapper;
using Forage.Core.Entities;
using Forage.Core.Repositories;
using Forage.Data.Context;
using Forage.Service.Dtos.Courses;
using Forage.Service.Dtos.InternCourses;
using Forage.Service.Dtos.Interns;
using Forage.Service.Extensions;
using Forage.Service.Responses;
using Forage.Service.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Forage.Service.Services.Implementations
{
    public class InternService : IInternService
    {
        private readonly IInternRepository _repository;
        private readonly ICourseRepository _courseRepository;
        private readonly IInternCourseRepository _internCourseRepository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _evn;
        private readonly IHttpContextAccessor _http;
        private readonly ForageAppDbContext _context;

        public InternService(IInternRepository repository, ICourseRepository courseRepository, IInternCourseRepository internCourseRepository , IMapper mapper, IWebHostEnvironment evn, IHttpContextAccessor http, ForageAppDbContext context)
        {
            _repository = repository;
            _courseRepository = courseRepository;
            _internCourseRepository = internCourseRepository;
            _mapper = mapper;
            _evn = evn;
            _http = http;
            _context = context;
        }

        public async Task<ApiResponse> AddCourseToInternAsync(InternCoursePostDto dto)
        {
            var existingInternCourse = await _internCourseRepository.isExsist(x => x.InternId == dto.InternId && x.CourseId == dto.CourseId);

            if (!existingInternCourse)
            {
                CourseIntern InternCourse = _mapper.Map<CourseIntern>(dto);

                await _internCourseRepository.AddAsync(InternCourse);
                await _internCourseRepository.SaveAsync();
                return new ApiResponse { StatusCode = 200, Description = "Course added to Intern's courses list successfully" };
            }

            else
                return new ApiResponse { StatusCode = 400, Description = "Already exist!" };
        }

        public async Task<ApiResponse> DeleteCourseFromInternAsync(int internId, int courseId)
        {
            CourseIntern CourseIntern = await _internCourseRepository.GetAsync(x=>x.InternId == internId && x.CourseId == courseId);

            if (CourseIntern != null)
            {
                _context.CourseInterns.Remove(CourseIntern);
                await _internCourseRepository.SaveAsync();
                return new ApiResponse { StatusCode = 200, Description = "Course removed from Intern's courses list successfully" };
            }

            else
                return new ApiResponse { StatusCode = 400, Description = "Course not found in Intern's courses list" };
        }

        public async Task<ApiResponse> CreateAsync(InternPostDto dto)
        {
            if (await _repository.isExsist(x => x.Name.Trim().ToLower() == dto.Name.Trim().ToLower()))
            {
                return new ApiResponse
                {
                    StatusCode = 400,
                    Description = $"{dto.Name} Already exists"
                };
            }
            Intern Intern = _mapper.Map<Intern>(dto);
            Intern.Image = dto.Image.CreateImage(_evn.WebRootPath, "Images/Interns");
            Intern.ImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
                + $"Images/Interns/{Intern.Image}";
            await _repository.AddAsync(Intern);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Intern
            };
        }

        public async Task<ApiResponse> GetAllAsync(int? companyId = null)
        {
            IEnumerable<Intern> Interns = await _repository.GetAllAsync(x =>
                (!companyId.HasValue || x.InternCourses.Any(ic => ic.Course.CompanyId == companyId)) &&
                !x.IsDeleted, "InternCourses.Course");

            return new ApiResponse
            {
                items = Interns,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Intern? Intern = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (Intern == null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
			InternUpdateDto dto = _mapper.Map<InternUpdateDto>(Intern);
			return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }
		public async Task<ApiResponse> GetDetailAsync(int id)
		{
			Intern? Intern = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted, "AppUser");
			if (Intern == null)
			{
				return new ApiResponse
				{
					StatusCode = 404
				};
			}
			return new ApiResponse
			{
				StatusCode = 200,
				items = Intern
			};
		}

		public async Task<ApiResponse> RemoveAsync(int id)
        {
            Intern Intern = await _repository.GetAsync(x => x.Id == id);
            if (Intern is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Intern.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Intern
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, InternUpdateDto dto)
        {
            Intern Intern = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (Intern is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            if (Intern.Name.ToLower() != dto.Name.ToLower())
            {
                if (await _repository.isExsist(x => x.Name.Trim().ToLower() == dto.Name.Trim().ToLower()))
                {
                    return new ApiResponse
                    {
                        StatusCode = 400,
                        Description = $"{dto.Name} Already exists"
                    };
                }
            }
            if (dto.file is not null)
            {
                Intern.Image = dto.file.CreateImage(_evn.WebRootPath, "Images/Interns");
                Intern.ImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
                    + $"Images/Interns/{Intern.Image}";
            }
            Intern.UpdatedAt = DateTime.UtcNow.AddHours(4);
            Intern.Name = dto.Name;
            Intern.Surname = dto.Surname;
            Intern.Gender = dto.Gender;
            Intern.PhoneNumber = dto.PhoneNumber;
            Intern.Email = dto.Email;
            Intern.UniversityName = dto.UniversityName;
            Intern.UniGraduationYear = dto.UniGraduationYear;
            Intern.UniStartYear = dto.UniStartYear;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Intern
            };
        }
    }
}
