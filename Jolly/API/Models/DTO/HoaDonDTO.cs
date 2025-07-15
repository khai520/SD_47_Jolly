namespace API.Models.DTO
{
    public class HoaDonDTO
    {
        public string? Id { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.Now;
        public float TongTien { get; set; }
        public List<string>? TrangThai { get; set; }
        public float TongTienSauKhiGiam { get; set; }
        public string? GhiChu { get; set; }
        public string? GiamGiaId { get; set; }
        public string? NhanVienId { get; set; }
        public string? KhachHangId { get; set; }
        public Guid? HinhThucThanhToanId { get; set; }
    }
}
