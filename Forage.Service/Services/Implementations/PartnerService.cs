using AutoMapper;
using Forage.Core.Entities;
using Forage.Core.Repositories;
using Forage.Service.Dtos.CourseLevels;
using Forage.Service.Dtos.Partners;
using Forage.Service.Extensions;
using Forage.Service.Responses;
using Forage.Service.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Forage.Service.Services.Implementations
{
    public class PartnerService : IPartnerService
    {
        private readonly IPartnerRepository _repository;
        private readonly IMapper _mapper;
		private readonly IWebHostEnvironment _evn;
		private readonly IHttpContextAccessor _http;
		public PartnerService(IPartnerRepository repository, IMapper mapper, IHttpContextAccessor http, IWebHostEnvironment evn)
		{
			_repository = repository;
			_mapper = mapper;
			_http = http;
			_evn = evn;
		}
		public async Task<ApiResponse> CreateAsync(PartnerPostDto dto)
        {
            if (await _repository.isExsist(x => x.Name.Trim().ToLower() == dto.Name.Trim().ToLower()))
            {
                return new ApiResponse
                {
                    StatusCode = 400,
                    Description = $"{dto.Name} Already exists"
                };
            }
            Partner Partner = _mapper.Map<Partner>(dto);
			Partner.Logo = dto.file.CreateImage(_evn.WebRootPath, "/Images/Partners");
			Partner.LogoUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
				+ $"Images/Partners/{Partner.Logo}";
			await _repository.AddAsync(Partner);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Partner
            };
        }

        public async Task<ApiResponse> GetAllAsync()
        {
            IEnumerable<Partner> Partners = await _repository.GetAllAsync(x => !x.IsDeleted);
            return new ApiResponse
            {
                items = Partners,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Partner? Partner = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (Partner == null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
			PartnerUpdateDto dto = _mapper.Map<PartnerUpdateDto>(Partner);
			return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Partner Partner = await _repository.GetAsync(x => x.Id == id);
            if (Partner is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Partner.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Partner
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, PartnerUpdateDto dto)
        {
            Partner Partner = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (Partner is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            if (Partner.Name.ToLower() != dto.Name.ToLower())
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
				Partner.Logo = dto.file.CreateImage(_evn.WebRootPath, "Images/Partners");
				Partner.LogoUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
					+ $"Images/Partners/{Partner.Logo}";
			}
			Partner.UpdatedAt = DateTime.UtcNow.AddHours(4);
            Partner.Name = dto.Name;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Partner
            };
        }
    }
}
