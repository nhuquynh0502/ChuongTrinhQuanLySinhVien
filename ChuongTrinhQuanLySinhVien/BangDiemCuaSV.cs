using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLySinhVien
{
    public partial class BangDiemCuaSV : UserControl
    {
        private List<DiemCuaSinhVien> data;

        public BangDiemCuaSV()
        {
            InitializeComponent();
        }

        public BangDiemCuaSV(List<DiemCuaSinhVien> data)
        {
            InitializeComponent();
            dataGridViewDiemCuaSV.AutoGenerateColumns = false; //tắt tự động sinh cột
            this.data = data;
            DoDuLieu();
        }

        private void DoDuLieu()
        {
            dataGridViewDiemCuaSV.DataSource = data;    
            dataGridViewDiemCuaSV.Refresh();
        }

        private void DoLaiDuLieu()
        {
            QLSVDB db = new QLSVDB();
            string mssv = data[0].MSSV;
            data = db.DiemCuaSinhViens.Where(x => x.MSSV == mssv).ToList();
            DoDuLieu();
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            ThemDiem them = new ThemDiem(data[0].MSSV);
            them.ShowDialog();

            DoLaiDuLieu();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?",
                "Thông báo",
                MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                DiemCuaSinhVien diemCanXoa = data[dataGridViewDiemCuaSV.SelectedCells[0].RowIndex];
                QLSVDB db = new QLSVDB();
                DiemCuaSinhVien diemXoa = db.DiemCuaSinhViens.Where
                    (x => x.MSSV == diemCanXoa.MSSV && x.MaHocPhan == diemCanXoa.MaHocPhan && x.TenHocPhan == diemCanXoa.TenHocPhan
                     && x.HocKy == diemCanXoa.HocKy && x.NienKhoa == diemCanXoa.NienKhoa).SingleOrDefault();

                db.DiemCuaSinhViens.Remove(diemXoa);
                db.SaveChanges();
                DoLaiDuLieu();
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SuaDiem sua = new SuaDiem(data[dataGridViewDiemCuaSV.SelectedCells[0].RowIndex]);
            sua.ShowDialog();

            DoLaiDuLieu();
        }
    }
}
