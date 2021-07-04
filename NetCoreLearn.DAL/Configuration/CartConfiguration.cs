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
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .UseIdentityColumn();

            builder.HasOne(p => p.Product)
                .WithMany(c => c.Carts)
                .HasForeignKey(c => c.ProductId);

            builder.HasOne(c => c.AppUser)
                .WithMany(a => a.Carts)
                .HasForeignKey(c => c.UserId);
        }
    }
}
