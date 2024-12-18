namespace SieuThiMini.GUI
{
    partial class CTDonNhapHang
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
            this.display_MaDNH = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.display_MaNV = new System.Windows.Forms.Label();
            this.grid_CTDNH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTDNH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.display_Time);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(357, 93);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngày xuất";
            // 
            // display_Time
            // 
            this.display_Time.AutoSize = true;
            this.display_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_Time.Location = new System.Drawing.Point(4, 55);
            this.display_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.display_Time.Name = "display_Time";
            this.display_Time.Size = new System.Drawing.Size(31, 32);
            this.display_Time.TabIndex = 5;
            this.display_Time.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.display_MaDNH);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(408, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(297, 93);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã đơn nhập";
            // 
            // display_MaDNH
            // 
            this.display_MaDNH.AutoSize = true;
            this.display_MaDNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_MaDNH.Location = new System.Drawing.Point(4, 55);
            this.display_MaDNH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.display_MaDNH.Name = "display_MaDNH";
            this.display_MaDNH.Size = new System.Drawing.Size(31, 32);
            this.display_MaDNH.TabIndex = 6;
            this.display_MaDNH.Text = "2";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Controls.Add(this.display_MaNV);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(709, 26);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(182, 93);
            this.groupBox3.TabIndex = 8;
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
            // grid_CTDNH
            // 
            this.grid_CTDNH.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_CTDNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_CTDNH.Location = new System.Drawing.Point(47, 239);
            this.grid_CTDNH.Margin = new System.Windows.Forms.Padding(2);
            this.grid_CTDNH.Name = "grid_CTDNH";
            this.grid_CTDNH.RowHeadersWidth = 82;
            this.grid_CTDNH.RowTemplate.Height = 33;
            this.grid_CTDNH.Size = new System.Drawing.Size(844, 690);
            this.grid_CTDNH.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "CHI TIẾT ĐƠN NHẬP HÀNG";
            // 
            // CTDonNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(939, 840);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grid_CTDNH);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CTDonNhapHang";
            this.Text = "CTDonNhapHang";
            this.Load += new System.EventHandler(this.CTDonNhapHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTDNH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label display_Time;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label display_MaDNH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label display_MaNV;
        private System.Windows.Forms.DataGridView grid_CTDNH;
        private System.Windows.Forms.Label label1;
    }
}