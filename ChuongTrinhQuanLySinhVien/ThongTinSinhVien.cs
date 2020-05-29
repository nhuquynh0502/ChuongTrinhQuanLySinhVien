namespace ChuongTrinhQuanLySinhVien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinSinhVien")]
    public partial class ThongTinSinhVien
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Mssv { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string HoVaTen { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Key]
        [Column(Order = 4)]
        public string NoiSinh { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string GioiTinh { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string DanToc { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoCMND { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string TonGiao { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string DoiTuong { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(10)]
        public string KhuVuc { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string DienUuTien { get; set; }

        [Key]
        [Column("Doan/Dang", Order = 12)]
        [StringLength(10)]
        public string Doan_Dang { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "date")]
        public DateTime NgayVao { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string TinhTrangHoc { get; set; }

        [Key]
        [Column("Tinh/ThanhPho", Order = 15)]
        [StringLength(50)]
        public string Tinh_ThanhPho { get; set; }

        [Key]
        [Column("Quan/Huyen", Order = 16)]
        public string Quan_Huyen { get; set; }

        [Key]
        [Column(Order = 17)]
        public string DiaChiThuongTru { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(50)]
        public string QuocGia { get; set; }
    }
}
