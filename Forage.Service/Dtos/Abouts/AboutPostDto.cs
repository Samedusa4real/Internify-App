using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Dtos.Abouts
{
    public class AboutPostDto
    {
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
        public IFormFile? Image { get; set; }
    }
}
