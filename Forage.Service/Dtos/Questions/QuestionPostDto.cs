using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Dtos.Questions
{
    public class QuestionPostDto
    {
        public List<QuestionLanguageDto> QuestionLanguages { get; set; }
    }
    public class QuestionLanguageDto
    {
        public int? LanguageId { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
    }
}
