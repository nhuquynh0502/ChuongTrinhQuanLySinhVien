using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLySinhVien
{
    public partial class DiemCuaSV : Form
    {
        QLSVDB db = new QLSVDB();
        private string mssv;

        public DiemCuaSV()
        {
            InitializeComponent();
            BangDiemCuaSV bd = new BangDiemCuaSV(db.DiemCuaSinhViens.ToList());
            flowLayoutPanelDiem.Controls.Add(bd);

        }

        public DiemCuaSV(string mssv, string hoTen)
        {
            InitializeComponent();
            this.mssv = mssv;

            List<DiemCuaSinhVien> nh = db.DiemCuaSinhViens.Where
                        (thongTin => thongTin.MSSV == mssv).OrderBy(x => x.NienKhoa).GroupBy(y => y.NienKhoa).SelectMany(z => z.OrderBy(g => g.HocKy)).ToList();
            if (nh.Count > 0)
            {
                BangDiemCuaSV x = new BangDiemCuaSV(nh);
                flowLayoutPanelDiem.Controls.Add(x);
            }

            labelTenSinhVien.Text = "Tên sinh viên: " + hoTen;
            labelMaSoSinhVien.Text = "[Mã số sinh viên: " + mssv + "]";
        }
    }
}
