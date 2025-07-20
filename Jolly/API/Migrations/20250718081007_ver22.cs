using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "chucVus",
                columns: new[] { "Id", "Mota", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Quản trị hệ thống", "Admin", true },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Nhân viên bán hàng", "NhanVien", true }
                });

            migrationBuilder.InsertData(
                table: "nguoiDungs",
                columns: new[] { "Id", "GioiTinh", "Gmail", "Ho", "NgaySinh", "Sdt", "Ten" },
                values: new object[] { new Guid("99999999-9999-9999-9999-999999999999"), "Nam", "admin@shop.com", "Nguyễn Văn", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0987654321", " Quản Trị" });

            migrationBuilder.InsertData(
                table: "nhanViens",
                columns: new[] { "Id", "ChucVuId", "NgayVaoLam", "NguoiDungId", "TrangThai" },
                values: new object[] { "NV001", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 7, 18, 15, 10, 6, 847, DateTimeKind.Local).AddTicks(6910), new Guid("99999999-9999-9999-9999-999999999999"), true });

            migrationBuilder.InsertData(
                table: "taiKhoans",
                columns: new[] { "Id", "NgayTaoTk", "NguoiDungId", "Password", "UserName" },
                values: new object[] { new Guid("81a05b3b-ef77-4941-9b3d-2ff26b628726"), new DateTime(2025, 7, 18, 15, 10, 6, 847, DateTimeKind.Local).AddTicks(6862), new Guid("99999999-9999-9999-9999-999999999999"), "admin123", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "chucVus",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "nhanViens",
                keyColumn: "Id",
                keyValue: "NV001");

            migrationBuilder.DeleteData(
                table: "taiKhoans",
                keyColumn: "Id",
                keyValue: new Guid("81a05b3b-ef77-4941-9b3d-2ff26b628726"));

            migrationBuilder.DeleteData(
                table: "chucVus",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "nguoiDungs",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"));
        }
    }
}
