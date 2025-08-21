using System.Globalization;

namespace API.Models.DTO
{
    public class Voucher
    {
        public string? Id { get; set; }
        public string Ten { get; set; }
        public int? Soluong { get; set; }
        public float? SoTienKhuyenMai { get; set; }
        public int? PhanTramKhuyenMai { get; set; }
        public float? SoTienToiThieu { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int? DaSuDung { get; set; }
        public string? MoTa { get; set; }
        public bool ApDungSanPham { get; set; } = false;
        public bool Kieu { get; set; } = false;  
        public bool TrangThai { get; set; }
        public bool DotGiamGia { get; set; } = false;

    }
}
