using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreLearn.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreLearn.DAL.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");
            builder.Property(a => a.FirstName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(a => a.LastName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(a => a.Dob)
                .IsRequired();

        }
    }
}
