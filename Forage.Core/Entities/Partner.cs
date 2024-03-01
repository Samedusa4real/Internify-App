using Forage.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Core.Entities
{
	public class Partner:BaseEntitiy
	{
		public string Name { get; set; }
		public string Logo { get; set; }
		public string LogoUrl { get; set; }
        public string? CompanyName { get; set; }
        public string? LegalAddress { get; set; }
        public string? ActualAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public int CompanyIndustryFieldId { get; set; }
    }
}
