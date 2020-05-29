namespace ChuongTrinhQuanLySinhVien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiemCuaSinhVien")]
    public partial class DiemCuaSinhVien
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaHocPhan { get; set; }

        public string TenHocPhan { get; set; }

        public int? TinChi { get; set; }

        [StringLength(50)]
        public string LoaiMonHoc { get; set; }

        public double? Diem { get; set; }

        [StringLength(50)]
        public string DiemChi { get; set; }

        public bool? KetQua { get; set; }

        public double? DiemQT { get; set; }

        public double? DiemThi { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HocKy { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string NienKhoa { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string MSSV { get; set; }
    }
}
