namespace ChuongTrinhQuanLySinhVien
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLSVDB : DbContext
    {
        public QLSVDB()
            : base("name=QLSVDB1")
        {
        }

        public virtual DbSet<DiemCuaSinhVien> DiemCuaSinhViens { get; set; }
        public virtual DbSet<ThongTinSinhVien> ThongTinSinhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiemCuaSinhVien>()
                .Property(e => e.MaHocPhan)
                .IsUnicode(false);

            modelBuilder.Entity<DiemCuaSinhVien>()
                .Property(e => e.DiemChi)
                .IsUnicode(false);

            modelBuilder.Entity<DiemCuaSinhVien>()
                .Property(e => e.NienKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<DiemCuaSinhVien>()
                .Property(e => e.MSSV)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinSinhVien>()
                .Property(e => e.Mssv)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinSinhVien>()
                .Property(e => e.GioiTinh)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinSinhVien>()
                .Property(e => e.KhuVuc)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinSinhVien>()
                .Property(e => e.Doan_Dang)
                .IsFixedLength();
        }
    }
}
