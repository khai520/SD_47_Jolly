﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chucVus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chucVus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dongGois",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dongGois", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "giamGias",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: true),
                    SoTienKhuyenMai = table.Column<float>(type: "real", nullable: true),
                    PhanTranKhuyenMai = table.Column<int>(type: "int", nullable: true),
                    SoTienToiThieu = table.Column<float>(type: "real", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApDungSanPham = table.Column<bool>(type: "bit", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_giamGias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "hinhThucThanhToans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hinhThucThanhToans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "loais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "monAns",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<float>(type: "real", nullable: true),
                    HanSuDung = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_monAns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nguoiDungs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nguoiDungs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nhaCungCaps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhaCungCaps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "theLoais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theLoais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "thuongHieus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_thuongHieus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "combos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<float>(type: "real", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_combos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_combos_loais_LoaiId",
                        column: x => x.LoaiId,
                        principalTable: "loais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chiTietGiamGias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonAnId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GiamGiaId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietGiamGias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chiTietGiamGias_giamGias_GiamGiaId",
                        column: x => x.GiamGiaId,
                        principalTable: "giamGias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_chiTietGiamGias_monAns_MonAnId",
                        column: x => x.MonAnId,
                        principalTable: "monAns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "khachHangs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiDungId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_khachHangs_nguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "nguoiDungs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nhanViens",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    NgayVaoLam = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChucVuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NguoiDungId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_nhanViens_chucVus_ChucVuId",
                        column: x => x.ChucVuId,
                        principalTable: "chucVus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_nhanViens_nguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "nguoiDungs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "taiKhoans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTaoTk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiDungId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taiKhoans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_taiKhoans_nguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "nguoiDungs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "diaChis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiaChiCuThe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuanHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuocGia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    NguoiDungId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NhaCungCapId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diaChis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_diaChis_nguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "nguoiDungs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_diaChis_nhaCungCaps_NhaCungCapId",
                        column: x => x.NhaCungCapId,
                        principalTable: "nhaCungCaps",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "chiTietMonAns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TheLoaiId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DongGoiId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ThuongHieuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NhaCungCapId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MonAnId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietMonAns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chiTietMonAns_dongGois_DongGoiId",
                        column: x => x.DongGoiId,
                        principalTable: "dongGois",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_chiTietMonAns_monAns_MonAnId",
                        column: x => x.MonAnId,
                        principalTable: "monAns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_chiTietMonAns_nhaCungCaps_NhaCungCapId",
                        column: x => x.NhaCungCapId,
                        principalTable: "nhaCungCaps",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_chiTietMonAns_theLoais_TheLoaiId",
                        column: x => x.TheLoaiId,
                        principalTable: "theLoais",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_chiTietMonAns_thuongHieus_ThuongHieuId",
                        column: x => x.ThuongHieuId,
                        principalTable: "thuongHieus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "chiTietCombos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    ComboId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MonAnId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietCombos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chiTietCombos_combos_ComboId",
                        column: x => x.ComboId,
                        principalTable: "combos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_chiTietCombos_monAns_MonAnId",
                        column: x => x.MonAnId,
                        principalTable: "monAns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gioHangs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: true),
                    TongGia = table.Column<int>(type: "int", nullable: false),
                    ComboId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MonAnId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    KhachHangid = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gioHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gioHangs_combos_ComboId",
                        column: x => x.ComboId,
                        principalTable: "combos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_gioHangs_khachHangs_KhachHangid",
                        column: x => x.KhachHangid,
                        principalTable: "khachHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gioHangs_monAns_MonAnId",
                        column: x => x.MonAnId,
                        principalTable: "monAns",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiamGiaId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NhanVienId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    KhachHangId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HinhThucThanhToanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MonAnId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hoaDons_giamGias_GiamGiaId",
                        column: x => x.GiamGiaId,
                        principalTable: "giamGias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_hoaDons_hinhThucThanhToans_HinhThucThanhToanId",
                        column: x => x.HinhThucThanhToanId,
                        principalTable: "hinhThucThanhToans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_hoaDons_khachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "khachHangs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_hoaDons_monAns_MonAnId",
                        column: x => x.MonAnId,
                        principalTable: "monAns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_hoaDons_nhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "nhanViens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "anhs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DuongDan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    NguoiDungId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChiTietMonAnId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anhs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_anhs_chiTietMonAns_ChiTietMonAnId",
                        column: x => x.ChiTietMonAnId,
                        principalTable: "chiTietMonAns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_anhs_nguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "nguoiDungs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "hoaDonChiTiets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    ThanhTien = table.Column<float>(type: "real", nullable: false),
                    HoaDonId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MonAnId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ComboId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonChiTiets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_combos_ComboId",
                        column: x => x.ComboId,
                        principalTable: "combos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_hoaDons_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "hoaDons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_monAns_MonAnId",
                        column: x => x.MonAnId,
                        principalTable: "monAns",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_anhs_ChiTietMonAnId",
                table: "anhs",
                column: "ChiTietMonAnId");

            migrationBuilder.CreateIndex(
                name: "IX_anhs_NguoiDungId",
                table: "anhs",
                column: "NguoiDungId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietCombos_ComboId",
                table: "chiTietCombos",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietCombos_MonAnId",
                table: "chiTietCombos",
                column: "MonAnId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietGiamGias_GiamGiaId",
                table: "chiTietGiamGias",
                column: "GiamGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietGiamGias_MonAnId",
                table: "chiTietGiamGias",
                column: "MonAnId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietMonAns_DongGoiId",
                table: "chiTietMonAns",
                column: "DongGoiId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietMonAns_MonAnId",
                table: "chiTietMonAns",
                column: "MonAnId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietMonAns_NhaCungCapId",
                table: "chiTietMonAns",
                column: "NhaCungCapId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietMonAns_TheLoaiId",
                table: "chiTietMonAns",
                column: "TheLoaiId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietMonAns_ThuongHieuId",
                table: "chiTietMonAns",
                column: "ThuongHieuId");

            migrationBuilder.CreateIndex(
                name: "IX_combos_LoaiId",
                table: "combos",
                column: "LoaiId");

            migrationBuilder.CreateIndex(
                name: "IX_diaChis_NguoiDungId",
                table: "diaChis",
                column: "NguoiDungId");

            migrationBuilder.CreateIndex(
                name: "IX_diaChis_NhaCungCapId",
                table: "diaChis",
                column: "NhaCungCapId");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangs_ComboId",
                table: "gioHangs",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangs_KhachHangid",
                table: "gioHangs",
                column: "KhachHangid");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangs_MonAnId",
                table: "gioHangs",
                column: "MonAnId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_ComboId",
                table: "hoaDonChiTiets",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_HoaDonId",
                table: "hoaDonChiTiets",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_MonAnId",
                table: "hoaDonChiTiets",
                column: "MonAnId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_GiamGiaId",
                table: "hoaDons",
                column: "GiamGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_HinhThucThanhToanId",
                table: "hoaDons",
                column: "HinhThucThanhToanId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_KhachHangId",
                table: "hoaDons",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_MonAnId",
                table: "hoaDons",
                column: "MonAnId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_NhanVienId",
                table: "hoaDons",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_khachHangs_NguoiDungId",
                table: "khachHangs",
                column: "NguoiDungId");

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_ChucVuId",
                table: "nhanViens",
                column: "ChucVuId");

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_NguoiDungId",
                table: "nhanViens",
                column: "NguoiDungId");

            migrationBuilder.CreateIndex(
                name: "IX_taiKhoans_NguoiDungId",
                table: "taiKhoans",
                column: "NguoiDungId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "anhs");

            migrationBuilder.DropTable(
                name: "chiTietCombos");

            migrationBuilder.DropTable(
                name: "chiTietGiamGias");

            migrationBuilder.DropTable(
                name: "diaChis");

            migrationBuilder.DropTable(
                name: "gioHangs");

            migrationBuilder.DropTable(
                name: "hoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "taiKhoans");

            migrationBuilder.DropTable(
                name: "chiTietMonAns");

            migrationBuilder.DropTable(
                name: "combos");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "dongGois");

            migrationBuilder.DropTable(
                name: "nhaCungCaps");

            migrationBuilder.DropTable(
                name: "theLoais");

            migrationBuilder.DropTable(
                name: "thuongHieus");

            migrationBuilder.DropTable(
                name: "loais");

            migrationBuilder.DropTable(
                name: "giamGias");

            migrationBuilder.DropTable(
                name: "hinhThucThanhToans");

            migrationBuilder.DropTable(
                name: "khachHangs");

            migrationBuilder.DropTable(
                name: "monAns");

            migrationBuilder.DropTable(
                name: "nhanViens");

            migrationBuilder.DropTable(
                name: "chucVus");

            migrationBuilder.DropTable(
                name: "nguoiDungs");
        }
    }
}
