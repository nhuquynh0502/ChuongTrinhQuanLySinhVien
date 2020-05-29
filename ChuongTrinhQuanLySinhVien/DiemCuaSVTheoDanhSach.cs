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
    public partial class DiemCuaSVTheoDanhSach : Form
    {
        QLSVDB db = new QLSVDB();
        private string mssv;

        public DiemCuaSVTheoDanhSach()
        {
            InitializeComponent();
            BangDiemTheoDS bd = new BangDiemTheoDS(db.DiemCuaSinhViens.ToList());
            flowLayoutPanelDiemTheoDS.Controls.Add(bd);

        }

        public DiemCuaSVTheoDanhSach(string mssv, string hoTen)
        {
            InitializeComponent();
            this.mssv = mssv;

            List<DiemCuaSinhVien> nh = db.DiemCuaSinhViens.Where
                        (thongTin => thongTin.MSSV == mssv).GroupBy(x => x.MaHocPhan).Select(y => y.OrderByDescending(z => z.Diem).FirstOrDefault()).ToList();
            if (nh.Count > 0)
            {
                BangDiemTheoDS x = new BangDiemTheoDS(nh);
                flowLayoutPanelDiemTheoDS.Controls.Add(x);
            }

            labelTenSinhVien.Text = "Tên sinh viên: " + hoTen;
            labelMaSoSinhVien.Text = "[Mã số sinh viên: " + mssv + "]";

            TinhTrungBinhChungToanKhoa();
            TinhTrungBinhTichLuyToanKhoa();
            TinhSTCBatBuocTichLuy();
            TinhSTCTuChonTichLuy();
            XepLoaiHocLuc();
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
    }
}
