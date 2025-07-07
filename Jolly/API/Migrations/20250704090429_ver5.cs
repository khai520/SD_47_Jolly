using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_chiTietCombos_combos_ComboId",
                table: "chiTietCombos");

            migrationBuilder.DropForeignKey(
                name: "FK_chiTietCombos_monAns_MonAnId",
                table: "chiTietCombos");

            migrationBuilder.AlterColumn<string>(
                name: "MonAnId",
                table: "chiTietCombos",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ComboId",
                table: "chiTietCombos",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_chiTietCombos_combos_ComboId",
                table: "chiTietCombos",
                column: "ComboId",
                principalTable: "combos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_chiTietCombos_monAns_MonAnId",
                table: "chiTietCombos",
                column: "MonAnId",
                principalTable: "monAns",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_chiTietCombos_combos_ComboId",
                table: "chiTietCombos");

            migrationBuilder.DropForeignKey(
                name: "FK_chiTietCombos_monAns_MonAnId",
                table: "chiTietCombos");

            migrationBuilder.AlterColumn<string>(
                name: "MonAnId",
                table: "chiTietCombos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ComboId",
                table: "chiTietCombos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_chiTietCombos_combos_ComboId",
                table: "chiTietCombos",
                column: "ComboId",
                principalTable: "combos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_chiTietCombos_monAns_MonAnId",
                table: "chiTietCombos",
                column: "MonAnId",
                principalTable: "monAns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
