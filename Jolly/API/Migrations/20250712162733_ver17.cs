using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2025, 7, 12, 23, 27, 31, 958, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.InsertData(
                table: "taiKhoans",
                columns: new[] { "Id", "NgayTaoTk", "NguoiDungId", "Password", "UserName" },
                values: new object[] { new Guid("9217fa12-cfce-4a07-b1f4-992c0f668921"), new DateTime(2025, 7, 12, 23, 27, 31, 958, DateTimeKind.Local).AddTicks(6866), new Guid("99999999-9999-9999-9999-999999999999"), "admin123", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "taiKhoans",
                keyColumn: "Id",
                keyValue: new Guid("9217fa12-cfce-4a07-b1f4-992c0f668921"));

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
    }
}
