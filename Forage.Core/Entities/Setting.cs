using Forage.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Core.Entities
{
    public class Setting:BaseEntitiy
    {
        public string AboutText { get; set; }
        public string AboutImage { get; set; } 
        public string AboutImageUrl { get; set; } 
        public string Logo { get; set; }
        public string LogoUrl { get; set;}
        public string Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string Address {  get; set; }
        public string Email { get; set; }
    }
}
