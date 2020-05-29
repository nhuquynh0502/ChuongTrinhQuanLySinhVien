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
    public partial class DiemCuaSVTheoHocKy : Form
    {
        QLSVDB db = new QLSVDB();
        List<string> nienKhoa = new List<string>();
        private string mssv;

        public DiemCuaSVTheoHocKy()
        {
            InitializeComponent();

            BangDiemTheoHK x = new BangDiemTheoHK(db.DiemCuaSinhViens.ToList(), 100);
            containerPanelDiemTheoHK.Controls.Add(x);
        }

        public DiemCuaSVTheoHocKy(string mssv, string hoTen)
        {
            InitializeComponent();
            this.mssv = mssv;

            labelTenSinhVien.Text = "Tên sinh viên: " + hoTen;
            labelMaSoSinhVien.Text = "[Mã số sinh viên: " + mssv + "]";

            ThemNamHoc();
            ThemHocKy();

            TinhTrungBinhChungToanKhoa();
            TinhTrungBinhTichLuyToanKhoa();
            TinhSTCBatBuocTichLuy();
            TinhSTCTuChonTichLuy();
            XepLoaiHocLuc();

            //MessageBox.Show(containerPanelDiem.Controls.Count.ToString());
            ThemBangDiem();
        }


        private void TinhTrungBinhChungToanKhoa()
        {
            List<DiemCuaSinhVien> diemTBCuaSV = db.DiemCuaSinhViens.Where
                (thongTin => thongTin.MSSV == mssv).GroupBy(x => x.MaHocPhan).Select(y => y.OrderByDescending(z => z.Diem).FirstOrDefault()).ToList();

            float tongDTB = 0;
            int tongSTC = 0;

            foreach (var item in diemTBCuaSV)
            {
                tongSTC += (int)item.TinChi;
                tongDTB += (float)item.Diem * (int)item.TinChi;
            }

            float dtb = tongDTB / tongSTC;

            labelTrungBinhChungToanKhoa.Text = "Trung bình chung toàn khóa: " + dtb.ToString("0.00");
        }

        private void TinhTrungBinhTichLuyToanKhoa()
        {
            List<DiemCuaSinhVien> diemTLCuaSV = db.DiemCuaSinhViens.Where
                (thongTin => thongTin.MSSV == mssv && thongTin.KetQua == true).GroupBy(x => x.MaHocPhan).Select(y => y.OrderByDescending(z => z.Diem).FirstOrDefault()).ToList();

            float tongDTB = 0;
            int tongSTC = 0;

            foreach (var item in diemTLCuaSV)
            {

                tongSTC += (int)item.TinChi;
                tongDTB += (float)item.Diem * (int)item.TinChi;
            }

            float dtb = tongDTB / tongSTC;

            labelTrungBinhTichLuyToanKhoaHe10.Text = "Trung bình tích lũy toàn khóa hệ 10: " + dtb.ToString("0.00");
        }

        private void TinhSTCBatBuocTichLuy()
        {
            List<DiemCuaSinhVien> sctBBTLCuaSV = db.DiemCuaSinhViens.Where
                (thongTin => thongTin.MSSV == mssv && thongTin.KetQua == true && thongTin.LoaiMonHoc == "Bắt buộc").GroupBy(x => x.MaHocPhan).Select(y => y.OrderByDescending(z => z.Diem).FirstOrDefault()).ToList();

            int tongSTC = 0;

            foreach (var item in sctBBTLCuaSV)
            {
                tongSTC += (int)item.TinChi;
            }

            labelSTCBatBuocTichLuy.Text = "STC bắt buộc tích lũy: " + tongSTC.ToString();
        }

        private void TinhSTCTuChonTichLuy()
        {
            List<DiemCuaSinhVien> sctTCTLCuaSV = db.DiemCuaSinhViens.Where
                (thongTin => thongTin.MSSV == mssv && thongTin.KetQua == true && thongTin.LoaiMonHoc == "Tự chọn").GroupBy(x => x.MaHocPhan).Select(y => y.OrderByDescending(z => z.Diem).FirstOrDefault()).ToList();

            int tongSTC = 0;

            foreach (var item in sctTCTLCuaSV)
            {
                tongSTC += (int)item.TinChi;
            }

            labelSTCTuChonTichLuy.Text = "STC tự chọn tích lũy: " + tongSTC.ToString();
        }

        private void XepLoaiHocLuc()
        {
            List<DiemCuaSinhVien> xlCuaSV = db.DiemCuaSinhViens.Where
                (thongTin => thongTin.MSSV == mssv).GroupBy(x => x.MaHocPhan).Select(y => y.OrderByDescending(z => z.Diem).FirstOrDefault()).ToList();

            float tongDTB = 0;
            int tongSTC = 0;

            foreach (var item in xlCuaSV)
            {
                tongSTC += (int)item.TinChi;
                tongDTB += (float)item.Diem * (int)item.TinChi;
            }

            float dtb = tongDTB / tongSTC;

            if (dtb >= 8)
            {
                labelXepLoaiHocLuc.Text = "Xếp loại học lực: Giỏi";
            }
            else if (dtb >= 6.5)
            {
                labelXepLoaiHocLuc.Text = "Xếp loại học lực: Khá";
            }
            else if (dtb >= 5)
            {
                labelXepLoaiHocLuc.Text = "Xếp loại học lực: Trung bình";
            }
            else if (dtb >= 2.5)
            {
                labelXepLoaiHocLuc.Text = "Xếp loại học lực: Yếu";
            }
            else
            {
                labelXepLoaiHocLuc.Text = "Xếp loại học lực: Kém";
            }
        }

        private void ThemNamHoc()
        {
            nienKhoa.Add("Tất cả");

            int namHoc;
            namHoc = int.Parse("20" + mssv[0].ToString() + mssv[1].ToString());

            for (int i = namHoc; i < namHoc + 8; i++)
            {
                nienKhoa.Add(i + "-" + (i + 1));
            }

            comboBoxNamhoc.DataSource = nienKhoa;
        }

        private void ThemHocKy()
        {
            List<string> hocKy = new List<string>();

            hocKy.Add("Tất cả");
            hocKy.Add("Học kỳ 1");
            hocKy.Add("Học kỳ 2");
            hocKy.Add("Học kỳ 3");

            comboBoxHocKy.DataSource = hocKy;
        }

        private void ThemBangDiem()
        {
            foreach (var item in nienKhoa)
            {
                ThemBangDiem(item);
            }
        }


        private void XoaBangDiem()
        {
            int i = containerPanelDiemTheoHK.Controls.Count;

            while (i > 1)
            {
                containerPanelDiemTheoHK.Controls.RemoveAt(i-1);
                i--;
            }
        }

        private void ThemBangDiem(string namHoc)
        {
            for (int i = 1; i <= 3; i++)
            {
                ThemBangDiem(namHoc, i);
            }
        }

        private void comboBoxNamhoc_TextChanged(object sender, EventArgs e)
        {
            XoaBangDiem();

            if (comboBoxNamhoc.Text == "Tất cả")
            {
                comboBoxHocKy.Enabled = false;
                ThemBangDiem();
            }
            else
            {
                comboBoxHocKy.Enabled = true;
                ThemBangDiem(comboBoxNamhoc.Text);
            }

            comboBoxHocKy.Text = "Tất cả";
        }

        private void ThemBangDiem(string namHoc, int hocKy)
        {
            // foreach(thongTin trong danh sách thông tin) lấy những thông tin nào mà thongTin.MSSV == với MSSV
            List<DiemCuaSinhVien> nh = db.DiemCuaSinhViens.Where
                        (thongTin => thongTin.MSSV == mssv && thongTin.NienKhoa == namHoc && thongTin.HocKy == hocKy).ToList();
            if (nh.Count > 0)
            {
                BangDiemTheoHK x = new BangDiemTheoHK(nh, 100);
                containerPanelDiemTheoHK.Controls.Add(x);
            }
        } 

        private void comboBoxHocKy_TextChanged(object sender, EventArgs e)
        {
            XoaBangDiem();
            if (comboBoxHocKy.Text == "Tất cả")
            {
                ThemBangDiem(comboBoxNamhoc.Text);
            }
            else
            {
                int hk = int.Parse(comboBoxHocKy.Text[7].ToString());
                ThemBangDiem(comboBoxNamhoc.Text, hk);
            }

        }
    }
}
