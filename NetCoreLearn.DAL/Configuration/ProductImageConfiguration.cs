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
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImage");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                .UseIdentityColumn();

            builder.Property(p => p.ImagePath)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.Caption)
                .HasMaxLength(200);

            builder.HasOne(pi => pi.Product)
                .WithMany(p => p.ProductImages)
                .HasForeignKey(pi => pi.ProductId);
        }
    }
}
