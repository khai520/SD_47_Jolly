using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class NguoiDung
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Ho { get; set; }
        [Required]
        [RegularExpression(@"^[\p{L}0-9\s]+$", ErrorMessage = "Không được chứa ký tự đặc biệt")]
        public string Ten { get; set; }
        [MinimumAge(13, ErrorMessage = "Bạn phải đủ 13 tuổi.")]
        public DateTime NgaySinh { get; set; }
        public string? GioiTinh { get; set; }
        [EmailAddress]
        public string? Gmail { get; set; }
        [Phone]
        public string? Sdt { get; set; }
        public virtual ICollection<DiaChi>? DiaChis { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
    }
    public class MinimumAgeAttribute(int minimumAge) : ValidationAttribute
    {
        public int MinAge { get; } = minimumAge;


        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {

            if (value is DateTime ngaySinh)
            {
                var today = DateTime.Today;
                var age = today.Year - ngaySinh.Year;

                if (ngaySinh > today.AddYears(-age)) age--;

                if (age >= MinAge)
                    return ValidationResult.Success;
                else
                    return new ValidationResult(ErrorMessage ?? $"Phải đủ {MinAge} tuổi.");
            }

            return new ValidationResult("Ngày sinh không hợp lệ.");
        }
    }
}
