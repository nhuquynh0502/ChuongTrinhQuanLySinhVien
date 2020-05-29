using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLySinhVien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DiemCuaSVTheoHocKy("18133001", "Trương Hùng Anh"));
            //Application.Run(new DiemCuaSVTheoDanhSach("18133001","Trương Hùng Anh"));
            //Application.Run(new DiemCuaSV("18133001","Trương Hùng Anh"));
        }
    }
}
