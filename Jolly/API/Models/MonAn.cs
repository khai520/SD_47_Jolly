using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class MonAn
    {
        [Key]
        [RegularExpression(@"^[\p{L}0-9\s]+$", ErrorMessage = "Không được chứa ký tự đặc biệt")]
        public string Id { get; set; }
        [Required]
        [RegularExpression(@"^[\p{L}0-9\s]+$", ErrorMessage = "Không được chứa ký tự đặc biệt")]
        public string Ten { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Giá phải lớn hơn 0")]
        public DateTime? HanSuDung { get; set; }
        public bool TrangThai { get; set; } = false;
        [RegularExpression(@"^[\p{L}0-9\s]+$", ErrorMessage = "Không được chứa ký tự đặc biệt")]
        public string? Mota { get; set; }
        public virtual ICollection<ChiTietCombo> ChiTietCombos { get; set; }
        public virtual ICollection<GioHang> GioHangs { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual ICollection<ChiTietGiamGia> ChiTietGiamGias { get; set; }
        public virtual ICollection<ChiTietMonAn> ChiTietMonAns { get; set; }
    }
}
