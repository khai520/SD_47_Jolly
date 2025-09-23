using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Bỏ FK cũ giữa trangThais và hoaDons
            migrationBuilder.DropForeignKey(
                name: "FK_trangThais_hoaDons_HoaDonId",
                table: "trangThais");

            // Xóa index (nếu có) của HoaDonId
            migrationBuilder.DropIndex(
                name: "IX_trangThais_HoaDonId",
                table: "trangThais");

            // Xóa cột HoaDonId
            migrationBuilder.DropColumn(
                name: "HoaDonId",
                table: "trangThais");

            // Thêm cột HoaDonChiTietId (nullable để tránh lỗi dữ liệu cũ)
            migrationBuilder.AddColumn<Guid>(
                name: "HoaDonChiTietId",
                table: "trangThais",
                type: "uniqueidentifier",
                nullable: true);

            // Tạo index cho HoaDonChiTietId
            migrationBuilder.CreateIndex(
                name: "IX_trangThais_HoaDonChiTietId",
                table: "trangThais",
                column: "HoaDonChiTietId");

            // Thêm FK mới liên kết tới hoaDonChiTiets
            migrationBuilder.AddForeignKey(
                name: "FK_trangThais_hoaDonChiTiets_HoaDonChiTietId",
                table: "trangThais",
                column: "HoaDonChiTietId",
                principalTable: "hoaDonChiTiets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Bỏ FK mới
            migrationBuilder.DropForeignKey(
                name: "FK_trangThais_hoaDonChiTiets_HoaDonChiTietId",
                table: "trangThais");

            // Bỏ index HoaDonChiTietId
            migrationBuilder.DropIndex(
                name: "IX_trangThais_HoaDonChiTietId",
                table: "trangThais");

            // Xóa cột HoaDonChiTietId
            migrationBuilder.DropColumn(
                name: "HoaDonChiTietId",
                table: "trangThais");

            // Thêm lại cột HoaDonId
            migrationBuilder.AddColumn<string>(
                name: "HoaDonId",
                table: "trangThais",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            // Tạo lại index cho HoaDonId
            migrationBuilder.CreateIndex(
                name: "IX_trangThais_HoaDonId",
                table: "trangThais",
                column: "HoaDonId");

            // Thêm lại FK cũ với hoaDons
            migrationBuilder.AddForeignKey(
                name: "FK_trangThais_hoaDons_HoaDonId",
                table: "trangThais",
                column: "HoaDonId",
                principalTable: "hoaDons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
