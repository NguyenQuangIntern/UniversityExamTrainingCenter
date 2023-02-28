namespace Nhom10_NguyenMinhQuang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHoc")]
    public partial class LopHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LopHoc()
        {
            ThamGiaHocs = new HashSet<ThamGiaHoc>();
        }

        [Key]
        [StringLength(3)]
        public string MaLop { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLop { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayKhaiGiang { get; set; }

        public int SoBuoiHoc { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? TongSoGioHoc { get; set; }

        [Required]
        [StringLength(20)]
        public string ThoiGianHoc { get; set; }

        [Required]
        [StringLength(12)]
        public string MaGV { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThamGiaHoc> ThamGiaHocs { get; set; }

    }
}
