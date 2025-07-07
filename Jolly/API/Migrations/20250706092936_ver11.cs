using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_anhs_chiTietMonAns_ChiTietMonAnId",
                table: "anhs");

            migrationBuilder.AlterColumn<float>(
                name: "Gia",
                table: "monAns",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Soluong",
                table: "chiTietMonAns",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                name: "FK_anhs_chiTietMonAns_ChiTietMonAnId",
                table: "anhs",
                column: "ChiTietMonAnId",
                principalTable: "chiTietMonAns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_anhs_chiTietMonAns_ChiTietMonAnId1",
                table: "anhs",
                column: "ChiTietMonAnId1",
                principalTable: "chiTietMonAns",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_anhs_chiTietMonAns_ChiTietMonAnId",
                table: "anhs");

            migrationBuilder.DropForeignKey(
                name: "FK_anhs_chiTietMonAns_ChiTietMonAnId1",
                table: "anhs");

            migrationBuilder.DropIndex(
                name: "IX_anhs_ChiTietMonAnId1",
                table: "anhs");

            migrationBuilder.DropColumn(
                name: "ChiTietMonAnId1",
                table: "anhs");

            migrationBuilder.AlterColumn<float>(
                name: "Gia",
                table: "monAns",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "Soluong",
                table: "chiTietMonAns",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_anhs_chiTietMonAns_ChiTietMonAnId",
                table: "anhs",
                column: "ChiTietMonAnId",
                principalTable: "chiTietMonAns",
                principalColumn: "Id");
        }
    }
}
