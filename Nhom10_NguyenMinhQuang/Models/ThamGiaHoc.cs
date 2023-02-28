namespace Nhom10_NguyenMinhQuang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThamGiaHoc")]
    public partial class ThamGiaHoc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string MaLop { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string MaHS { get; set; }

        public int? SoBuoiHoc { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? TongHocPhi { get; set; }

        public virtual HocSinh HocSinh { get; set; }

        public virtual LopHoc LopHoc { get; set; }
    }
}
