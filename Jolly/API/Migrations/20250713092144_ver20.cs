using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_nhanViens_chucVus_ChucVuId",
                table: "nhanViens");

            migrationBuilder.DeleteData(
                table: "taiKhoans",
                keyColumn: "Id",
                keyValue: new Guid("ffbf5dd6-986b-454f-9187-6000e952ad25"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChucVuId",
                table: "nhanViens",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.AddForeignKey(
                name: "FK_nhanViens_chucVus_ChucVuId",
                table: "nhanViens",
                column: "ChucVuId",
                principalTable: "chucVus",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_nhanViens_chucVus_ChucVuId",
                table: "nhanViens");

            migrationBuilder.DeleteData(
                table: "taiKhoans",
                keyColumn: "Id",
                keyValue: new Guid("d1e3fcb8-1c16-4702-8191-574d1af884b8"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChucVuId",
                table: "nhanViens",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
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

            migrationBuilder.AddForeignKey(
                name: "FK_nhanViens_chucVus_ChucVuId",
                table: "nhanViens",
                column: "ChucVuId",
                principalTable: "chucVus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
