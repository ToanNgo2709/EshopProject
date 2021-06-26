using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreLearn.DAL.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 26, 20, 7, 53, 293, DateTimeKind.Local).AddTicks(9098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 25, 20, 48, 1, 285, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is Home Page of EShop" },
                    { "HomeKeyword", "This is keyword of EShop" },
                    { "HomeDescription", "this is description of Eshop" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsShowOnHome", "ParentId", "SortOrder" },
                values: new object[,]
                {
                    { 1, true, null, 1 },
                    { 2, true, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "vn-VN", true, "Tiếng việt" },
                    { "en-US", false, "English" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "OriginalPrice", "Price", "SeoAlias" },
                values: new object[] { 1, new DateTime(2021, 6, 26, 20, 7, 53, 333, DateTimeKind.Local).AddTicks(5397), 100000m, 200000m, null });

            migrationBuilder.InsertData(
                table: "CategoryTranslation",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, 1, "vn-VN", "Áo Nam", "ao-nam", "Sản phẩm áo thời trang dành cho nam", "Sản phẩm áo thời trang dành cho nam" },
                    { 3, 2, "vn-VN", "Áo Nữ", "ao-nu", "Sản phẩm áo thời trang dành cho nu", "Sản phẩm áo thời trang dành cho nu" },
                    { 2, 1, "en-US", "Men Shirt", "men-shirt", "The shirt product for men", "The shirt product for men" },
                    { 4, 2, "en-US", "Woman Shirt", "woman-shirt", "The shirt product for women", "The shirt product for women" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductTranslation",
                columns: new[] { "Id", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, "Áo sơ mi nam trắng việt tiến", "Áo sơ mi nam trắng việt tiến", "vn-VN", "Áo sơ mi trắng việt tiến", 1, "ao-so-mi-trang-viet-tien", "Áo sơ mi trắng việt tiến", "Áo sơ mi trắng việt tiến" },
                    { 2, "Viet tien white shirt", "Viet tien white shirt", "vn-VN", "Viet tien white shirt", 1, "viet-tien-white-shirt", "Viet tien white shirt", "Viet tien white shirt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "CategoryTranslation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryTranslation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryTranslation",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryTranslation",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductInCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTranslation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTranslation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "en-US");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vn-VN");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 20, 48, 1, 285, DateTimeKind.Local).AddTicks(7442),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 26, 20, 7, 53, 293, DateTimeKind.Local).AddTicks(9098));
        }
    }
}
