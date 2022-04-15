using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using System;

namespace BootShop.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: true),
                    Discount = table.Column<double>(type: "double precision", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Telefon" },
                    { 2, "Laptop" },
                    { 3, "Tablet" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedDate", "Description", "Discount", "ImageUrl", "ModifiedDate", "Name", "Price" },
                values: new object[] { 10, null, null, null, 0.5, "https://productimages.hepsiburada.net/s/176/222-222/110000140392350.jpg/format:webp", null, "Huawei Matebook D15", 13000.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedDate", "Description", "Discount", "ImageUrl", "ModifiedDate", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, null, null, 0.5, "https://productimages.hepsiburada.net/s/49/222-222/10986386391090.jpg/format:webp", null, "İphone 11", 13000.0 },
                    { 2, 1, null, null, 0.5, "https://productimages.hepsiburada.net/s/41/222-222/10698988716082.jpg/format:webp", null, "Samsung Note 20", 13000.0 },
                    { 3, 1, null, null, 0.5, "https://productimages.hepsiburada.net/s/49/222-222/10986386391090.jpg/format:webp", null, "Xiomi Mi 11", 13000.0 },
                    { 4, 1, null, null, 0.5, "https://productimages.hepsiburada.net/s/41/222-222/10698988716082.jpg/format:webp", null, "Oppo Reno 5", 13000.0 },
                    { 5, 1, null, null, 0.5, "https://productimages.hepsiburada.net/s/49/222-222/10986386391090.jpg/format:webp", null, "Samsung A52", 13000.0 },
                    { 6, 2, null, null, 0.5, "https://productimages.hepsiburada.net/s/131/222-222/110000082171384.jpg/format:webp", null, "MSİ Gaming", 13000.0 },
                    { 7, 2, null, null, 0.5, "https://productimages.hepsiburada.net/s/49/222-222/10983950254130.jpg/format:webp", null, "Macbook Air M1", 13000.0 },
                    { 8, 2, null, null, 0.5, "https://productimages.hepsiburada.net/s/77/222-222/110000018961471.jpg/format:webp", null, "Thinkpad X1", 13000.0 },
                    { 9, 2, null, null, 0.5, "https://productimages.hepsiburada.net/s/42/222-222/10740711587890.jpg/format:webp", null, "Dell XPS 15", 13000.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
