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
    public partial class SuaDiem : Form
    {
        private DiemCuaSinhVien diem;

        public SuaDiem()
        {
            InitializeComponent();
        }

        public SuaDiem(DiemCuaSinhVien diem)
        {
            InitializeComponent();
            this.diem = diem;
            HienThiThongTin();
        }

        private void HienThiThongTin()
        {
            textBoxMaHocPhan.Text = diem.MaHocPhan;
            textBoxTenHocPhan.Text = diem.TenHocPhan;
            textBoxTinChi.Text = diem.TinChi.ToString();
            textBoxLoaiMonHoc.Text = diem.LoaiMonHoc;
            textBoxDiemQT.Text = diem.DiemQT.ToString();
            textBoxDiemThi.Text = diem.DiemThi.ToString();
            textBoxHocKy.Text = diem.HocKy.ToString();
            textBoxNienKhoa.Text = diem.NienKhoa;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            QLSVDB db = new QLSVDB();
            DiemCuaSinhVien diemCu = db.DiemCuaSinhViens.Where
                (thongTin => thongTin.MaHocPhan == this.diem.MaHocPhan && thongTin.TenHocPhan == this.diem.TenHocPhan
                 && thongTin.HocKy == this.diem.HocKy && thongTin.NienKhoa == this.diem.NienKhoa && thongTin.MSSV == this.diem.MSSV).SingleOrDefault();

            if (textBoxTinChi.Text != "")
                diemCu.TinChi = int.Parse(textBoxTinChi.Text);

            if (textBoxLoaiMonHoc.Text != "")
                diemCu.LoaiMonHoc = textBoxLoaiMonHoc.Text;

            if (textBoxDiemQT.Text != "")
                diemCu.DiemQT = float.Parse(textBoxDiemQT.Text);

            if (textBoxDiemThi.Text != "")
                diemCu.DiemThi = float.Parse(textBoxDiemThi.Text);

            if (textBoxDiemQT.Text != "" && textBoxDiemThi.Text != "")
            {
                float diem = (float.Parse(textBoxDiemQT.Text) + float.Parse(textBoxDiemThi.Text)) / 2;

                string diemChi;
                if (diem >= 8.5)
                    diemChi = "A";
                else if (diem >= 7.5)
                    diemChi = "B";
                else if (diem >= 6)
                    diemChi = "C";
                else if (diem >= 5)
                    diemChi = "D";
                else if (diem >= 3)
                    diemChi = "E";
                else
                    diemChi = "F";

                bool ketQua = diem >= 5;

                diemCu.Diem = diem;
                diemCu.DiemChi = diemChi;
                diemCu.KetQua = ketQua;
            }

            db.SaveChanges();

            this.Close();
        }

        private void textBoxTinChi_Leave(object sender, EventArgs e)
        {
            if (textBoxTinChi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số tín chỉ!",
                   "Thông báo", MessageBoxButtons.OK);
                textBoxTinChi.Focus();
            }
            else
            {
                int soTC;
                if (int.TryParse(textBoxTinChi.Text, out soTC))
                {
                    soTC = int.Parse(textBoxTinChi.Text);
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai định dạng. Mời bạn nhập lại",
                        "Thông báo", MessageBoxButtons.OK);
                    textBoxTinChi.Focus();
                }
            }
        }

        private void textBoxLoaiMonHoc_Leave(object sender, EventArgs e)
        {
            if (textBoxLoaiMonHoc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập loại môn học!",
                    "Thông báo", MessageBoxButtons.OK);
                textBoxLoaiMonHoc.Focus();
            }
        }

        private void textBoxDiemQT_Leave(object sender, EventArgs e)
        {
            float diemQT;
            if (textBoxDiemQT.Text != "")
            {
                if (float.TryParse(textBoxDiemQT.Text, out diemQT))
                {
                    diemQT = float.Parse(textBoxDiemQT.Text);
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai định dạng. Mời bạn nhập lại",
                        "Thông báo", MessageBoxButtons.OK);
                    textBoxDiemQT.Focus();
                }
            }
        }

        private void textBoxDiemThi_Leave(object sender, EventArgs e)
        {
            float diemThi;
            if (textBoxDiemThi.Text != "")
            {
                if (float.TryParse(textBoxDiemThi.Text, out diemThi))
                {
                    diemThi = float.Parse(textBoxDiemThi.Text);
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai định dạng. Mời bạn nhập lại",
                        "Thông báo", MessageBoxButtons.OK);
                    textBoxDiemThi.Focus();
                }
            }
        }
    }
}
