using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelBlog.Data.Migrations
{
    public partial class UpdatedImageUrls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/DSC01288.JPG");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/20210912_103641.jpg");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/20220907_104644.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/images/DSC01288.JPG");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "~/images/20210912_103641.jpg");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "~/images/20220907_104644.jpg");
        }
    }
}
