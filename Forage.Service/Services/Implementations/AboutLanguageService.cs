using AutoMapper;
using Forage.Core.Entities;
using Forage.Core.Repositories;
using Forage.Service.Dtos.AboutLanguages;
using Forage.Service.Dtos.Abouts;
using Forage.Service.Responses;
using Forage.Service.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Forage.Service.Services.Implementations
{
    public class AboutLanguageService : IAboutLanguageService
    {
        private readonly IAboutLanguageRepository _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _evn;
        private readonly IHttpContextAccessor _http;

        public AboutLanguageService(IAboutLanguageRepository repository, IMapper mapper, IWebHostEnvironment evn, IHttpContextAccessor http)
        {
            _repository = repository;
            _mapper = mapper;
            _evn = evn;
            _http = http;
        }
        public async Task<ApiResponse> CreateAsync(AboutLanguagePostDto dto)
        {
            AboutLanguage AboutLanguage = _mapper.Map<AboutLanguage>(dto);
            await _repository.AddAsync(AboutLanguage);
            await _repository.SaveAsync();

            return new ApiResponse
            {
                StatusCode = 201,
                items = AboutLanguage
            };
        }

        public async Task<ApiResponse> GetAllAsync()
        {
            IEnumerable<AboutLanguage> AboutLanguages = await _repository.GetAllAsync(x => !x.IsDeleted);
            return new ApiResponse
            {
                items = AboutLanguages,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            AboutLanguage? AboutLanguage = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (AboutLanguage == null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
            AboutLanguagePutDto dto = _mapper.Map<AboutLanguagePutDto>(AboutLanguage);
            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            AboutLanguage AboutLanguage = await _repository.GetAsync(x => x.Id == id);
            if (AboutLanguage is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            AboutLanguage.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = AboutLanguage
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, AboutLanguagePutDto dto)
        {
            AboutLanguage AboutLanguage = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (AboutLanguage is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }

            AboutLanguage.UpdatedAt = DateTime.UtcNow.AddHours(4);
            AboutLanguage.SmallHeader = dto.SmallHeader;
            AboutLanguage.MainHeader = dto.MainHeader;
            AboutLanguage.MainText = dto.MainText;
            AboutLanguage.SecondHeader = dto.SecondHeader;
            AboutLanguage.FirstStratText = dto.FirstStratText;
            AboutLanguage.FirstStratHeader = dto.FirstStratHeader;
            AboutLanguage.SecondStratText = dto.SecondStratText;
            AboutLanguage.SecondStratHeader = dto.SecondStratHeader;
            AboutLanguage.ThirdStratText = dto.ThirdStratText;
            AboutLanguage.ThirdStratHeader = dto.ThirdStratHeader;
            AboutLanguage.FourthStratText = dto.FourthStratText;
            AboutLanguage.FourthStratHeader = dto.FourthStratHeader;
            AboutLanguage.AboutId = dto.AboutId;
            AboutLanguage.LanguageId = dto.LanguageId;

            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = AboutLanguage
            };
        }
    }
}
