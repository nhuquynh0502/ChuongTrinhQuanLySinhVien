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
    public partial class DiemThanhPhan : Form
    {
        private DiemCuaSinhVien diem;


        public DiemThanhPhan()
        {
            InitializeComponent();
            //viuyihoiko
        }

        public DiemThanhPhan(DiemCuaSinhVien diem)
        {
            InitializeComponent();
            this.diem = diem;
            ThayDoiTenMonHoc();
            ThemDiemThanhPhan();
        }


        private void ThayDoiTenMonHoc()
        {
            string tenMonHoc = diem.TenHocPhan;
            labelTenMonHoc.Text = "Môn học: " + tenMonHoc;
        }

        private void ThemDiemThanhPhan()
        {
            dataGridViewDiemChiTiet.DataSource = new[] { 
                new {TenDiemThanhPhan = "Điểm thi giữa học phần", DiemChiTiet = diem.DiemQT},
                new {TenDiemThanhPhan = "Điểm thi kết thúc học phần", DiemChiTiet = diem.DiemThi} };
        }
    }
}
