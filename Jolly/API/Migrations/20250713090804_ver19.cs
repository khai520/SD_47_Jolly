using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "taiKhoans",
                keyColumn: "Id",
                keyValue: new Guid("ad4eb951-a875-4f64-8da0-95869d9563ec"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayVaoLam",
                table: "nhanViens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "nhanViens",
                keyColumn: "Id",
                keyValue: "NV01",
                column: "NgayVaoLam",
                value: new DateTime(2025, 7, 13, 16, 8, 2, 749, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.InsertData(
                table: "taiKhoans",
                columns: new[] { "Id", "NgayTaoTk", "NguoiDungId", "Password", "UserName" },
                values: new object[] { new Guid("ffbf5dd6-986b-454f-9187-6000e952ad25"), new DateTime(2025, 7, 13, 16, 8, 2, 749, DateTimeKind.Local).AddTicks(2297), new Guid("99999999-9999-9999-9999-999999999999"), "admin123", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "taiKhoans",
                keyColumn: "Id",
                keyValue: new Guid("ffbf5dd6-986b-454f-9187-6000e952ad25"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayVaoLam",
                table: "nhanViens",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "nhanViens",
                keyColumn: "Id",
                keyValue: "NV01",
                column: "NgayVaoLam",
                value: new DateTime(2025, 7, 12, 23, 52, 37, 235, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.InsertData(
                table: "taiKhoans",
                columns: new[] { "Id", "NgayTaoTk", "NguoiDungId", "Password", "UserName" },
                values: new object[] { new Guid("ad4eb951-a875-4f64-8da0-95869d9563ec"), new DateTime(2025, 7, 12, 23, 52, 37, 235, DateTimeKind.Local).AddTicks(2436), new Guid("99999999-9999-9999-9999-999999999999"), "admin123", "admin" });
        }
    }
}
