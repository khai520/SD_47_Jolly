using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class HoaDon
    {
        [Key]
        public string Id { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.Now;
        [Range(1, int.MaxValue, ErrorMessage = "Tổng tiền phải lớn hơn 0")]
        public float TongTien { get; set; }
        [RegularExpression(@"^[\p{L}0-9\s]+$", ErrorMessage = "Không được chứa ký tự đặc biệt")]
        public float TongTienSauKhiGiam { get; set; }
        public List<string> TrangThai { get; set; } = new List<string>() { "Tạo đơn hàng" }; 
        [RegularExpression(@"^[\p{L}0-9\s]+$", ErrorMessage = "Không được chứa ký tự đặc biệt")]
        public List<string>? NguoiXacNhan { get; set; }
        public string? GhiChu { get; set; }
        public string? GiamGiaId { get; set; }
        public string? NhanVienId { get; set; }
        public string? KhachHangId { get; set; }
        public Guid? HinhThucThanhToanId { get; set; }
        public virtual HinhThucThanhToan HinhThucThanhToan { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual GiamGia GiamGia { get; set; }
        public virtual ICollection<HoaDonChiTiet> hoaDonChiTiets { get; set; }

    }
}
