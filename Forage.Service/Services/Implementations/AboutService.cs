using AutoMapper;
using Forage.Core.Entities;
using Forage.Core.Repositories;
using Forage.Service.Dtos.Abouts;
using Forage.Service.Dtos.PrivacyNotice;
using Forage.Service.Responses;
using Forage.Service.Services.Interfaces;
using Forage.Service.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Forage.Data.Repositories;

namespace Forage.Service.Services.Implementations
{
    public class AboutService : IAboutService
    {
        private readonly IAboutLanguageRepository _languageRepository;
        private readonly IAboutUsRepository _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _evn;
        private readonly IHttpContextAccessor _http;

        public AboutService(IAboutLanguageRepository languageRepository,IAboutUsRepository repository, IMapper mapper, IWebHostEnvironment evn, IHttpContextAccessor http)
        {
            _languageRepository = languageRepository;
            _repository = repository;
            _mapper = mapper;
            _evn = evn;
            _http = http;
        }
        public async Task<ApiResponse> CreateAsync(AboutPostDto dto)
        {
            About about = new About
            {
                Image = dto.Image.CreateImage(_evn.WebRootPath, "Images/About"),
                ImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
                + $"Images/About/{dto.Image.CreateImage(_evn.WebRootPath, "Images/About")}",
                AboutLanguages = dto.AboutLanguages.Select(x => new AboutLanguage
                {
                    LanguageId = x.LanguageId,
                    SmallHeader = x.SmallHeader,
                    MainHeader = x.MainHeader,
                    MainText = x.MainText,
                    SecondHeader = x.SecondHeader,
                    FirstStratHeader = x.FirstStratHeader,
                    FirstStratText = x.FirstStratText,
                    SecondStratHeader = x.SecondStratHeader,
                    SecondStratText = x.SecondStratText,
                    ThirdStratHeader = x.ThirdStratHeader,
                    ThirdStratText = x.ThirdStratText,
                    FourthStratHeader = x.FourthStratHeader,
                    FourthStratText = x.FourthStratText,
                }).ToList(),
            };

            await _repository.AddAsync(about);
            await _repository.SaveAsync();

            return new ApiResponse
            {
                StatusCode = 201,
                items = about
            };
        }

        public async Task<ApiResponse> GetAllAsync()
        {
            IEnumerable<About> Abouts = await _repository.GetAllAsync(x => !x.IsDeleted, "AboutLanguages");
            return new ApiResponse
            {
                items = Abouts,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            About? About = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (About == null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
            AboutUpdateDto dto = _mapper.Map<AboutUpdateDto>(About);
            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            About About = await _repository.GetAsync(x => x.Id == id);
            if (About is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            About.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = About
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, AboutUpdateDto dto)
        {
            About About = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (About is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }

            if (dto.Image is not null)
            {
                About.Image = dto.Image.CreateImage(_evn.WebRootPath, "Images/About");
                About.ImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
                    + $"Images/About/{About.Image}";
            }

            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = About
            };
        }
    }
}
