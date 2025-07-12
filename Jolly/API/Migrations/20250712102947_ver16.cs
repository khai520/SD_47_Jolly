using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "taiKhoans",
                keyColumn: "Id",
                keyValue: new Guid("b8b522aa-56f0-47af-be84-3220796343d7"));

            migrationBuilder.UpdateData(
                table: "nhanViens",
                keyColumn: "Id",
                keyValue: "NV01",
                column: "NgayVaoLam",
                value: new DateTime(2025, 7, 12, 17, 29, 47, 107, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.InsertData(
                table: "taiKhoans",
                columns: new[] { "Id", "NgayTaoTk", "NguoiDungId", "Password", "UserName" },
                values: new object[] { new Guid("80bb2011-7aea-4563-8a8c-daa9f1f3d983"), new DateTime(2025, 7, 12, 17, 29, 47, 107, DateTimeKind.Local).AddTicks(9878), new Guid("99999999-9999-9999-9999-999999999999"), "admin123", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "taiKhoans",
                keyColumn: "Id",
                keyValue: new Guid("80bb2011-7aea-4563-8a8c-daa9f1f3d983"));

            migrationBuilder.UpdateData(
                table: "nhanViens",
                keyColumn: "Id",
                keyValue: "NV01",
                column: "NgayVaoLam",
                value: new DateTime(2025, 7, 12, 17, 12, 57, 386, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.InsertData(
                table: "taiKhoans",
                columns: new[] { "Id", "NgayTaoTk", "NguoiDungId", "Password", "UserName" },
                values: new object[] { new Guid("b8b522aa-56f0-47af-be84-3220796343d7"), new DateTime(2025, 7, 12, 17, 12, 57, 386, DateTimeKind.Local).AddTicks(1834), new Guid("99999999-9999-9999-9999-999999999999"), "admin123", "admin" });
        }
    }
}
