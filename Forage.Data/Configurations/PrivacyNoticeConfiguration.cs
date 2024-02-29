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
    public class PrivacyNoticeConfiguration:IEntityTypeConfiguration<PrivacyNotice>
    {
        public void Configure(EntityTypeBuilder<PrivacyNotice> builder)
        {
            builder.Property(x => x.Text).IsRequired();
            builder.Property(x => x.CreatedAt)
              .HasDefaultValue(DateTime.UtcNow.AddHours(4));
        }
    }
}
