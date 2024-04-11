using Forage.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Core.Entities
{
    public class Contact:BaseEntitiy
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public List<ContactLanguage> ContactLanguages { get; set; }
    }

    public class ContactLanguage
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int ContactId { get; set; }
        public string? ContactHeader { get; set; }
        public string? ContactBody { get; set; }
        public string? ShortInfo { get; set; }
        public string? SendButtonText { get; set; }
        public Language Language { get; set; }
        public Contact Contact { get; set; }
    }
}
    