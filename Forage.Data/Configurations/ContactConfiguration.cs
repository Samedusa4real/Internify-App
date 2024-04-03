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
    public class ContactConfiguration:IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(x=>x.FullName).IsRequired().HasMaxLength(25);
            builder.Property(x=>x.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Message).IsRequired().HasMaxLength(500);
        }
    }
}
