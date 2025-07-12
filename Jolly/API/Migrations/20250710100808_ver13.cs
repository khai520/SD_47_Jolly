using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gia",
                table: "monAns");

            migrationBuilder.AddColumn<float>(
                name: "TongTienSauKhiGiam",
                table: "hoaDons",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Gia",
                table: "chiTietMonAns",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TongTienSauKhiGiam",
                table: "hoaDons");

            migrationBuilder.DropColumn(
                name: "Gia",
                table: "chiTietMonAns");

            migrationBuilder.AddColumn<float>(
                name: "Gia",
                table: "monAns",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
