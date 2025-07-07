namespace API.Models.DTO
{
    public class TaiKhoanDTO
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NguoiDungId { get; set; }
        public string? Quyen { get; set; }
        public bool TrangThai { get; set; } 
    }
}
