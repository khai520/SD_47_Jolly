namespace API.Models.DTO
{
    public class ChiTietMonAnDTO
    {
        public Guid Id { get; set; }
        public string MonAnId { get; set; }
        public int? Soluong { get; set; }
        public string? Mota { get; set; }
        public Guid? TheLoaiId { get; set; }
        public Guid? DongGoiId { get; set; }
        public Guid? ThuongHieuId { get; set; }
        public Guid? NhaCungCapId { get; set; }

    }
}
