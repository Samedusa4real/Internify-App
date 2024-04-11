using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Dtos.InternCourseTests
{
    public class InternCourseTestPostDto
    {
        public string? Message { get; set; }
        public IFormFile? TestFile { get; set; }
        public int? CourseLessonId { get; set; }
        public int? InternId { get; set; }
        public int? CourseId { get; set; }
    }
}
