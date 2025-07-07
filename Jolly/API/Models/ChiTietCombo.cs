﻿using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class ChiTietCombo
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0")]
        public int SoLuong { get; set; }
        public string? ComboId { get; set; }
        public string? MonAnId { get; set; }
        public virtual Combo Combo { get; set; }
        public virtual MonAn MonAn { get; set; }
    }
}
