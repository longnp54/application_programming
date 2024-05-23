using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Compiler.Ast;
using IronPython.Hosting;
using application_programming.Class;
using Microsoft.EntityFrameworkCore;

namespace application_programming
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
    
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect(); //Mở kết nối
        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
            
        }
        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmDMChatLieu frmChatLieu = new frmDMChatLieu(); //Khởi tạo đối tượng
            frmChatLieu.ShowDialog(); //Hiển thị
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMChatLieu frmHangHoa= new frmDMChatLieu(); //Khởi tạo đối tượng
            frmHangHoa.ShowDialog(); //Hiển thị
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHangHoa frmHangHoa = new frmDMHangHoa(); //Khởi tạo đối tượng
            frmHangHoa.Show(); //Hiển thị
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frmNhanVien = new frmDMNhanVien(); //Khởi tạo đối tượng
            frmNhanVien.Show(); //Hiển thị
        }

        //private void mnuThoat_Click(object sender, EventArgs e)
        //{
        //    Class.Functions.Disconnect(); //Đóng kết nối
        //    Application.Exit(); //Thoát
        //}

        private void mnuFile_Click(object sender, EventArgs e)
        {

        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frmHoaDonBan = new frmHoaDonBan();
            frmHoaDonBan.Show();
        }
    }
}
