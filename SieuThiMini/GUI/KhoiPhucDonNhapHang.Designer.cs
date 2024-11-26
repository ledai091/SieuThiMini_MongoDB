namespace SieuThiMini.GUI
{
    partial class KhoiPhucDonNhapHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.textFind = new System.Windows.Forms.TextBox();
            this.grid_DNHDeleted = new System.Windows.Forms.DataGridView();
            this.TimKiem = new System.Windows.Forms.GroupBox();
            this.btn_Restore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DNHDeleted)).BeginInit();
            this.TimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(831, 51);
            this.label1.TabIndex = 10;
            this.label1.Text = "DANH SÁCH ĐƠN NHẬP HÀNG BỊ XOÁ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textFind
            // 
            this.textFind.Location = new System.Drawing.Point(6, 43);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(688, 44);
            this.textFind.TabIndex = 0;
            this.textFind.TextChanged += new System.EventHandler(this.textFind_TextChanged);
            // 
            // grid_DNHDeleted
            // 
            this.grid_DNHDeleted.BackgroundColor = System.Drawing.Color.White;
            this.grid_DNHDeleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DNHDeleted.Location = new System.Drawing.Point(48, 224);
            this.grid_DNHDeleted.Name = "grid_DNHDeleted";
            this.grid_DNHDeleted.RowHeadersWidth = 82;
            this.grid_DNHDeleted.RowTemplate.Height = 33;
            this.grid_DNHDeleted.Size = new System.Drawing.Size(930, 1088);
            this.grid_DNHDeleted.TabIndex = 13;
            // 
            // TimKiem
            // 
            this.TimKiem.BackColor = System.Drawing.Color.AliceBlue;
            this.TimKiem.CausesValidation = false;
            this.TimKiem.Controls.Add(this.textFind);
            this.TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiem.ForeColor = System.Drawing.Color.Black;
            this.TimKiem.Location = new System.Drawing.Point(48, 114);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(700, 104);
            this.TimKiem.TabIndex = 11;
            this.TimKiem.TabStop = false;
            this.TimKiem.Text = "Tìm kiếm";
            // 
            // btn_Restore
            // 
            this.btn_Restore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Restore.CausesValidation = false;
            this.btn_Restore.ForeColor = System.Drawing.Color.Black;
            this.btn_Restore.Image = global::SieuThiMini.Properties.Resources.data_restore;
            this.btn_Restore.Location = new System.Drawing.Point(863, 110);
            this.btn_Restore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(115, 108);
            this.btn_Restore.TabIndex = 12;
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // KhoiPhucDonNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1026, 1332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_DNHDeleted);
            this.Controls.Add(this.btn_Restore);
            this.Controls.Add(this.TimKiem);
            this.Name = "KhoiPhucDonNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KhoiPhucDonNhapHang";
            this.Load += new System.EventHandler(this.KhoiPhucDonNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_DNHDeleted)).EndInit();
            this.TimKiem.ResumeLayout(false);
            this.TimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFind;
        private System.Windows.Forms.DataGridView grid_DNHDeleted;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.GroupBox TimKiem;
    }
}