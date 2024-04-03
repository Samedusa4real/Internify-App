using Forage.Core.Entities.BaseEntities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Core.Entities
{
    public class Intern:BaseEntitiy
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        [AllowNull]
        public string? BirthYear { get; set; }
        public string AppUserId { get; set; }
        public string Image { get; set; }
        public string? Experience { get; set; }
        public string ImageUrl { get; set; }
        public string CvFileName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? UniversityName { get; set; }
        public string? UniStartYear { get; set; }
        public string? UniGraduationYear { get; set; }
        public AppUser AppUser { get; set; }

        public List<CourseIntern>? InternCourses { get; set; }
    }
}
