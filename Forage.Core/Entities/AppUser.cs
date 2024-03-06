using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Core.Entities
{
    public class AppUser:IdentityUser
    {
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime RefreshTokenExpirationDate { get; set; }
        public string Role { get; set;}
        public List<Intern>? Interns { get; set; }
        public List<Company>? Companies { get; set; }
    }
}
