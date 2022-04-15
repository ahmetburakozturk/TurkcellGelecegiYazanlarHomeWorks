using Microsoft.EntityFrameworkCore.Migrations;

namespace BootShop.DataAccess.Migrations
{
    public partial class upd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://productimages.hepsiburada.net/s/131/222-222/110000082286300.jpg/format:webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://productimages.hepsiburada.net/s/73/222-222/110000014912740.jpg/format:webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://productimages.hepsiburada.net/s/79/222-222/110000021519477.jpg/format:webp");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedDate", "Description", "Discount", "ImageUrl", "ModifiedDate", "Name", "Price" },
                values: new object[,]
                {
                    { 11, 2, null, null, 0.5, "https://productimages.hepsiburada.net/s/49/222-222/10983950254130.jpg/format:webp", null, "Macbook Air M1", 13000.0 },
                    { 12, 2, null, null, 0.5, "https://productimages.hepsiburada.net/s/77/222-222/110000018961471.jpg/format:webp", null, "Thinkpad X1", 13000.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://productimages.hepsiburada.net/s/49/222-222/10986386391090.jpg/format:webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://productimages.hepsiburada.net/s/41/222-222/10698988716082.jpg/format:webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://productimages.hepsiburada.net/s/49/222-222/10986386391090.jpg/format:webp");
        }
    }
}
