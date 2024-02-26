using AutoMapper;
using Forage.Core.Entities;
using Forage.Service.Dtos.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Profiles.Settings
{
    public class SettingProfile:Profile
    {
        public SettingProfile()
        {
            CreateMap<SettingPostDto, Setting>();
            CreateMap<SettingUpdateDto, Setting>();
            CreateMap<Setting, SettingUpdateDto>();
        }
    }
}
