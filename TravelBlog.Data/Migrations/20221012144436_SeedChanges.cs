using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelBlog.Data.Migrations
{
    public partial class SeedChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "ImageUrl", "Title" },
                values: new object[] { "Vihren is the highest peak of Bulgaria's Pirin Mountains. Reaching 2,914 metres, it is Bulgaria's second and the Balkans' third highest, after Musala and Mount Olympus.!", "/images/20220907_104644.jpg", "Vihren Peak, Pirin Mountain" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "ImageUrl", "Title" },
                values: new object[] { "Raysko Praskalo, 124.5 m in height, is the highest waterfall in Bulgaria and the Balkan Peninsula. It is situated under Botev Peak in the central section of the Balkan Mountains and is part of the Dzhendema Reserve of the Central Balkan National Park. The nearest town is Kalofer, at 11 km to the south.", "/images/DSC01288.JPG", "Waterfall \"Raisko Praskalo\", Balkan Mountain" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "ImageUrl", "Title" },
                values: new object[] { "Raysko Praskalo, 124.5 m in height, is the highest waterfall in Bulgaria and the Balkan Peninsula. It is situated under Botev Peak in the central section of the Balkan Mountains and is part of the Dzhendema Reserve of the Central Balkan National Park. The nearest town is Kalofer, at 11 km to the south.", "/images/DSC01288.JPG", "Waterfall \"Raisko Praskalo\", Balkan Mountain" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "ImageUrl", "Title" },
                values: new object[] { "Vihren is the highest peak of Bulgaria's Pirin Mountains. Reaching 2,914 metres, it is Bulgaria's second and the Balkans' third highest, after Musala and Mount Olympus.!", "/images/20220907_104644.jpg", "Vihren Peak, Pirin Mountain" });
        }
    }
}
