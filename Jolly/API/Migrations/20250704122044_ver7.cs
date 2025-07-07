using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_taiKhoans_NguoiDungId",
                table: "taiKhoans");

            migrationBuilder.DropIndex(
                name: "IX_nhanViens_NguoiDungId",
                table: "nhanViens");

            migrationBuilder.CreateIndex(
                name: "IX_taiKhoans_NguoiDungId",
                table: "taiKhoans",
                column: "NguoiDungId");

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_NguoiDungId",
                table: "nhanViens",
                column: "NguoiDungId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_taiKhoans_NguoiDungId",
                table: "taiKhoans");

            migrationBuilder.DropIndex(
                name: "IX_nhanViens_NguoiDungId",
                table: "nhanViens");

            migrationBuilder.CreateIndex(
                name: "IX_taiKhoans_NguoiDungId",
                table: "taiKhoans",
                column: "NguoiDungId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_NguoiDungId",
                table: "nhanViens",
                column: "NguoiDungId",
                unique: true);
        }
    }
}
