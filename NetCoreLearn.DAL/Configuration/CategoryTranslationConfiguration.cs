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
    public class CategoryTranslationConfiguration : IEntityTypeConfiguration<CategoryTranslation>
    {
        public void Configure(EntityTypeBuilder<CategoryTranslation> builder)
        {
            builder.ToTable("CategoryTranslation");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            builder.Property(c => c.Name)
                .HasMaxLength(200);

            builder.Property(c => c.SeoAlias)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.SeoDescription)
                .HasMaxLength(500);

            builder.Property(c => c.SeoTitle)
                .HasMaxLength(200);

            builder.Property(c => c.LanguageId)
                .IsUnicode(false)
                .IsRequired()
                .HasMaxLength(5);

            builder.HasOne(c => c.Language)
                .WithMany(l => l.CategoryTranslations)
                .HasForeignKey(c => c.LanguageId);

            builder.HasOne(c => c.Category)
                .WithMany(c => c.CategoryTranslations)
                .HasForeignKey(c => c.CategoryId);
        }
    }
}
