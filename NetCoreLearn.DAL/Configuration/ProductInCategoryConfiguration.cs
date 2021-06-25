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
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategory");
            builder.HasKey(p => new { p.CategoryId, p.ProductId });

            builder.HasOne(p => p.Product)
                .WithMany(c => c.ProductInCategories)
                .HasForeignKey(c => c.ProductId);

            builder.HasOne(p => p.Category)
                .WithMany(c => c.ProductInCategories)
                .HasForeignKey(c => c.CategoryId);
        }
    }
}
