using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Dtos.Accounts
{
    public class RegisterInternDto
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string BirthYear { get; set; }
        public string Experience { get; set; }
        public string FieldsOfLaw { get; set; }
        public string FinNumber { get; set; }
        public IFormFile Image { get; set; }
        public string? role { get; set; }
    }
}
