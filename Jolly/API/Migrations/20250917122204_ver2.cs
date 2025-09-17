using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HoaDonId",
                table: "trangThais",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_trangThais_HoaDonId",
                table: "trangThais",
                column: "HoaDonId");

            migrationBuilder.AddForeignKey(
                name: "FK_trangThais_hoaDons_HoaDonId",
                table: "trangThais",
                column: "HoaDonId",
                principalTable: "hoaDons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trangThais_hoaDons_HoaDonId",
                table: "trangThais");

            migrationBuilder.DropIndex(
                name: "IX_trangThais_HoaDonId",
                table: "trangThais");

            migrationBuilder.AlterColumn<string>(
                name: "HoaDonId",
                table: "trangThais",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
