using AutoMapper;
using Forage.Core.Entities;
using Forage.Service.Dtos.Partners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Profiles.Partners
{
    public class PartnerProfile:Profile
    {
        public PartnerProfile()
        {
            CreateMap<PartnerPostDto, Partner>();
            CreateMap<PartnerUpdateDto, Partner>();
            CreateMap<Partner, PartnerUpdateDto>();
        }
    }
}
