namespace SieuThiMini.GUI
{
    partial class QuanLy
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
            this.label_HoTenNV = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_TaiKhoan = new System.Windows.Forms.Button();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.btn_NhaCungCap = new System.Windows.Forms.Button();
            this.btn_DonNhapHang = new System.Windows.Forms.Button();
            this.btn_LoaiSanPham = new System.Windows.Forms.Button();
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.panel_NhanVien = new System.Windows.Forms.Panel();
            this.panel_TaiKhoan = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_NhanVien.SuspendLayout();
            this.panel_TaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_HoTenNV);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 132);
            this.panel1.TabIndex = 0;
            // 
            // label_HoTenNV
            // 
            this.label_HoTenNV.AutoSize = true;
            this.label_HoTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HoTenNV.ForeColor = System.Drawing.Color.White;
            this.label_HoTenNV.Location = new System.Drawing.Point(169, 55);
            this.label_HoTenNV.Name = "label_HoTenNV";
            this.label_HoTenNV.Size = new System.Drawing.Size(148, 44);
            this.label_HoTenNV.TabIndex = 1;
            this.label_HoTenNV.Text = "Họ Tên";
            this.label_HoTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SieuThiMini.Properties.Resources.account;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(57, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 103);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(426, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2112, 132);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SieuThiMini.Properties.Resources.logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(781, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(847, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý siêu thị mini";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.Color.Azure;
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.Image = global::SieuThiMini.Properties.Resources.logout;
            this.btn_DangXuat.Location = new System.Drawing.Point(12, 1344);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(408, 118);
            this.btn_DangXuat.TabIndex = 10;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_TaiKhoan
            // 
            this.btn_TaiKhoan.BackColor = System.Drawing.Color.Azure;
            this.btn_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaiKhoan.Image = global::SieuThiMini.Properties.Resources.taikhoan;
            this.btn_TaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.btn_TaiKhoan.Name = "btn_TaiKhoan";
            this.btn_TaiKhoan.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btn_TaiKhoan.Size = new System.Drawing.Size(408, 118);
            this.btn_TaiKhoan.TabIndex = 9;
            this.btn_TaiKhoan.Text = "Tài khoản";
            this.btn_TaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TaiKhoan.UseVisualStyleBackColor = false;
            this.btn_TaiKhoan.Click += new System.EventHandler(this.btn_TaiKhoan_Click);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.BackColor = System.Drawing.Color.Azure;
            this.btn_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhanVien.Image = global::SieuThiMini.Properties.Resources.account1;
            this.btn_NhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhanVien.Location = new System.Drawing.Point(0, 0);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btn_NhanVien.Size = new System.Drawing.Size(408, 118);
            this.btn_NhanVien.TabIndex = 8;
            this.btn_NhanVien.Text = "Nhân viên";
            this.btn_NhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_NhanVien.UseVisualStyleBackColor = false;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.Color.Azure;
            this.btn_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.Image = global::SieuThiMini.Properties.Resources.thongke;
            this.btn_ThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongKe.Location = new System.Drawing.Point(12, 770);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btn_ThongKe.Size = new System.Drawing.Size(408, 118);
            this.btn_ThongKe.TabIndex = 7;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.BackColor = System.Drawing.Color.Azure;
            this.btn_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDon.Image = global::SieuThiMini.Properties.Resources.hoadon;
            this.btn_HoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HoaDon.Location = new System.Drawing.Point(12, 646);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btn_HoaDon.Size = new System.Drawing.Size(408, 118);
            this.btn_HoaDon.TabIndex = 6;
            this.btn_HoaDon.Text = "Hóa đơn";
            this.btn_HoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_HoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_HoaDon.UseVisualStyleBackColor = false;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // btn_NhaCungCap
            // 
            this.btn_NhaCungCap.BackColor = System.Drawing.Color.Azure;
            this.btn_NhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhaCungCap.Image = global::SieuThiMini.Properties.Resources.nhacungcap;
            this.btn_NhaCungCap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhaCungCap.Location = new System.Drawing.Point(12, 522);
            this.btn_NhaCungCap.Name = "btn_NhaCungCap";
            this.btn_NhaCungCap.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btn_NhaCungCap.Size = new System.Drawing.Size(408, 118);
            this.btn_NhaCungCap.TabIndex = 5;
            this.btn_NhaCungCap.Text = "Nhà cung cấp";
            this.btn_NhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhaCungCap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_NhaCungCap.UseVisualStyleBackColor = false;
            this.btn_NhaCungCap.Click += new System.EventHandler(this.btn_NhaCungCap_Click);
            // 
            // btn_DonNhapHang
            // 
            this.btn_DonNhapHang.BackColor = System.Drawing.Color.Azure;
            this.btn_DonNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DonNhapHang.Image = global::SieuThiMini.Properties.Resources.donnhaphang;
            this.btn_DonNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DonNhapHang.Location = new System.Drawing.Point(12, 398);
            this.btn_DonNhapHang.Name = "btn_DonNhapHang";
            this.btn_DonNhapHang.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btn_DonNhapHang.Size = new System.Drawing.Size(408, 118);
            this.btn_DonNhapHang.TabIndex = 4;
            this.btn_DonNhapHang.Text = "Đơn nhập hàng";
            this.btn_DonNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DonNhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DonNhapHang.UseVisualStyleBackColor = false;
            this.btn_DonNhapHang.Click += new System.EventHandler(this.btn_DonNhapHang_Click);
            // 
            // btn_LoaiSanPham
            // 
            this.btn_LoaiSanPham.BackColor = System.Drawing.Color.Azure;
            this.btn_LoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoaiSanPham.Image = global::SieuThiMini.Properties.Resources.loaisanpham;
            this.btn_LoaiSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LoaiSanPham.Location = new System.Drawing.Point(12, 274);
            this.btn_LoaiSanPham.Name = "btn_LoaiSanPham";
            this.btn_LoaiSanPham.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btn_LoaiSanPham.Size = new System.Drawing.Size(408, 118);
            this.btn_LoaiSanPham.TabIndex = 3;
            this.btn_LoaiSanPham.Text = "Loại sản phẩm";
            this.btn_LoaiSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LoaiSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LoaiSanPham.UseVisualStyleBackColor = false;
            this.btn_LoaiSanPham.Click += new System.EventHandler(this.btn_LoaiSanPham_Click);
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.BackColor = System.Drawing.Color.Azure;
            this.btn_SanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SanPham.Image = global::SieuThiMini.Properties.Resources.sanpham2;
            this.btn_SanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SanPham.Location = new System.Drawing.Point(12, 150);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btn_SanPham.Size = new System.Drawing.Size(408, 118);
            this.btn_SanPham.TabIndex = 2;
            this.btn_SanPham.Text = "Sản phẩm";
            this.btn_SanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SanPham.UseVisualStyleBackColor = false;
            this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
            // 
            // panel_Body
            // 
            this.panel_Body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Body.AutoSize = true;
            this.panel_Body.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_Body.Location = new System.Drawing.Point(426, 150);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(2112, 1312);
            this.panel_Body.TabIndex = 11;
            // 
            // panel_NhanVien
            // 
            this.panel_NhanVien.BackColor = System.Drawing.Color.Navy;
            this.panel_NhanVien.Controls.Add(this.btn_NhanVien);
            this.panel_NhanVien.Location = new System.Drawing.Point(12, 894);
            this.panel_NhanVien.Name = "panel_NhanVien";
            this.panel_NhanVien.Size = new System.Drawing.Size(408, 118);
            this.panel_NhanVien.TabIndex = 0;
            // 
            // panel_TaiKhoan
            // 
            this.panel_TaiKhoan.BackColor = System.Drawing.Color.Navy;
            this.panel_TaiKhoan.Controls.Add(this.btn_TaiKhoan);
            this.panel_TaiKhoan.Location = new System.Drawing.Point(12, 1018);
            this.panel_TaiKhoan.Name = "panel_TaiKhoan";
            this.panel_TaiKhoan.Size = new System.Drawing.Size(408, 118);
            this.panel_TaiKhoan.TabIndex = 9;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(2552, 1502);
            this.Controls.Add(this.panel_TaiKhoan);
            this.Controls.Add(this.panel_NhanVien);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_DangXuat);
            this.Controls.Add(this.btn_ThongKe);
            this.Controls.Add(this.btn_HoaDon);
            this.Controls.Add(this.btn_NhaCungCap);
            this.Controls.Add(this.btn_DonNhapHang);
            this.Controls.Add(this.btn_LoaiSanPham);
            this.Controls.Add(this.btn_SanPham);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý siêu thị mini";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_NhanVien.ResumeLayout(false);
            this.panel_TaiKhoan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_HoTenNV;
        private System.Windows.Forms.Button btn_SanPham;
        private System.Windows.Forms.Button btn_LoaiSanPham;
        private System.Windows.Forms.Button btn_DonNhapHang;
        private System.Windows.Forms.Button btn_NhaCungCap;
        private System.Windows.Forms.Button btn_HoaDon;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Button btn_TaiKhoan;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel panel_NhanVien;
        private System.Windows.Forms.Panel panel_TaiKhoan;
    }
}