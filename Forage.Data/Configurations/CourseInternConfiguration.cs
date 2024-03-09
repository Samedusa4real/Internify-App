using Forage.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Data.Configurations
{
    public class CourseInternConfiguration : IEntityTypeConfiguration<CourseIntern>
    {
        public void Configure(EntityTypeBuilder<CourseIntern> builder)
        {
            builder.HasKey(x => new { x.CourseId, x.InternId });
        }
    }
}
