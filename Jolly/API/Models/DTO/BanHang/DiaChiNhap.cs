namespace API.Models.DTO.BanHang
{
    public class DiaChiNhap
    {
        public string Ten { get; set; }
        public List<DiaChiNhap> Con { get; set; } = new();
    }
}
