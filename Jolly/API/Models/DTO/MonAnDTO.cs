namespace API.Models.DTO
{
    public class MonAnDTO
    {
        public string? Id { get; set; }
        public required string Ten { get; set; }
        public TimeOnly? HanSuDung { get; set; }
        public bool TrangThai { get; set; } 
        public string? Mota { get; set; }
        public string? AnhDaTai { get; set; }
    }
}
