using AutoMapper;
using Forage.Core.Entities;
using Forage.Core.Repositories;
using Forage.Service.Dtos.Contact;
using Forage.Service.Dtos.PrivacyNotice;
using Forage.Service.Responses;
using Forage.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Services.Implementations
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _repository;
        private readonly IMapper _mapper;

        public ContactService(IContactRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponse> CreateAsync(ContactPostDto dto)
        {
            Contact contact = new Contact
            {
                FullName = dto.FullName,
                Email = dto.Email,
                Message = dto.Message,
                ContactLanguages = dto.ContactLanguages.Select(x => new ContactLanguage
                {
                    LanguageId = x.LanguageId,
                    ContactHeader = x.ContactHeader,
                    ContactBody = x.ContactBody,
                    ShortInfo = x.ShortInfo,
                    SendButtonText = x.SendButtonText,
                }).ToList(),
            };

            await _repository.AddAsync(contact);
            await _repository.SaveAsync();

            return new ApiResponse
            {
                StatusCode = 201,
                items = contact
            };
        }

        public async Task<ApiResponse> GetAllAsync()
        {
            IEnumerable<Contact> Contacts = await _repository.GetAllAsync(x => !x.IsDeleted, "ContactLanguages");
            return new ApiResponse
            {
                items = Contacts,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Contact? Contact = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted, "ContactLanguages");
            if (Contact == null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
            ContactPostDto dto = _mapper.Map<ContactPostDto>(Contact);
            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }
    }
}
