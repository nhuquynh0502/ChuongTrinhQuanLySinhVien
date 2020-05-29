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
    public partial class ThemDiem : Form
    {
        private string mssv;

        public ThemDiem()
        {
            InitializeComponent();
        }

        public ThemDiem(string mssv)
        {
            InitializeComponent();
            this.mssv = mssv;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            DiemCuaSinhVien diemMoi = new DiemCuaSinhVien() 
            {
                MaHocPhan = textBoxMaHocPhan.Text,
                TenHocPhan = textBoxTenHocPhan.Text,
                TinChi = int.Parse(textBoxTinChi.Text),
                LoaiMonHoc = textBoxLoaiMonHoc.Text,
                HocKy = int.Parse(textBoxHocKy.Text),
                NienKhoa = textBoxNienKhoa.Text,
                MSSV = mssv
            };

            if (textBoxDiemQT.Text != "")
                diemMoi.DiemQT = float.Parse(textBoxDiemQT.Text);
            if (textBoxDiemThi.Text != "")
                diemMoi.DiemThi = float.Parse(textBoxDiemThi.Text);
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

                diemMoi.Diem = diem;
                diemMoi.DiemChi = diemChi;
                diemMoi.KetQua = ketQua;
            }


            QLSVDB db = new QLSVDB();
            db.DiemCuaSinhViens.Add(diemMoi);
            db.SaveChanges();

            this.Close();
        }


        private void textBoxMaHocPhan_Leave(object sender, EventArgs e)
        {
            if (textBoxMaHocPhan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã học phần!",
                    "Thông báo", MessageBoxButtons.OK);
                textBoxMaHocPhan.Focus();
            }
        }

        private void textBoxTenHocPhan_Leave(object sender, EventArgs e)
        {
            if (textBoxTenHocPhan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên học phần!",
                    "Thông báo", MessageBoxButtons.OK);
                textBoxTenHocPhan.Focus();
            }
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

        private void textBoxHocKy_Leave(object sender, EventArgs e)
        {
            if (textBoxHocKy.Text == "")
            {
                MessageBox.Show("Bạn phải nhập học kỳ!",
                    "Thông báo", MessageBoxButtons.OK);
                textBoxHocKy.Focus();
            }
            else
            {
                int hocKy;
                if (int.TryParse(textBoxHocKy.Text, out hocKy))
                {
                    hocKy = int.Parse(textBoxHocKy.Text);
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai định dạng. Mời bạn nhập lại",
                        "Thông báo", MessageBoxButtons.OK);
                    textBoxHocKy.Focus();
                }
            }
        }

        private void textBoxNienKhoa_Leave(object sender, EventArgs e)
        {
            if (textBoxNienKhoa.Text == "")
            {
                MessageBox.Show("Bạn phải nhập niên khóa!",
                    "Thông báo", MessageBoxButtons.OK);
                textBoxNienKhoa.Focus();
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
