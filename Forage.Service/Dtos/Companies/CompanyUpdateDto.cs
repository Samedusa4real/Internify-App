using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Dtos.Companies
{
    public class CompanyUpdateDto
    {
        public string Name { get; set; }
        public string ActualAddress { get; set; }
        public string LegalAddress { get; set; }
        public IFormFile? file { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactPersonName { get; set; }
        public int CompanyIndustryFieldId { get; set; }
        public string AppUserId { get; set; }
    }
}
