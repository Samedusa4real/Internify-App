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
    public class PartnerConfiguration:IEntityTypeConfiguration<Partner>
    {
        public void Configure(EntityTypeBuilder<Partner> builder)
        {
			builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
			builder.Property(x => x.Logo).IsRequired();
			builder.Property(x => x.LogoUrl).IsRequired();
			builder.Property(x => x.CreatedAt)
              .HasDefaultValue(DateTime.UtcNow.AddHours(4));
        }
    }
}
