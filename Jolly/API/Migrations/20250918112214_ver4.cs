using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_chiTietMonAns_dongGois_DongGoiId",
                table: "chiTietMonAns");

            migrationBuilder.RenameColumn(
                name: "DongGoiId",
                table: "chiTietMonAns",
                newName: "NguyenLieuId");

            migrationBuilder.RenameIndex(
                name: "IX_chiTietMonAns_DongGoiId",
                table: "chiTietMonAns",
                newName: "IX_chiTietMonAns_NguyenLieuId");

            migrationBuilder.AddForeignKey(
                name: "FK_chiTietMonAns_dongGois_NguyenLieuId",
                table: "chiTietMonAns",
                column: "NguyenLieuId",
                principalTable: "dongGois",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_chiTietMonAns_dongGois_NguyenLieuId",
                table: "chiTietMonAns");

            migrationBuilder.RenameColumn(
                name: "NguyenLieuId",
                table: "chiTietMonAns",
                newName: "DongGoiId");

            migrationBuilder.RenameIndex(
                name: "IX_chiTietMonAns_NguyenLieuId",
                table: "chiTietMonAns",
                newName: "IX_chiTietMonAns_DongGoiId");

            migrationBuilder.AddForeignKey(
                name: "FK_chiTietMonAns_dongGois_DongGoiId",
                table: "chiTietMonAns",
                column: "DongGoiId",
                principalTable: "dongGois",
                principalColumn: "Id");
        }
    }
}
