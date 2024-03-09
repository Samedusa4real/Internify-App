using Forage.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Core.Entities
{
    public class CourseIntern:BaseEntitiy
    {
        public int? CourseId { get; set; }
        public int? InternId { get; set; }

        public Course Course { get; set; }
        public Intern Intern { get; set; }
    }
}
