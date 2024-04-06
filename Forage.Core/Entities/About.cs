using Forage.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Core.Entities
{
    public class About : BaseEntitiy
    {
        public string? Image { get; set; }
        public string? ImageUrl { get; set; }
        public List<AboutLanguage> AboutLanguages { get; set; }
    }
}
