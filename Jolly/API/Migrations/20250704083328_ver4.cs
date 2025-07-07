using System;
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
                name: "FK_combos_loais_LoaiId",
                table: "combos");

            migrationBuilder.AlterColumn<Guid>(
                name: "LoaiId",
                table: "combos",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_combos_loais_LoaiId",
                table: "combos",
                column: "LoaiId",
                principalTable: "loais",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_combos_loais_LoaiId",
                table: "combos");

            migrationBuilder.AlterColumn<Guid>(
                name: "LoaiId",
                table: "combos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_combos_loais_LoaiId",
                table: "combos",
                column: "LoaiId",
                principalTable: "loais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
