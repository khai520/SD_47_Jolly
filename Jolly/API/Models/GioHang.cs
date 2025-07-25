﻿using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class GioHang
    {
        [Key]
        public string Id { get; set; }
        public int? Soluong { get; set; }
        public int TongGia { get; set; }
        public string? ComboId { get; set; }
        public string? MonAnId { get; set; }
        public string KhachHangid { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual Combo Combo { get; set; }
        public virtual MonAn MonAn { get; set; }
    }
}
