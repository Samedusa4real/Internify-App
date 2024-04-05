using AutoMapper;
using Forage.Core.Entities;
using Forage.Service.Dtos.AboutLanguages;
using Forage.Service.Dtos.Abouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Profiles.AboutLanguages
{
    public class AboutLanguageProfile:Profile
    {
        public AboutLanguageProfile()
        {
            CreateMap<AboutLanguagePostDto, AboutLanguage>();
            CreateMap<AboutLanguage, AboutLanguagePutDto>();
            CreateMap<AboutLanguagePutDto, AboutLanguage>();
        }
    }
}
