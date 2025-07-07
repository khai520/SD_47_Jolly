

namespace API.Models.DTO
{
    public class HoaDonChiTietDTO
    {
        public Guid Id { get; set; } 
        public int Soluong { get; set; }
        public bool TrangThai { get; set; } 
        public float ThanhTien { get; set; }
        public string HoaDonId { get; set; }
        public string? MonAnId { get; set; }
        public string? ComboId { get; set; }
    }
}
