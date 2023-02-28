using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Nhom10_NguyenMinhQuang.Models
{
    public partial class TrungTamThayThanhContext : DbContext
    {
        public TrungTamThayThanhContext()
            : base("name=TrungTamThayThanhContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<HocSinh> HocSinhs { get; set; }
        public virtual DbSet<HopDong> HopDongs { get; set; }
        public virtual DbSet<KhuVuc> KhuVucs { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThamGiaHoc> ThamGiaHocs { get; set; }
        public virtual DbSet<TruongHoc> TruongHocs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.SoCMND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.SoDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .HasMany(e => e.HopDongs)
                .WithRequired(e => e.GiaoVien)
                .HasForeignKey(e => e.MaGV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GiaoVien>()
                .HasMany(e => e.LopHocs)
                .WithRequired(e => e.GiaoVien)
                .HasForeignKey(e => e.MaGV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HocSinh>()
                .Property(e => e.SoCMND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HocSinh>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HocSinh>()
                .Property(e => e.MaTruong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HocSinh>()
                .HasMany(e => e.ThamGiaHocs)
                .WithRequired(e => e.HocSinh)
                .HasForeignKey(e => e.MaHS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HopDong>()
                .Property(e => e.MaGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhuVuc>()
                .Property(e => e.MaKhuVuc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhuVuc>()
                .HasMany(e => e.TruongHocs)
                .WithRequired(e => e.KhuVuc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LopHoc>()
                .Property(e => e.MaLop)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LopHoc>()
                .Property(e => e.MaGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LopHoc>()
                .HasMany(e => e.ThamGiaHocs)
                .WithRequired(e => e.LopHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.GiaoViens)
                .WithRequired(e => e.MonHoc1)
                .HasForeignKey(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<ThamGiaHoc>()
                .Property(e => e.MaLop)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThamGiaHoc>()
                .Property(e => e.MaHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TruongHoc>()
                .Property(e => e.MaTruong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TruongHoc>()
                .Property(e => e.MaKhuVuc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TruongHoc>()
                .HasMany(e => e.HocSinhs)
                .WithRequired(e => e.TruongHoc)
                .WillCascadeOnDelete(false);
        }
    }
}
