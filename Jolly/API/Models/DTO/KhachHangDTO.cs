using System.ComponentModel.DataAnnotations;

namespace API.Models.DTO
{
    public class KhachHangDTO
    {
        public string? Id { get; set; }
        public string? Ho { get; set; }
        public string? Ten { get; set; }
        public string? HoTen => $"{Ho ?? ""} {Ten ?? ""}".Trim();
        [Phone(ErrorMessage = "Lỗi định dạng số điện thoại!")]
        public string? Sdt { get; set; }
        [EmailAddress(ErrorMessage = "Lỗi định dạng Gmail!")]
        public string? Gmail { get; set; }
        public bool TrangThai { get; set; } = true;
        public string? GhiChu { get; set; }
        public Guid NguoiDungId { get; set; }
        public virtual NguoiDung? NguoiDung { get; set; }
        public virtual ICollection<DiaChiDTO>? DiaChis { get; set; }
    }
}
