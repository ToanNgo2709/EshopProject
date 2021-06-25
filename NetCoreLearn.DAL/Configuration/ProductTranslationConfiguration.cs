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
    public class ProductTranslationConfiguration : IEntityTypeConfiguration<ProductTranslation>
    {
        public void Configure(EntityTypeBuilder<ProductTranslation> builder)
        {
            builder.ToTable("ProductTranslation");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                .UseIdentityColumn();

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.SeoAlias)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Details)
                .HasMaxLength(500);

            builder.Property(p => p.LanguageId)
                .IsUnicode(false)
                .IsRequired()
                .HasMaxLength(5);

            builder.HasOne(p => p.Language)
                .WithMany(p => p.ProductTranslations)
                .HasForeignKey(p => p.LanguageId);

            builder.HasOne(p => p.Product)
                .WithMany(p => p.ProductTranslations)
                .HasForeignKey(p => p.ProductId);
        }
    }
}
