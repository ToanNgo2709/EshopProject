using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NetCoreLearn.DAL.Enums;
using NetCoreLearn.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreLearn.DAL.Extension
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is Home Page of EShop" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of EShop" },
                new AppConfig() { Key = "HomeDescription", Value = "this is description of Eshop" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language()
                {
                    Id = "vn-VN",
                    Name = "Tiếng việt",
                    IsDefault = true
                },
                new Language()
                {
                    Id = "en-US",
                    Name = "English",
                    IsDefault = false
                }


                );

            //Must enter identity value although id can auto increment
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active
                }


                );
            modelBuilder.Entity<CategoryTranslation>().HasData(
                 new CategoryTranslation()
                 {
                     Id = 1,
                     CategoryId = 1,
                     Name = "Áo Nam",
                     LanguageId = "vn-VN",
                     SeoAlias = "ao-nam",
                     SeoDescription = "Sản phẩm áo thời trang dành cho nam",
                     SeoTitle = "Sản phẩm áo thời trang dành cho nam"
                 },
                 new CategoryTranslation()
                 {
                     Id = 2,
                     CategoryId = 1,
                     Name = "Men Shirt",
                     LanguageId = "en-US",
                     SeoAlias = "men-shirt",
                     SeoDescription = "The shirt product for men",
                     SeoTitle = "The shirt product for men"
                 },
                 new CategoryTranslation()
                 {
                     Id = 3,
                     CategoryId = 2,
                     Name = "Áo Nữ",
                     LanguageId = "vn-VN",
                     SeoAlias = "ao-nu",
                     SeoDescription = "Sản phẩm áo thời trang dành cho nu",
                     SeoTitle = "Sản phẩm áo thời trang dành cho nu"
                 },
                 new CategoryTranslation()
                 {
                     Id = 4,
                     CategoryId = 2,
                     LanguageId = "en-US",
                     Name = "Woman Shirt",
                     SeoAlias = "woman-shirt",
                     SeoDescription = "The shirt product for women",
                     SeoTitle = "The shirt product for women"
                 }


                );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0
                }
                );

            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Áo sơ mi trắng việt tiến",
                    LanguageId = "vn-VN",
                    SeoAlias = "ao-so-mi-trang-viet-tien",
                    SeoDescription = "Áo sơ mi trắng việt tiến",
                    SeoTitle = "Áo sơ mi trắng việt tiến",
                    Details = "Áo sơ mi nam trắng việt tiến",
                    Description = "Áo sơ mi nam trắng việt tiến"
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Viet tien white shirt",
                    LanguageId = "vn-VN",
                    SeoAlias = "viet-tien-white-shirt",
                    SeoDescription = "Viet tien white shirt",
                    SeoTitle = "Viet tien white shirt",
                    Details = "Viet tien white shirt",
                    Description = "Viet tien white shirt"
                }

                );

            modelBuilder.Entity<ProductInCategory>().HasData(
                    new ProductInCategory()
                    {
                        CategoryId = 1,
                        ProductId = 1
                    }

                );


            //Identity User Data Seeding
            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");

            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "toan.international@gmail.com",
                NormalizedEmail = "toan.international@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Toan",
                LastName = "Ngo",
                Dob = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
