using AutoMapper;
using Forage.Core.Entities;
using Forage.Core.Repositories;
using Forage.Data.Context;
using Forage.Service.Dtos.CourseLevels;
using Forage.Service.Dtos.PrivacyNotice;
using Forage.Service.Responses;
using Forage.Service.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Services.Implementations
{
    public class PrivacyNoticeService : IPrivacyNoticeService
    {
        private readonly IPrivacyNoticeRepository _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;
        private readonly IHttpContextAccessor _http;
        private readonly ForageAppDbContext _context;

        public PrivacyNoticeService(IPrivacyNoticeRepository repository, IMapper mapper, IWebHostEnvironment env, IHttpContextAccessor http, ForageAppDbContext context)
        {
            _repository = repository;
            _mapper = mapper;
            _env = env;
            _http = http;
            _context = context;
        }

        public async Task<ApiResponse> CreateAsync(PrivacyNoticePostDto dto)
        {
            PrivacyNotice PrivacyNotice = _mapper.Map<PrivacyNotice>(dto);
            await _repository.AddAsync(PrivacyNotice);
            await _repository.SaveAsync();

            return new ApiResponse
            {
                StatusCode = 201,
                items = PrivacyNotice
            };
        }

        public async Task<ApiResponse> GetAllAsync()
        {
            IEnumerable<PrivacyNotice> PrivacyNotices = await _repository.GetAllAsync(x => !x.IsDeleted);
            return new ApiResponse
            {
                items = PrivacyNotices,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            PrivacyNotice? PrivacyNotice = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (PrivacyNotice == null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
            PrivacyNoticeUpdateDto dto = _mapper.Map<PrivacyNoticeUpdateDto>(PrivacyNotice);
            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            PrivacyNotice PrivacyNotice = await _repository.GetAsync(x => x.Id == id);
            if (PrivacyNotice is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            PrivacyNotice.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = PrivacyNotice
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, PrivacyNoticeUpdateDto dto)
        {
            PrivacyNotice PrivacyNotice = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (PrivacyNotice is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }

            PrivacyNotice.UpdatedAt = DateTime.UtcNow.AddHours(4);
            PrivacyNotice.Text = dto.Text;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = PrivacyNotice
            };
        }
    }
}
