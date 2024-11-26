namespace SieuThiMini.GUI
{
    partial class ThemLoaiSanPham
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
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_ThemLoaiSanPham = new System.Windows.Forms.Button();
            this.cb_MaNCC = new System.Windows.Forms.ComboBox();
            this.textBox_TenLoaiSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_Huy);
            this.panel1.Controls.Add(this.btn_ThemLoaiSanPham);
            this.panel1.Controls.Add(this.cb_MaNCC);
            this.panel1.Controls.Add(this.textBox_TenLoaiSanPham);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 522);
            this.panel1.TabIndex = 1;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Crimson;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(994, 396);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(254, 118);
            this.btn_Huy.TabIndex = 21;
            this.btn_Huy.Text = "Huỷ";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_ThemLoaiSanPham
            // 
            this.btn_ThemLoaiSanPham.BackColor = System.Drawing.Color.Navy;
            this.btn_ThemLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemLoaiSanPham.ForeColor = System.Drawing.Color.White;
            this.btn_ThemLoaiSanPham.Location = new System.Drawing.Point(718, 396);
            this.btn_ThemLoaiSanPham.Name = "btn_ThemLoaiSanPham";
            this.btn_ThemLoaiSanPham.Size = new System.Drawing.Size(270, 118);
            this.btn_ThemLoaiSanPham.TabIndex = 20;
            this.btn_ThemLoaiSanPham.Text = "Thêm";
            this.btn_ThemLoaiSanPham.UseVisualStyleBackColor = false;
            this.btn_ThemLoaiSanPham.Click += new System.EventHandler(this.btn_ThemLoaiSanPham_Click);
            // 
            // cb_MaNCC
            // 
            this.cb_MaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaNCC.FormattingEnabled = true;
            this.cb_MaNCC.Location = new System.Drawing.Point(454, 34);
            this.cb_MaNCC.Name = "cb_MaNCC";
            this.cb_MaNCC.Size = new System.Drawing.Size(794, 59);
            this.cb_MaNCC.TabIndex = 19;
            // 
            // textBox_TenLoaiSanPham
            // 
            this.textBox_TenLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenLoaiSanPham.Location = new System.Drawing.Point(454, 131);
            this.textBox_TenLoaiSanPham.Name = "textBox_TenLoaiSanPham";
            this.textBox_TenLoaiSanPham.Size = new System.Drawing.Size(794, 56);
            this.textBox_TenLoaiSanPham.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 51);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên loại sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 51);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã nhà cung cấp";
            // 
            // ThemLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1324, 540);
            this.Controls.Add(this.panel1);
            this.Name = "ThemLoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ThemLoaiSanPham";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_ThemLoaiSanPham;
        private System.Windows.Forms.ComboBox cb_MaNCC;
        private System.Windows.Forms.TextBox textBox_TenLoaiSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}