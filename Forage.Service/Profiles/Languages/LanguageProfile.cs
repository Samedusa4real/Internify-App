using AutoMapper;
using Forage.Core.Entities;
using Forage.Service.Dtos.Abouts;
using Forage.Service.Dtos.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Profiles.Languages
{
    public class LanguageProfile:Profile
    {
        public LanguageProfile()
        {
            CreateMap<LanguagePostDto, Language>();
            CreateMap<Language, LanguageUpdateDto>();
            CreateMap<LanguageUpdateDto, Language>();
        }
    }
}
