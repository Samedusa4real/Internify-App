using Forage.Service.Dtos.Abouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Dtos.Contact
{
    public class ContactPostDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public List<ContactLanguageDto> ContactLanguages { get; set; }

    }
    public class ContactLanguageDto
    {
        public int LanguageId { get; set; }
        public string? ContactHeader { get; set; }
        public string? ContactBody { get; set; }
        public string? ShortInfo { get; set; }
        public string? SendButtonText { get; set; }
    }
}
