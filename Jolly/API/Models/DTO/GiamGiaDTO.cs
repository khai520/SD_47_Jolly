namespace API.Models.DTO
{
    public class GiamGiaDTO
    {
        public string? Id { get; set; }
        public string Ten { get; set; }
        public int? Soluong { get; set; }
        public float? SoTienKhuyenMai { get; set; }
        public int? PhanTranKhuyenMai { get; set; }
        public float? SoTienToiThieu { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public bool ApDungSanPham { get; set; }
        public bool TrangThai { get; set; }
    }
}
