using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Extensions.Diagnostics.HealthChecks;
namespace API.Models.DTO
{
    public class ChiTietMonAnDTO
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string TheLoai { get; set; }
        public string DongGoi { get; set; }
        public string ThuongHieu { get; set; }
        public string NhaCungCap { get; set; }
        public string MonAnId { get; set; }
        public int? Soluong { get; set; }
        public string? Mota { get; set; }
        public Guid? TheLoaiId { get; set; }
        public Guid? DongGoiId { get; set; }
        public Guid? ThuongHieuId { get; set; }
        public Guid? NhaCungCapId { get; set; }

    }
}
