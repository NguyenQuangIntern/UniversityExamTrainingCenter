namespace Nhom10_NguyenMinhQuang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocSinh")]
    public partial class HocSinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocSinh()
        {
            ThamGiaHocs = new HashSet<ThamGiaHoc>();
        }

        [Key]
        [StringLength(12)]
        public string SoCMND { get; set; }

        [Required]
        [StringLength(30)]
        public string TenHS { get; set; }

        [Required]
        [StringLength(10)]
        public string SDT { get; set; }

        public bool GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(3)]
        public string MaTruong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThamGiaHoc> ThamGiaHocs { get; set; }

        public virtual TruongHoc TruongHoc { get; set; }

    }
}
