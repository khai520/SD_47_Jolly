using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_anhs_chiTietMonAns_ChiTietMonAnId1",
                table: "anhs");

            migrationBuilder.DropIndex(
                name: "IX_anhs_ChiTietMonAnId1",
                table: "anhs");

            migrationBuilder.DropColumn(
                name: "ChiTietMonAnId1",
                table: "anhs");

            migrationBuilder.AddColumn<bool>(
                name: "TrangThai",
                table: "chiTietMonAns",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "chiTietMonAns");

            migrationBuilder.AddColumn<Guid>(
                name: "ChiTietMonAnId1",
                table: "anhs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_anhs_ChiTietMonAnId1",
                table: "anhs",
                column: "ChiTietMonAnId1");

            migrationBuilder.AddForeignKey(
                name: "FK_anhs_chiTietMonAns_ChiTietMonAnId1",
                table: "anhs",
                column: "ChiTietMonAnId1",
                principalTable: "chiTietMonAns",
                principalColumn: "Id");
        }
    }
}
