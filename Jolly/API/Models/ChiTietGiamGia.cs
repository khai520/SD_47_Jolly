using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class ChiTietGiamGia
    {
        [Key] 
        public Guid Id { get; set; } = Guid.NewGuid();
        public string MonAnId { get; set; }
        public string GiamGiaId { get; set; }
        public virtual MonAn MonAn { get; set; }
        public virtual GiamGia GiamGia { get; set; }
    }
}
