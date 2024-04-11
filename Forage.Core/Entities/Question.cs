using Forage.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Core.Entities
{
    public class Question:BaseEntitiy
    {
        public List<QuestionLanguage> QuestionLanguages { get; set; }
    }

    public class QuestionLanguage
    {
        public int Id { get; set; }
        public int? LanguageId { get; set; }
        public int? QuestionId { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        public Question Question { get; set; }
        public Language Language { get; set; }
    }
}
