using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_nhanViens_NguoiDungId",
                table: "nhanViens");

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_NguoiDungId",
                table: "nhanViens",
                column: "NguoiDungId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_nhanViens_NguoiDungId",
                table: "nhanViens");

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_NguoiDungId",
                table: "nhanViens",
                column: "NguoiDungId");
        }
    }
}
