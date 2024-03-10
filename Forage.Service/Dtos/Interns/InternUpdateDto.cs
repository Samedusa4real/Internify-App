using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Dtos.Interns
{
    public class InternUpdateDto
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? UniversityName { get; set; }
        public string? UniStartYear { get; set; }
        public string? UniGraduationYear { get; set; }
        public IFormFile? file { get; set; }
    }
}
