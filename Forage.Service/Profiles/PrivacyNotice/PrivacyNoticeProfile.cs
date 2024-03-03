using AutoMapper;
using Forage.Core.Entities;
using Forage.Service.Dtos.PrivacyNotice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Profiles.PrivacyNotice
{
    public class PrivacyNoticeProfile : Profile
    {
        public PrivacyNoticeProfile()
        {
            CreateMap<PrivacyNoticePostDto, Forage.Core.Entities.PrivacyNotice>();
            CreateMap<Forage.Core.Entities.PrivacyNotice, PrivacyNoticeUpdateDto>();
            CreateMap<PrivacyNoticeUpdateDto, Forage.Core.Entities.PrivacyNotice>();
        }
    }
}
