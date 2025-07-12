using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2025, 7, 12, 23, 52, 37, 235, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.InsertData(
                table: "taiKhoans",
                columns: new[] { "Id", "NgayTaoTk", "NguoiDungId", "Password", "UserName" },
                values: new object[] { new Guid("ad4eb951-a875-4f64-8da0-95869d9563ec"), new DateTime(2025, 7, 12, 23, 52, 37, 235, DateTimeKind.Local).AddTicks(2436), new Guid("99999999-9999-9999-9999-999999999999"), "admin123", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "taiKhoans",
                keyColumn: "Id",
                keyValue: new Guid("ad4eb951-a875-4f64-8da0-95869d9563ec"));

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
    }
}
