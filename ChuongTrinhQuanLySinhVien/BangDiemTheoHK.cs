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
    public partial class BangDiemTheoHK : UserControl
    {
        private List<DiemCuaSinhVien> data;
        private int drl;

        public BangDiemTheoHK()
        {
            InitializeComponent();
        }

        public BangDiemTheoHK(List<DiemCuaSinhVien> data, int drl)
        {
            InitializeComponent();
            dataGridViewDiemTheoHK.AutoGenerateColumns = false; //tắt tự động sinh cột
            this.data = data;
            this.drl = drl;
            ThayDoiHocKy();
            DoDuLieu();
            ThayDoiSTC();
            ThayDoiDTB();
            ThayDoiDRLVaXepLoai();

            ThemNutXemDiem();
        }

        private void ThayDoiHocKy()
        {
            int hocKy = data[0].HocKy;
            string nienKhoa = data[0].NienKhoa;
            labelHocKy.Text = "Học kỳ " + hocKy.ToString() + "/ Năm học " + nienKhoa; 
        }

        private void DoDuLieu()
        {
            dataGridViewDiemTheoHK.DataSource = data;
        }

        private void ThayDoiSTC()
        {
            int stcDau = 0;
            int stcRot = 0;

            foreach (var item in data)
            {
                if ((bool)item.KetQua)
                {
                    stcDau += (int)item.TinChi;
                }
                else
                {
                    stcRot += (int)item.TinChi;
                }
            }

            int tongSTC = stcDau + stcRot;

            labelSTC.Text = "STC đậu (" + stcDau + ") + STC rớt (" + stcRot + ") = " + tongSTC;
        }

        private void ThayDoiDTB()
        {
            float tongDTB = 0;
            int tongSTC = 0;

            foreach (var item in data)
            {
                tongSTC += (int)item.TinChi;
                tongDTB += (float)item.Diem * (int)item.TinChi;
            }

            float dtb = tongDTB / tongSTC;

            labelDiemTrungBinh.Text = "Điểm trung bình: " + dtb.ToString("0.00");
        }

        private void ThayDoiDRLVaXepLoai()
        {
            labelDRL.Text = "Điểm rèn luyện = " + drl;

            if (drl >= 90 && drl <= 100)
                labelXepLoai.Text = "Xếp loại: xuất sắc";
            else if (drl >= 80)
                labelXepLoai.Text = "Xếp loại: tốt";
            else if (drl >= 70)
                labelXepLoai.Text = "Xếp loại: khá";
            else if (drl >= 60)
                labelXepLoai.Text = "Xếp loại: trung bình khá";
            else if (drl >= 50)
                labelXepLoai.Text = "Xếp loại: trung bình";
            else if (drl >= 30)
                labelXepLoai.Text = "Xếp loại: yếu";
            else
                labelXepLoai.Text = "Xếp loại: kém";
        }

        private void ThemNutXemDiem()
        {
            dataGridViewDiemTheoHK.Columns["XemDiem"].DefaultCellStyle.NullValue = "Xem điểm";
            dataGridViewDiemTheoHK.Refresh();
        }

        private void dataGridViewDiemTheoHK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                DiemThanhPhan form = new DiemThanhPhan(data[e.RowIndex]);
                form.ShowDialog();
            }
        }
    }
}
