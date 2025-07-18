﻿using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class HoaDonChiTiet
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0")]
        public int Soluong { get; set; }
        public bool TrangThai { get; set; } = false;
        [Range(1, float.MaxValue, ErrorMessage = "Số tiền phải lớn hơn 0")]
        public float ThanhTien { get; set; }
        public string HoaDonId { get; set; }
        public string? MonAnId { get; set; }
        public string? ComboId { get; set; }
        public virtual Combo Combo { get; set; }
        public virtual MonAn MonAn { get; set; }    
        public virtual HoaDon HoaDon { get; set; }
    }
}
