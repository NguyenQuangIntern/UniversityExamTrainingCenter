namespace Nhom10_NguyenMinhQuang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopDong")]
    public partial class HopDong
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoGiayPhepTrungTam { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string MaGV { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayCap { get; set; }

        public int ThoiHan { get; set; }

        [Column(TypeName = "date")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? NgayHetHan { get; set; }

        public int LuongTheoBuoi { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }
    }
}
