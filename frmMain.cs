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
            Class.Functions.Connect();
        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }
        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void mnuDanhmuc_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
