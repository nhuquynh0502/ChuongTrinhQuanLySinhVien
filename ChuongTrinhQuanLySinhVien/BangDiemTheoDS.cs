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
    public partial class BangDiemTheoDS : UserControl
    {
        private List<DiemCuaSinhVien> data;

        public BangDiemTheoDS()
        {
            InitializeComponent();
        }

        public BangDiemTheoDS(List<DiemCuaSinhVien> data)
        {
            InitializeComponent();
            dataGridViewDiemTheoDS.AutoGenerateColumns = false; //tắt tự động sinh cột
            this.data = data;
            DoDuLieu();
        }

        private void DoDuLieu()
        {
            dataGridViewDiemTheoDS.DataSource = data;
        }
    }
}
