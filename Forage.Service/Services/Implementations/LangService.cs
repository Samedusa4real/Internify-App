using AutoMapper;
using Forage.Core.Entities;
using Forage.Core.Repositories;
using Forage.Service.Dtos.Abouts;
using Forage.Service.Dtos.Languages;
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
    public class LangService : ILanguageService
    {
        private readonly ILanguageRepository _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _evn;
        private readonly IHttpContextAccessor _http;

        public LangService(ILanguageRepository repository, IMapper mapper, IWebHostEnvironment evn, IHttpContextAccessor http)
        {
            _repository = repository;
            _mapper = mapper;
            _evn = evn;
            _http = http;
        }

        public async Task<ApiResponse> CreateAsync(LanguagePostDto dto)
        {
            Language Language = _mapper.Map<Language>(dto);
            await _repository.AddAsync(Language);
            await _repository.SaveAsync();

            return new ApiResponse
            {
                StatusCode = 201,
                items = Language
            };
        }

        public async Task<ApiResponse> GetAllAsync()
        {
            IEnumerable<Language> Languages = await _repository.GetAllAsync(x => !x.IsDeleted);
            return new ApiResponse
            {
                items = Languages,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Language? Language = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (Language == null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
            LanguageUpdateDto dto = _mapper.Map<LanguageUpdateDto>(Language);
            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Language Language = await _repository.GetAsync(x => x.Id == id);
            if (Language is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Language.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Language
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, LanguageUpdateDto dto)
        {
            Language Language = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (Language is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }

            Language.UpdatedAt = DateTime.UtcNow.AddHours(4);
            Language.Key = dto.Key;
            Language.Name = dto.Name;

            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Language
            };
        }
    }
}
