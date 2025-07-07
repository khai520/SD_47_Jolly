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
            CreateMap<ChiTietMonAn, ChiTietMonAnDTO>().ReverseMap();
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
