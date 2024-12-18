namespace SieuThiMini.GUI
{
    partial class BanHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDonHang = new System.Windows.Forms.Label();
            this.grid_HoaDon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ud_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.btn_XoaMon = new System.Windows.Forms.Button();
            this.btn_ThemMon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_LoaiMon = new System.Windows.Forms.ComboBox();
            this.grid_SanPham = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_TT = new System.Windows.Forms.Label();
            this.groupBox_TTNV = new System.Windows.Forms.GroupBox();
            this.Email_NV = new System.Windows.Forms.Label();
            this.SDT_NV = new System.Windows.Forms.Label();
            this.TenNV = new System.Windows.Forms.Label();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_HoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_SoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SanPham)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox_TTNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.labelDonHang);
            this.panel1.Controls.Add(this.grid_HoaDon);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 948);
            this.panel1.TabIndex = 0;
            // 
            // labelDonHang
            // 
            this.labelDonHang.AutoSize = true;
            this.labelDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDonHang.Location = new System.Drawing.Point(10, 22);
            this.labelDonHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDonHang.Name = "labelDonHang";
            this.labelDonHang.Size = new System.Drawing.Size(219, 52);
            this.labelDonHang.TabIndex = 1;
            this.labelDonHang.Text = "Đơn Hàng";
            this.labelDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grid_HoaDon
            // 
            this.grid_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_HoaDon.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_HoaDon.Location = new System.Drawing.Point(10, 78);
            this.grid_HoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.grid_HoaDon.Name = "grid_HoaDon";
            this.grid_HoaDon.RowHeadersWidth = 82;
            this.grid_HoaDon.RowTemplate.Height = 33;
            this.grid_HoaDon.Size = new System.Drawing.Size(582, 856);
            this.grid_HoaDon.TabIndex = 0;
            this.grid_HoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_HoaDon_CellContentClick);
            this.grid_HoaDon.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_HoaDon_CellValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.btn_XoaMon);
            this.panel2.Controls.Add(this.btn_ThemMon);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(660, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 214);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_TimKiem);
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(42, 128);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(813, 69);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.Navy;
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(662, 16);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(147, 48);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(4, 31);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(630, 32);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ud_SoLuong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(699, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(156, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số lượng";
            // 
            // ud_SoLuong
            // 
            this.ud_SoLuong.Location = new System.Drawing.Point(4, 31);
            this.ud_SoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.ud_SoLuong.Name = "ud_SoLuong";
            this.ud_SoLuong.Size = new System.Drawing.Size(147, 32);
            this.ud_SoLuong.TabIndex = 2;
            this.ud_SoLuong.ValueChanged += new System.EventHandler(this.ud_SoLuong_ValueChanged);
            // 
            // btn_XoaMon
            // 
            this.btn_XoaMon.BackColor = System.Drawing.Color.Navy;
            this.btn_XoaMon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_XoaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaMon.ForeColor = System.Drawing.Color.White;
            this.btn_XoaMon.Image = global::SieuThiMini.Properties.Resources.xoa;
            this.btn_XoaMon.Location = new System.Drawing.Point(520, 22);
            this.btn_XoaMon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XoaMon.Name = "btn_XoaMon";
            this.btn_XoaMon.Size = new System.Drawing.Size(153, 69);
            this.btn_XoaMon.TabIndex = 2;
            this.btn_XoaMon.Text = "Xoá";
            this.btn_XoaMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaMon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XoaMon.UseVisualStyleBackColor = false;
            this.btn_XoaMon.Click += new System.EventHandler(this.btn_XoaMon_Click);
            // 
            // btn_ThemMon
            // 
            this.btn_ThemMon.BackColor = System.Drawing.Color.Navy;
            this.btn_ThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemMon.ForeColor = System.Drawing.Color.White;
            this.btn_ThemMon.Image = global::SieuThiMini.Properties.Resources.them;
            this.btn_ThemMon.Location = new System.Drawing.Point(322, 22);
            this.btn_ThemMon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThemMon.Name = "btn_ThemMon";
            this.btn_ThemMon.Size = new System.Drawing.Size(153, 69);
            this.btn_ThemMon.TabIndex = 1;
            this.btn_ThemMon.Text = "Thêm";
            this.btn_ThemMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThemMon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemMon.UseVisualStyleBackColor = false;
            this.btn_ThemMon.Click += new System.EventHandler(this.btn_ThemMon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_LoaiMon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(256, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại sản phẩm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbo_LoaiMon
            // 
            this.cbo_LoaiMon.FormattingEnabled = true;
            this.cbo_LoaiMon.Location = new System.Drawing.Point(4, 31);
            this.cbo_LoaiMon.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_LoaiMon.Name = "cbo_LoaiMon";
            this.cbo_LoaiMon.Size = new System.Drawing.Size(248, 34);
            this.cbo_LoaiMon.TabIndex = 0;
            this.cbo_LoaiMon.SelectedIndexChanged += new System.EventHandler(this.cbo_LoaiMon_SelectedIndexChanged);
            // 
            // grid_SanPham
            // 
            this.grid_SanPham.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SanPham.Location = new System.Drawing.Point(660, 238);
            this.grid_SanPham.Margin = new System.Windows.Forms.Padding(2);
            this.grid_SanPham.Name = "grid_SanPham";
            this.grid_SanPham.RowHeadersWidth = 82;
            this.grid_SanPham.RowTemplate.Height = 33;
            this.grid_SanPham.Size = new System.Drawing.Size(888, 469);
            this.grid_SanPham.TabIndex = 2;
            this.grid_SanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_SanPham_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.btn_ThanhToan);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Location = new System.Drawing.Point(660, 730);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(887, 227);
            this.panel3.TabIndex = 3;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.AutoSize = true;
            this.btn_ThanhToan.BackColor = System.Drawing.Color.Navy;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_ThanhToan.Image = global::SieuThiMini.Properties.Resources.thanhToan__2_;
            this.btn_ThanhToan.Location = new System.Drawing.Point(659, 150);
            this.btn_ThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(196, 65);
            this.btn_ThanhToan.TabIndex = 0;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.label_TT);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(42, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(813, 115);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tổng tiền cần thanh toán";
            // 
            // label_TT
            // 
            this.label_TT.AutoSize = true;
            this.label_TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TT.Location = new System.Drawing.Point(14, 40);
            this.label_TT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TT.Name = "label_TT";
            this.label_TT.Size = new System.Drawing.Size(42, 46);
            this.label_TT.TabIndex = 0;
            this.label_TT.Text = "0";
            // 
            // groupBox_TTNV
            // 
            this.groupBox_TTNV.BackColor = System.Drawing.Color.White;
            this.groupBox_TTNV.Controls.Add(this.Email_NV);
            this.groupBox_TTNV.Controls.Add(this.SDT_NV);
            this.groupBox_TTNV.Controls.Add(this.TenNV);
            this.groupBox_TTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TTNV.Location = new System.Drawing.Point(1552, 11);
            this.groupBox_TTNV.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_TTNV.Name = "groupBox_TTNV";
            this.groupBox_TTNV.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_TTNV.Size = new System.Drawing.Size(349, 213);
            this.groupBox_TTNV.TabIndex = 1;
            this.groupBox_TTNV.TabStop = false;
            this.groupBox_TTNV.Text = "Thông tin nhân viên";
            // 
            // Email_NV
            // 
            this.Email_NV.AutoSize = true;
            this.Email_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Email_NV.Location = new System.Drawing.Point(6, 150);
            this.Email_NV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email_NV.Name = "Email_NV";
            this.Email_NV.Size = new System.Drawing.Size(31, 32);
            this.Email_NV.TabIndex = 3;
            this.Email_NV.Text = "0";
            // 
            // SDT_NV
            // 
            this.SDT_NV.AutoSize = true;
            this.SDT_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SDT_NV.Location = new System.Drawing.Point(6, 87);
            this.SDT_NV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SDT_NV.Name = "SDT_NV";
            this.SDT_NV.Size = new System.Drawing.Size(31, 32);
            this.SDT_NV.TabIndex = 2;
            this.SDT_NV.Text = "0";
            // 
            // TenNV
            // 
            this.TenNV.AutoSize = true;
            this.TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TenNV.Location = new System.Drawing.Point(6, 30);
            this.TenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TenNV.Name = "TenNV";
            this.TenNV.Size = new System.Drawing.Size(31, 32);
            this.TenNV.TabIndex = 1;
            this.TenNV.Text = "0";
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.AutoSize = true;
            this.btn_DangXuat.BackColor = System.Drawing.Color.Navy;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.White;
            this.btn_DangXuat.Location = new System.Drawing.Point(1558, 892);
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(343, 65);
            this.btn_DangXuat.TabIndex = 1;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1911, 1013);
            this.Controls.Add(this.btn_DangXuat);
            this.Controls.Add(this.groupBox_TTNV);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grid_SanPham);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.BanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_HoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ud_SoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_SanPham)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox_TTNV.ResumeLayout(false);
            this.groupBox_TTNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid_HoaDon;
        private System.Windows.Forms.Label labelDonHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ThemMon;
        private System.Windows.Forms.ComboBox cbo_LoaiMon;
        private System.Windows.Forms.Button btn_XoaMon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.NumericUpDown ud_SoLuong;
        private System.Windows.Forms.DataGridView grid_SanPham;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Label label_TT;
        private System.Windows.Forms.GroupBox groupBox_TTNV;
        private System.Windows.Forms.Label Email_NV;
        private System.Windows.Forms.Label SDT_NV;
        private System.Windows.Forms.Label TenNV;
        private System.Windows.Forms.Button btn_DangXuat;
    }
}