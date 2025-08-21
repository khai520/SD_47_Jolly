namespace API.Models
{
    public class LichSuTrangThai
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string HoaDonId { get; set; }
        public string TrangThai { get; set; }
        public DateTime ThoiGian { get; set; } = DateTime.Now;
        public string LyDo { get; set; }
    }

}
