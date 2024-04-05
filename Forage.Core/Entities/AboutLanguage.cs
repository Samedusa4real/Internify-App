using Forage.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Core.Entities
{
    public class AboutLanguage : BaseEntitiy
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
        public int? AboutId { get; set; }
        public int? LanguageId { get; set; }
        public About About { get; set; }
        public Language Language { get; set; }
    }
}
