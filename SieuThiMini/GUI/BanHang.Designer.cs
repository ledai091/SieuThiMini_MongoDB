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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.labelDonHang);
            this.panel1.Controls.Add(this.grid_HoaDon);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 1185);
            this.panel1.TabIndex = 0;
            // 
            // labelDonHang
            // 
            this.labelDonHang.AutoSize = true;
            this.labelDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDonHang.Location = new System.Drawing.Point(13, 28);
            this.labelDonHang.Name = "labelDonHang";
            this.labelDonHang.Size = new System.Drawing.Size(296, 67);
            this.labelDonHang.TabIndex = 1;
            this.labelDonHang.Text = "Đơn Hàng";
            this.labelDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grid_HoaDon
            // 
            this.grid_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_HoaDon.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_HoaDon.Location = new System.Drawing.Point(14, 98);
            this.grid_HoaDon.Name = "grid_HoaDon";
            this.grid_HoaDon.RowHeadersWidth = 82;
            this.grid_HoaDon.RowTemplate.Height = 33;
            this.grid_HoaDon.Size = new System.Drawing.Size(776, 1070);
            this.grid_HoaDon.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.btn_XoaMon);
            this.panel2.Controls.Add(this.btn_ThemMon);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(880, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 268);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_TimKiem);
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(56, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1084, 86);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.Navy;
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(882, 20);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(196, 60);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 39);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(839, 41);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ud_SoLuong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(932, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số lượng";
            // 
            // ud_SoLuong
            // 
            this.ud_SoLuong.Location = new System.Drawing.Point(6, 39);
            this.ud_SoLuong.Name = "ud_SoLuong";
            this.ud_SoLuong.Size = new System.Drawing.Size(196, 41);
            this.ud_SoLuong.TabIndex = 2;
            // 
            // btn_XoaMon
            // 
            this.btn_XoaMon.BackColor = System.Drawing.Color.Navy;
            this.btn_XoaMon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_XoaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaMon.ForeColor = System.Drawing.Color.White;
            this.btn_XoaMon.Image = global::SieuThiMini.Properties.Resources.xoa;
            this.btn_XoaMon.Location = new System.Drawing.Point(694, 28);
            this.btn_XoaMon.Name = "btn_XoaMon";
            this.btn_XoaMon.Size = new System.Drawing.Size(204, 86);
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
            this.btn_ThemMon.Location = new System.Drawing.Point(430, 28);
            this.btn_ThemMon.Name = "btn_ThemMon";
            this.btn_ThemMon.Size = new System.Drawing.Size(204, 86);
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
            this.groupBox1.Location = new System.Drawing.Point(56, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại sản phẩm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbo_LoaiMon
            // 
            this.cbo_LoaiMon.FormattingEnabled = true;
            this.cbo_LoaiMon.Location = new System.Drawing.Point(6, 39);
            this.cbo_LoaiMon.Name = "cbo_LoaiMon";
            this.cbo_LoaiMon.Size = new System.Drawing.Size(330, 41);
            this.cbo_LoaiMon.TabIndex = 0;
            this.cbo_LoaiMon.SelectedIndexChanged += new System.EventHandler(this.cbo_LoaiMon_SelectedIndexChanged);
            // 
            // grid_SanPham
            // 
            this.grid_SanPham.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SanPham.Location = new System.Drawing.Point(880, 298);
            this.grid_SanPham.Name = "grid_SanPham";
            this.grid_SanPham.RowHeadersWidth = 82;
            this.grid_SanPham.RowTemplate.Height = 33;
            this.grid_SanPham.Size = new System.Drawing.Size(1184, 586);
            this.grid_SanPham.TabIndex = 2;
            this.grid_SanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_SanPham_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.btn_ThanhToan);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Location = new System.Drawing.Point(880, 912);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1183, 284);
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
            this.btn_ThanhToan.Location = new System.Drawing.Point(879, 187);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(261, 81);
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
            this.groupBox4.Location = new System.Drawing.Point(56, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1084, 144);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tổng tiền cần thanh toán";
            // 
            // label_TT
            // 
            this.label_TT.AutoSize = true;
            this.label_TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TT.Location = new System.Drawing.Point(19, 50);
            this.label_TT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_TT.Name = "label_TT";
            this.label_TT.Size = new System.Drawing.Size(57, 63);
            this.label_TT.TabIndex = 0;
            this.label_TT.Text = "0";
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(2082, 1209);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grid_SanPham);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.ResumeLayout(false);

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
    }
}