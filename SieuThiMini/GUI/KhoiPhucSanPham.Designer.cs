namespace SieuThiMini.GUI
{
    partial class KhoiPhucSanPham
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_TimSanPham = new System.Windows.Forms.TextBox();
            this.btn_KhoiPhuc = new System.Windows.Forms.Button();
            this.grid_SanPham = new System.Windows.Forms.DataGridView();
            this.btn_Reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÔI PHỤC SẢN PHẨM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(158, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm";
            // 
            // textBox_TimSanPham
            // 
            this.textBox_TimSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TimSanPham.Location = new System.Drawing.Point(361, 182);
            this.textBox_TimSanPham.Name = "textBox_TimSanPham";
            this.textBox_TimSanPham.Size = new System.Drawing.Size(492, 56);
            this.textBox_TimSanPham.TabIndex = 2;
            this.textBox_TimSanPham.TextChanged += new System.EventHandler(this.textBox_TimSanPham_TextChanged);
            // 
            // btn_KhoiPhuc
            // 
            this.btn_KhoiPhuc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_KhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btn_KhoiPhuc.Location = new System.Drawing.Point(682, 262);
            this.btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            this.btn_KhoiPhuc.Size = new System.Drawing.Size(171, 101);
            this.btn_KhoiPhuc.TabIndex = 4;
            this.btn_KhoiPhuc.Text = "Khôi phục";
            this.btn_KhoiPhuc.UseVisualStyleBackColor = false;
            this.btn_KhoiPhuc.Click += new System.EventHandler(this.btn_KhoiPhuc_Click);
            // 
            // grid_SanPham
            // 
            this.grid_SanPham.BackgroundColor = System.Drawing.Color.White;
            this.grid_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SanPham.Location = new System.Drawing.Point(12, 400);
            this.grid_SanPham.Name = "grid_SanPham";
            this.grid_SanPham.RowHeadersWidth = 82;
            this.grid_SanPham.RowTemplate.Height = 33;
            this.grid_SanPham.Size = new System.Drawing.Size(1058, 960);
            this.grid_SanPham.TabIndex = 5;
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reload.Image = global::SieuThiMini.Properties.Resources.refresh;
            this.btn_Reload.Location = new System.Drawing.Point(361, 262);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(145, 101);
            this.btn_Reload.TabIndex = 3;
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // KhoiPhucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1082, 1372);
            this.Controls.Add(this.grid_SanPham);
            this.Controls.Add(this.btn_KhoiPhuc);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.textBox_TimSanPham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KhoiPhucSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khôi phục sản phẩm";
            this.Load += new System.EventHandler(this.KhoiPhucSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_TimSanPham;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_KhoiPhuc;
        private System.Windows.Forms.DataGridView grid_SanPham;
    }
}