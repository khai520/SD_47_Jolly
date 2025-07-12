using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class ChiTietMonAn
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Soluong { get; set; }
        [RegularExpression(@"^[\p{L}0-9\s]+$", ErrorMessage = "Không được chứa ký tự đặc biệt")]
        public string? Mota { get; set; }
        public Guid? TheLoaiId { get; set; }
        public Guid? DongGoiId { get; set; }
        public Guid? ThuongHieuId { get; set; }
        public Guid? NhaCungCapId { get; set; }
        public float Gia { get; set; }
        public bool TrangThai { get; set; } = false;
        public string MonAnId { get; set; }
        public virtual MonAn? MonAn { get; set; }
        public virtual NhaCungCap? NhaCungCap { get; set; }
        public virtual ThuongHieu? ThuongHieu { get; set; }
        public virtual DongGoi? DongGoi { get; set; }
        public virtual TheLoai? TheLoai { get; set; }
        public virtual ICollection<Anh> Anhs { get; set; } = new List<Anh>();
        
    }
}
