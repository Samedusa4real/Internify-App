using AutoMapper;
using Forage.Core.Entities;
using Forage.Service.Dtos.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Profiles.Contacts
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<ContactPostDto, Contact>();
            CreateMap<Contact, ContactPostDto>();
        }
    }
}
