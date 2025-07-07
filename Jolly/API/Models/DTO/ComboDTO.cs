namespace API.Models.DTO
{
    public class ComboDTO
    {
        public string? Id { get; set; }
        public string Ten { get; set; }
        public float Gia { get; set; }
        public string? Mota { get; set; }
        public Guid? LoaiId { get; set; }
    }
}
