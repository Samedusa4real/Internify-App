using AutoMapper;
using Forage.Core.Entities;
using Forage.Service.Dtos.Abouts;
using Forage.Service.Dtos.PrivacyNotice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Profiles.Abouts
{
    public class AboutProfile:Profile
    {
        public AboutProfile()
        {
            CreateMap<AboutPostDto, About>();
            CreateMap<About, AboutUpdateDto>();
            CreateMap<AboutUpdateDto, About>();
        }
    }
}
