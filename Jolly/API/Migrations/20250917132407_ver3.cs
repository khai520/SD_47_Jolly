using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hoaDons_chiTietMonAns_ChiTietMonAnId",
                table: "hoaDons");

            migrationBuilder.DropIndex(
                name: "IX_hoaDons_ChiTietMonAnId",
                table: "hoaDons");

            migrationBuilder.DropColumn(
                name: "ChiTietMonAnId",
                table: "hoaDons");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ChiTietMonAnId",
                table: "hoaDons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_ChiTietMonAnId",
                table: "hoaDons",
                column: "ChiTietMonAnId");

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDons_chiTietMonAns_ChiTietMonAnId",
                table: "hoaDons",
                column: "ChiTietMonAnId",
                principalTable: "chiTietMonAns",
                principalColumn: "Id");
        }
    }
}
