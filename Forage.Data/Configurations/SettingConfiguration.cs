﻿using Forage.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Data.Configurations
{
    public class SettingConfiguration:IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder.Property(x => x.AboutText).IsRequired()
                .HasMaxLength(300);
            builder.Property(x => x.AboutImage).IsRequired();
            builder.Property(x => x.AboutImageUrl).IsRequired();
            builder.Property(x => x.Logo).IsRequired();
            builder.Property(x => x.LogoUrl).IsRequired();
            builder.Property(x => x.Phone1).IsRequired();
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.CreatedAt)
              .HasDefaultValue(DateTime.UtcNow.AddHours(4));
        }
    }
}
