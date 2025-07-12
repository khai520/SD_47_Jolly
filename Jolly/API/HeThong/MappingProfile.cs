using AutoMapper;
using API.Models;
using API.Models.DTO;

namespace API.HeThong
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Anh, AnhDTO>().ReverseMap();
            CreateMap<Combo, ComboDTO>().ReverseMap();
            CreateMap<ChiTietCombo, ChiTietComboDTO>().ReverseMap();
            CreateMap<ChiTietGiamGia, ChiTietGiamGiaDTO>().ReverseMap();
            CreateMap<ChiTietMonAn, ChiTietMonAnDTO>()
                .ForMember(t => t.Ten, opt => opt.MapFrom(src =>
                    src.MonAn != null && !string.IsNullOrWhiteSpace(src.MonAn.Ten)
                    ? src.MonAn.Ten : ""))
                .ForMember(tl => tl.TheLoai, opt => opt.MapFrom(src =>
                    src.TheLoai != null && !string.IsNullOrWhiteSpace(src.TheLoai.Ten)
                    ? src.TheLoai.Ten : ""))
                .ForMember(dg => dg.DongGoi, opt => opt.MapFrom(src =>
                    src.DongGoi != null && !string.IsNullOrWhiteSpace(src.DongGoi.Ten)
                    ? src.DongGoi.Ten : ""))
                .ForMember(th => th.ThuongHieu, opt => opt.MapFrom(src =>
                    src.ThuongHieu != null && !string.IsNullOrWhiteSpace(src.ThuongHieu.Ten)
                    ? src.ThuongHieu.Ten : ""))
                .ForMember(ncc => ncc.NhaCungCap, opt => opt.MapFrom(src =>
                    src.NhaCungCap != null && !string.IsNullOrWhiteSpace(src.NhaCungCap.Ten)
                    ? src.NhaCungCap.Ten : ""))
                .ReverseMap();
            CreateMap<ChiTietMonAnDTO, ChiTietMonAn>()
                .ForMember(dest => dest.MonAn, opt => opt.Ignore());


            CreateMap<ChucVu, ChucVuDTO>().ReverseMap();
            CreateMap<DiaChi, DiaChiDTO>().ReverseMap();
            CreateMap<DongGoi, DongGoiDTO>().ReverseMap();
            CreateMap<GiamGia, GiamGiaDTO>().ReverseMap();
            CreateMap<GioHang, GioHangDTO>().ReverseMap();
            CreateMap<HinhThucThanhToan, HinhThucThanhToanDTO>().ReverseMap();
            CreateMap<HoaDonChiTiet, HoaDonChiTietDTO>().ReverseMap();
            CreateMap<HoaDon, HoaDonDTO>().ReverseMap();
            CreateMap<KhachHang, KhachHangDTO>().ReverseMap();
            CreateMap<Loai, LoaiDTO>().ReverseMap();
            CreateMap<MonAn, MonAnDTO>().ReverseMap();
            CreateMap<NguoiDung, NguoiDungDTO>().ReverseMap();
            CreateMap<NhaCungCap, NhaCungCapDTO>().ReverseMap();
            CreateMap<NhanVien, NhanVienDTO>().ReverseMap();
            CreateMap<TaiKhoan, TaiKhoanDTO>()
            .ForMember(dest => dest.Quyen, opt => opt.MapFrom(src =>
                src.NguoiDung != null &&
                src.NguoiDung.NhanVien != null &&
                src.NguoiDung.NhanVien.ChucVu != null &&
                !string.IsNullOrWhiteSpace(src.NguoiDung.NhanVien.ChucVu.Ten)
                    ? src.NguoiDung.NhanVien.ChucVu.Ten
                    : "User"

            )).ForMember(tt => tt.TrangThai, opt => opt.MapFrom(src =>
                src.NguoiDung != null &&
                src.NguoiDung.NhanVien != null &&
                src.NguoiDung.NhanVien.ChucVu != null &&
                !string.IsNullOrWhiteSpace(src.NguoiDung.NhanVien.ChucVu.Ten)
                    ? src.NguoiDung.NhanVien.ChucVu.TrangThai : false
            ));

            CreateMap<TaiKhoanDTO, TaiKhoan>();
            CreateMap<TheLoai, TheLoaiDTO>().ReverseMap();
            CreateMap<ThuongHieu, ThuongHieuDTO>().ReverseMap();
        }
    }
}
