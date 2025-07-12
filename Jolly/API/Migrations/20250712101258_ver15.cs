using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "taiKhoans",
                keyColumn: "Id",
                keyValue: new Guid("21dd99bc-88c1-4f2d-8c3b-a87672c4f3c4"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2025, 7, 11, 17, 32, 49, 286, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.InsertData(
                table: "taiKhoans",
                columns: new[] { "Id", "NgayTaoTk", "NguoiDungId", "Password", "UserName" },
                values: new object[] { new Guid("21dd99bc-88c1-4f2d-8c3b-a87672c4f3c4"), new DateTime(2025, 7, 11, 17, 32, 49, 286, DateTimeKind.Local).AddTicks(845), new Guid("99999999-9999-9999-9999-999999999999"), "admin123", "admin" });
        }
    }
}
