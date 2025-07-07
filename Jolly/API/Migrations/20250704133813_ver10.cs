using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_taiKhoans_NguoiDungId",
                table: "taiKhoans");

            migrationBuilder.CreateIndex(
                name: "IX_taiKhoans_NguoiDungId",
                table: "taiKhoans",
                column: "NguoiDungId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_taiKhoans_NguoiDungId",
                table: "taiKhoans");

            migrationBuilder.CreateIndex(
                name: "IX_taiKhoans_NguoiDungId",
                table: "taiKhoans",
                column: "NguoiDungId");
        }
    }
}
