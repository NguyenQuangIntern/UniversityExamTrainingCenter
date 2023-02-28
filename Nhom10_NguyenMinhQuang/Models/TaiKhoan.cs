namespace Nhom10_NguyenMinhQuang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(10)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(50)]
        public string TenHienThi { get; set; }

        [Required]
        public string MatKhau { get; set; }
    }
}
