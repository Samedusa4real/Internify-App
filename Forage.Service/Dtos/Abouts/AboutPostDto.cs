using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Dtos.Abouts
{
    public class AboutPostDto
    {
        public IFormFile? Image { get; set; }
        [FromForm]
        public List<AboutLanguageDto> AboutLanguages { get; set; }
    }
    public class AboutLanguageDto
    {
        public int LanguageId { get; set; }
        public string? SmallHeader { get; set; }
        public string? MainHeader { get; set; }
        public string? MainText { get; set; }
        public string? SecondHeader { get; set; }
        public string? FirstStratHeader { get; set; }
        public string? FirstStratText { get; set; }
        public string? SecondStratHeader { get; set; }
        public string? SecondStratText { get; set; }
        public string? ThirdStratHeader { get; set; }
        public string? ThirdStratText { get; set; }
        public string? FourthStratHeader { get; set; }
        public string? FourthStratText { get; set; }
    }
}
