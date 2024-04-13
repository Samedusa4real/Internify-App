using Forage.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Core.Entities
{
    public class InternCourseTest : BaseEntitiy
    {
        public string? Message { get; set; }
        public string? TestFile { get; set; }
        public string? TestFileUrl { get; set; }
        public int? CourseLessonId { get; set; }
        public int? InternId { get; set; }
        public int? CourseId { get; set; }
        public CourseLesson CourseLesson { get; set;}
        public Intern Intern { get; set; }
        public Course Course { get; set; }
        public string Status { get; set; }

        public InternCourseTest()
        {
            Status = "Waiting";
        }
    }
}
