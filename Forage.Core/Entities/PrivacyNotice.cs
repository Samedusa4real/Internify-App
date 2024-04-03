using Forage.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Core.Entities
{
    public class PrivacyNotice:BaseEntitiy
    {
        public string Title { get; set; }
        [MaxLength(-1)]
        public string Text { get; set; }
    }
}
