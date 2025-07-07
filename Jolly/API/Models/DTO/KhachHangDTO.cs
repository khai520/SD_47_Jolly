namespace API.Models.DTO
{
    public class KhachHangDTO
    {
        public string? Id { get; set; }
        public bool TrangThai { get; set; } 
        public string? GhiChu { get; set; }
        public Guid NguoiDungId { get; set; }
    }
}
