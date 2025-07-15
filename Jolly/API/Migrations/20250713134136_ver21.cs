using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "taiKhoans",
                keyColumn: "Id",
                keyValue: new Guid("d1e3fcb8-1c16-4702-8191-574d1af884b8"));

            migrationBuilder.RenameColumn(
                name: "PhanTranKhuyenMai",
                table: "giamGias",
                newName: "PhanTramKhuyenMai");

            migrationBuilder.AddColumn<string>(
                name: "NguoiXacNhan",
                table: "hoaDons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MoTa",
                table: "giamGias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "nhanViens",
                keyColumn: "Id",
                keyValue: "NV01",
                column: "NgayVaoLam",
                value: new DateTime(2025, 7, 13, 20, 41, 34, 78, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.InsertData(
                table: "taiKhoans",
                columns: new[] { "Id", "NgayTaoTk", "NguoiDungId", "Password", "UserName" },
                values: new object[] { new Guid("da50c84f-8c1e-45ad-81fe-8f360a3b0647"), new DateTime(2025, 7, 13, 20, 41, 34, 78, DateTimeKind.Local).AddTicks(735), new Guid("99999999-9999-9999-9999-999999999999"), "admin123", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "taiKhoans",
                keyColumn: "Id",
                keyValue: new Guid("da50c84f-8c1e-45ad-81fe-8f360a3b0647"));

            migrationBuilder.DropColumn(
                name: "NguoiXacNhan",
                table: "hoaDons");

            migrationBuilder.DropColumn(
                name: "MoTa",
                table: "giamGias");

            migrationBuilder.RenameColumn(
                name: "PhanTramKhuyenMai",
                table: "giamGias",
                newName: "PhanTranKhuyenMai");

            migrationBuilder.UpdateData(
                table: "nhanViens",
                keyColumn: "Id",
                keyValue: "NV01",
                column: "NgayVaoLam",
                value: new DateTime(2025, 7, 13, 16, 21, 42, 794, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.InsertData(
                table: "taiKhoans",
                columns: new[] { "Id", "NgayTaoTk", "NguoiDungId", "Password", "UserName" },
                values: new object[] { new Guid("d1e3fcb8-1c16-4702-8191-574d1af884b8"), new DateTime(2025, 7, 13, 16, 21, 42, 794, DateTimeKind.Local).AddTicks(693), new Guid("99999999-9999-9999-9999-999999999999"), "admin123", "admin" });
        }
    }
}
