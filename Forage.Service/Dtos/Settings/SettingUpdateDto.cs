using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Dtos.Settings
{
    public record SettingUpdateDto
    {
        public string AboutText { get; set; }
        public IFormFile image { get; set; }
        public IFormFile logoo { get; set; }
        public string Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
