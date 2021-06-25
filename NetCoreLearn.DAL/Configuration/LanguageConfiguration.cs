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
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Languages");

            builder.HasKey(l => l.Id);
            builder.Property(l => l.Id)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(5);

            builder.Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(20);


        }
    }
}
