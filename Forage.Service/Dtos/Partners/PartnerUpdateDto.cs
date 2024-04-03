using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Dtos.Partners
{
	public record PartnerUpdateDto
	{
		public string Name { get; set; }
        public string? LegalAddress { get; set; }
        public string? ActualAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public IFormFile? file { get; set; }
	}
}
