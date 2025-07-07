namespace API.Models.DTO
{
    public class NhanVienDTO
    {
        public string? Id { get; set; }
        public bool TrangThai { get; set; }
        public DateTime? NgayVaoLam { get; set; }
        public Guid ChucVuId { get; set; }
        public Guid NguoiDungId { get; set; }
    }
}
