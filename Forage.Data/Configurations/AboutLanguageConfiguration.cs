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
    public class AboutLanguageConfiguration : IEntityTypeConfiguration<AboutLanguage>
    {
        public void Configure(EntityTypeBuilder<AboutLanguage> builder)
        {
            builder.Property(x => x.SmallHeader).IsRequired();
            builder.Property(x => x.MainHeader).IsRequired();
            builder.Property(x => x.MainText).IsRequired();
            builder.Property(x => x.SecondHeader).IsRequired();
            builder.Property(x => x.FirstStratText).IsRequired();
            builder.Property(x => x.FirstStratHeader).IsRequired();
            builder.Property(x => x.SecondStratText).IsRequired();
            builder.Property(x => x.SecondStratHeader).IsRequired();
            builder.Property(x => x.ThirdStratText).IsRequired();
            builder.Property(x => x.ThirdStratHeader).IsRequired();
            builder.Property(x => x.FourthStratText).IsRequired();
            builder.Property(x => x.FourthStratHeader).IsRequired();
            builder.Property(x => x.CreatedAt)
              .HasDefaultValue(DateTime.UtcNow.AddHours(4));
        }
    }
}
