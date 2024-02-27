using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Dtos.Accounts
{
    public class RegisterPartnerDto
    {
        public string CompanyName { get; set; }
        public string LegalAddress { get; set; }
        public string ActualAddress { get; set; }
        public string Username { get; set; }
        public string ResponsiblePersonAndPosition { get; set; }

        [EmailAddress]
        public string Email { get; set; }   
        public string PhoneNumber { get; set; }
        public int CompanyIndustryFieldId { get; set; }
        public string Password { get; set; }
        public string ConfirmedPassword { get; set; } = string.Empty;
        public string? role { get; set; }

    }
}
