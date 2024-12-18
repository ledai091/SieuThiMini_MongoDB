namespace SieuThiMini.GUI
{
    partial class ChiTietHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.display_Time = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.display_MaHD = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.display_MaNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_CTHD = new System.Windows.Forms.DataGridView();
            this.btn_InHD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.display_Time);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(240, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngày xuất";
            // 
            // display_Time
            // 
            this.display_Time.AutoSize = true;
            this.display_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_Time.Location = new System.Drawing.Point(4, 55);
            this.display_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.display_Time.Name = "display_Time";
            this.display_Time.Size = new System.Drawing.Size(29, 31);
            this.display_Time.TabIndex = 5;
            this.display_Time.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.display_MaHD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(346, 43);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(240, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã hoá đơn";
            // 
            // display_MaHD
            // 
            this.display_MaHD.AutoSize = true;
            this.display_MaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_MaHD.Location = new System.Drawing.Point(4, 55);
            this.display_MaHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.display_MaHD.Name = "display_MaHD";
            this.display_MaHD.Size = new System.Drawing.Size(31, 32);
            this.display_MaHD.TabIndex = 6;
            this.display_MaHD.Text = "2";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Controls.Add(this.display_MaNV);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(647, 43);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(240, 93);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mã nhân viên";
            // 
            // display_MaNV
            // 
            this.display_MaNV.AutoSize = true;
            this.display_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_MaNV.Location = new System.Drawing.Point(4, 55);
            this.display_MaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.display_MaNV.Name = "display_MaNV";
            this.display_MaNV.Size = new System.Drawing.Size(31, 32);
            this.display_MaNV.TabIndex = 7;
            this.display_MaNV.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHI TIẾT HOÁ ĐƠN";
            // 
            // grid_CTHD
            // 
            this.grid_CTHD.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_CTHD.Location = new System.Drawing.Point(43, 256);
            this.grid_CTHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grid_CTHD.Name = "grid_CTHD";
            this.grid_CTHD.RowHeadersWidth = 82;
            this.grid_CTHD.RowTemplate.Height = 33;
            this.grid_CTHD.Size = new System.Drawing.Size(844, 690);
            this.grid_CTHD.TabIndex = 4;
            // 
            // btn_InHD
            // 
            this.btn_InHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHD.Location = new System.Drawing.Point(395, 987);
            this.btn_InHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(150, 53);
            this.btn_InHD.TabIndex = 5;
            this.btn_InHD.Text = "IN";
            this.btn_InHD.UseVisualStyleBackColor = true;
            this.btn_InHD.Click += new System.EventHandler(this.btn_InHD_Click);
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(939, 840);
            this.Controls.Add(this.btn_InHD);
            this.Controls.Add(this.grid_CTHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChiTietHoaDon";
            this.Text = "Chi tiết hoá đơn";
            this.Load += new System.EventHandler(this.ChiTietHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label display_Time;
        private System.Windows.Forms.DataGridView grid_CTHD;
        private System.Windows.Forms.Label display_MaHD;
        private System.Windows.Forms.Label display_MaNV;
        private System.Windows.Forms.Button btn_InHD;
    }
}