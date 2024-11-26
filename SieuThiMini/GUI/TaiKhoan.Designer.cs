namespace SieuThiMini.GUI
{
    partial class TaiKhoan
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
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cb_PhanQuyen = new System.Windows.Forms.ComboBox();
            this.textBox_MK = new System.Windows.Forms.TextBox();
            this.textBox_TenTK = new System.Windows.Forms.TextBox();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_KhoiPhuc = new System.Windows.Forms.Button();
            this.btn_SuaTK = new System.Windows.Forms.Button();
            this.btn_XoaTK = new System.Windows.Forms.Button();
            this.textBox_MaTK = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ThemTK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grid_TK = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TimTK = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TK)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(383, 51);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tìm kiếm tài khoản";
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Crimson;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(1057, 574);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(178, 68);
            this.btn_Huy.TabIndex = 13;
            this.btn_Huy.Text = "Huỷ";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Navy;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(856, 574);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(178, 68);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cb_PhanQuyen
            // 
            this.cb_PhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PhanQuyen.FormattingEnabled = true;
            this.cb_PhanQuyen.Location = new System.Drawing.Point(375, 110);
            this.cb_PhanQuyen.Name = "cb_PhanQuyen";
            this.cb_PhanQuyen.Size = new System.Drawing.Size(860, 59);
            this.cb_PhanQuyen.TabIndex = 11;
            // 
            // textBox_MK
            // 
            this.textBox_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MK.Location = new System.Drawing.Point(375, 301);
            this.textBox_MK.Name = "textBox_MK";
            this.textBox_MK.Size = new System.Drawing.Size(860, 56);
            this.textBox_MK.TabIndex = 8;
            // 
            // textBox_TenTK
            // 
            this.textBox_TenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenTK.Location = new System.Drawing.Point(375, 207);
            this.textBox_TenTK.Name = "textBox_TenTK";
            this.textBox_TenTK.Size = new System.Drawing.Size(860, 56);
            this.textBox_TenTK.TabIndex = 7;
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Image = global::SieuThiMini.Properties.Resources.refresh1;
            this.btn_Reload.Location = new System.Drawing.Point(439, 282);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(304, 118);
            this.btn_Reload.TabIndex = 4;
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_KhoiPhuc
            // 
            this.btn_KhoiPhuc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_KhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btn_KhoiPhuc.Location = new System.Drawing.Point(51, 282);
            this.btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            this.btn_KhoiPhuc.Size = new System.Drawing.Size(304, 118);
            this.btn_KhoiPhuc.TabIndex = 3;
            this.btn_KhoiPhuc.Text = "Khôi phục";
            this.btn_KhoiPhuc.UseVisualStyleBackColor = false;
            this.btn_KhoiPhuc.Click += new System.EventHandler(this.btn_KhoiPhuc_Click);
            // 
            // btn_SuaTK
            // 
            this.btn_SuaTK.BackColor = System.Drawing.Color.Green;
            this.btn_SuaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaTK.ForeColor = System.Drawing.Color.White;
            this.btn_SuaTK.Location = new System.Drawing.Point(439, 142);
            this.btn_SuaTK.Name = "btn_SuaTK";
            this.btn_SuaTK.Size = new System.Drawing.Size(304, 118);
            this.btn_SuaTK.TabIndex = 2;
            this.btn_SuaTK.Text = "Sửa";
            this.btn_SuaTK.UseVisualStyleBackColor = false;
            this.btn_SuaTK.Click += new System.EventHandler(this.btn_SuaTK_Click);
            // 
            // btn_XoaTK
            // 
            this.btn_XoaTK.BackColor = System.Drawing.Color.Crimson;
            this.btn_XoaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaTK.ForeColor = System.Drawing.Color.White;
            this.btn_XoaTK.Location = new System.Drawing.Point(51, 145);
            this.btn_XoaTK.Name = "btn_XoaTK";
            this.btn_XoaTK.Size = new System.Drawing.Size(304, 118);
            this.btn_XoaTK.TabIndex = 1;
            this.btn_XoaTK.Text = "Xoá";
            this.btn_XoaTK.UseVisualStyleBackColor = false;
            this.btn_XoaTK.Click += new System.EventHandler(this.btn_XoaTK_Click);
            // 
            // textBox_MaTK
            // 
            this.textBox_MaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaTK.Location = new System.Drawing.Point(375, 19);
            this.textBox_MaTK.Name = "textBox_MaTK";
            this.textBox_MaTK.Size = new System.Drawing.Size(860, 56);
            this.textBox_MaTK.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.btn_Reload);
            this.panel3.Controls.Add(this.btn_KhoiPhuc);
            this.panel3.Controls.Add(this.btn_SuaTK);
            this.panel3.Controls.Add(this.btn_XoaTK);
            this.panel3.Controls.Add(this.btn_ThemTK);
            this.panel3.Location = new System.Drawing.Point(1326, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 416);
            this.panel3.TabIndex = 6;
            // 
            // btn_ThemTK
            // 
            this.btn_ThemTK.BackColor = System.Drawing.Color.Navy;
            this.btn_ThemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTK.ForeColor = System.Drawing.Color.White;
            this.btn_ThemTK.Location = new System.Drawing.Point(51, 7);
            this.btn_ThemTK.Name = "btn_ThemTK";
            this.btn_ThemTK.Size = new System.Drawing.Size(692, 118);
            this.btn_ThemTK.TabIndex = 0;
            this.btn_ThemTK.Text = "Thêm";
            this.btn_ThemTK.UseVisualStyleBackColor = false;
            this.btn_ThemTK.Click += new System.EventHandler(this.btn_ThemTK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 51);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // grid_TK
            // 
            this.grid_TK.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_TK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_TK.Location = new System.Drawing.Point(12, 672);
            this.grid_TK.Name = "grid_TK";
            this.grid_TK.RowHeadersWidth = 82;
            this.grid_TK.RowTemplate.Height = 33;
            this.grid_TK.Size = new System.Drawing.Size(2092, 616);
            this.grid_TK.TabIndex = 7;
            this.grid_TK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_TK_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên tài khoản";
            // 
            // textBox_TimTK
            // 
            this.textBox_TimTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TimTK.Location = new System.Drawing.Point(51, 152);
            this.textBox_TimTK.Name = "textBox_TimTK";
            this.textBox_TimTK.Size = new System.Drawing.Size(692, 56);
            this.textBox_TimTK.TabIndex = 14;
            this.textBox_TimTK.TextChanged += new System.EventHandler(this.textBox_TimTK_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.textBox_TimTK);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(1326, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 226);
            this.panel2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(238, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(349, 44);
            this.label8.TabIndex = 14;
            this.label8.Text = "(Tên, mã tài khoản)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phân quyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tài khoản";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_Huy);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.cb_PhanQuyen);
            this.panel1.Controls.Add(this.textBox_MK);
            this.panel1.Controls.Add(this.textBox_TenTK);
            this.panel1.Controls.Add(this.textBox_MaTK);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 646);
            this.panel1.TabIndex = 4;
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(2116, 1300);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grid_TK);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_TK)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cb_PhanQuyen;
        private System.Windows.Forms.TextBox textBox_MK;
        private System.Windows.Forms.TextBox textBox_TenTK;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_KhoiPhuc;
        private System.Windows.Forms.Button btn_SuaTK;
        private System.Windows.Forms.Button btn_XoaTK;
        private System.Windows.Forms.TextBox textBox_MaTK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_ThemTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grid_TK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TimTK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}