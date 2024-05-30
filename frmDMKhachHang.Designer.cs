namespace application_programming
{
    partial class frmDMKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.txtTenChatLieu = new System.Windows.Forms.Label();
            this.txtMaChatLieu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(167, 103);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(206, 22);
            this.txtTenKhach.TabIndex = 9;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(167, 58);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(206, 22);
            this.txtMaKhach.TabIndex = 8;
            this.txtMaKhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaKhach_KeyUp);
            // 
            // txtTenChatLieu
            // 
            this.txtTenChatLieu.AutoSize = true;
            this.txtTenChatLieu.Location = new System.Drawing.Point(70, 103);
            this.txtTenChatLieu.Name = "txtTenChatLieu";
            this.txtTenChatLieu.Size = new System.Drawing.Size(70, 16);
            this.txtTenChatLieu.TabIndex = 7;
            this.txtTenChatLieu.Text = "Tên khách";
            // 
            // txtMaChatLieu
            // 
            this.txtMaChatLieu.AutoSize = true;
            this.txtMaChatLieu.Location = new System.Drawing.Point(70, 58);
            this.txtMaChatLieu.Name = "txtMaChatLieu";
            this.txtMaChatLieu.Size = new System.Drawing.Size(65, 16);
            this.txtMaChatLieu.TabIndex = 6;
            this.txtMaChatLieu.Text = "Mã khách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(279, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnBoQua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(38, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 33);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(683, 34);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(79, 33);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(554, 34);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(79, 33);
            this.btnBoQua.TabIndex = 10;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(425, 34);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(79, 33);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(296, 34);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 33);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(167, 34);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 33);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(38, 152);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(724, 183);
            this.dgvKhachHang.TabIndex = 11;
            this.dgvKhachHang.Click += new System.EventHandler(this.dgvKhachHang_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(532, 58);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(206, 22);
            this.txtDiaChi.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Địa chỉ";
            // 
            // mtbDienThoai
            // 
            this.mtbDienThoai.Location = new System.Drawing.Point(532, 103);
            this.mtbDienThoai.Mask = "(9999) 000-000";
            this.mtbDienThoai.Name = "mtbDienThoai";
            this.mtbDienThoai.Size = new System.Drawing.Size(206, 22);
            this.mtbDienThoai.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Điện thoại";
            // 
            // frmDMKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.txtMaKhach);
            this.Controls.Add(this.txtTenChatLieu);
            this.Controls.Add(this.txtMaChatLieu);
            this.Controls.Add(this.label1);
            this.Name = "frmDMKhachHang";
            this.Text = "DANH MỤC KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmDMKhachHang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.Label txtTenChatLieu;
        private System.Windows.Forms.Label txtMaChatLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbDienThoai;
        private System.Windows.Forms.Label label3;
    }
}