﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Dtos.CourseLessons
{
    public class CourseLessonUpdateDto
    {
        public string Name { get; set; }
        public string CourseDuration { get; set; }
        public string Description { get; set; }
        public IFormFile lessonVideo { get; set; }
        public int LessonLine { get; set; }
        public int CourseId { get; set; }
        public int CourseLessonLevelId { get; set; }

    }
}
