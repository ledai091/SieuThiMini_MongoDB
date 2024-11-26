namespace SieuThiMini.GUI
{
    partial class KhoiPhucHoaDon
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
            this.TimKiem = new System.Windows.Forms.GroupBox();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.grid_DSHDXoa = new System.Windows.Forms.DataGridView();
            this.TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSHDXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SẢN PHẨM BỊ XOÁ";
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
            // TimKiem
            // 
            this.TimKiem.BackColor = System.Drawing.Color.AliceBlue;
            this.TimKiem.CausesValidation = false;
            this.TimKiem.Controls.Add(this.textFind);
            this.TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiem.ForeColor = System.Drawing.Color.Black;
            this.TimKiem.Location = new System.Drawing.Point(58, 124);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(700, 104);
            this.TimKiem.TabIndex = 1;
            this.TimKiem.TabStop = false;
            this.TimKiem.Text = "Tìm kiếm";
            // 
            // btn_Restore
            // 
            this.btn_Restore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Restore.CausesValidation = false;
            this.btn_Restore.ForeColor = System.Drawing.Color.Black;
            this.btn_Restore.Image = global::SieuThiMini.Properties.Resources.data_restore;
            this.btn_Restore.Location = new System.Drawing.Point(873, 120);
            this.btn_Restore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(115, 108);
            this.btn_Restore.TabIndex = 8;
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // grid_DSHDXoa
            // 
            this.grid_DSHDXoa.BackgroundColor = System.Drawing.Color.White;
            this.grid_DSHDXoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DSHDXoa.Location = new System.Drawing.Point(58, 234);
            this.grid_DSHDXoa.Name = "grid_DSHDXoa";
            this.grid_DSHDXoa.RowHeadersWidth = 82;
            this.grid_DSHDXoa.RowTemplate.Height = 33;
            this.grid_DSHDXoa.Size = new System.Drawing.Size(930, 1088);
            this.grid_DSHDXoa.TabIndex = 9;
            // 
            // KhoiPhucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1026, 1332);
            this.Controls.Add(this.grid_DSHDXoa);
            this.Controls.Add(this.btn_Restore);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.label1);
            this.Name = "KhoiPhucHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khôi phục hoá đơn";
            this.Load += new System.EventHandler(this.KhoiPhucHoaDon_Load);
            this.TimKiem.ResumeLayout(false);
            this.TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSHDXoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFind;
        private System.Windows.Forms.GroupBox TimKiem;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.DataGridView grid_DSHDXoa;
    }
}