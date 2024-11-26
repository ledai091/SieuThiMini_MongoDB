namespace SieuThiMini.GUI
{
    partial class KhoiPhucNhanVien
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
            this.grid_NV = new System.Windows.Forms.DataGridView();
            this.btn_KhoiPhuc = new System.Windows.Forms.Button();
            this.textBox_TimNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_NV)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_NV
            // 
            this.grid_NV.BackgroundColor = System.Drawing.Color.White;
            this.grid_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_NV.Location = new System.Drawing.Point(22, 357);
            this.grid_NV.Name = "grid_NV";
            this.grid_NV.RowHeadersWidth = 82;
            this.grid_NV.RowTemplate.Height = 33;
            this.grid_NV.Size = new System.Drawing.Size(1058, 960);
            this.grid_NV.TabIndex = 17;
            // 
            // btn_KhoiPhuc
            // 
            this.btn_KhoiPhuc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_KhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btn_KhoiPhuc.Location = new System.Drawing.Point(692, 219);
            this.btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            this.btn_KhoiPhuc.Size = new System.Drawing.Size(171, 101);
            this.btn_KhoiPhuc.TabIndex = 16;
            this.btn_KhoiPhuc.Text = "Khôi phục";
            this.btn_KhoiPhuc.UseVisualStyleBackColor = false;
            this.btn_KhoiPhuc.Click += new System.EventHandler(this.btn_KhoiPhuc_Click);
            // 
            // textBox_TimNV
            // 
            this.textBox_TimNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TimNV.Location = new System.Drawing.Point(371, 139);
            this.textBox_TimNV.Name = "textBox_TimNV";
            this.textBox_TimNV.Size = new System.Drawing.Size(492, 56);
            this.textBox_TimNV.TabIndex = 14;
            this.textBox_TimNV.TextChanged += new System.EventHandler(this.textBox_TimNV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(168, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 51);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 63);
            this.label1.TabIndex = 12;
            this.label1.Text = "KHÔI PHỤC NHÂN VIÊN";
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reload.Image = global::SieuThiMini.Properties.Resources.refresh;
            this.btn_Reload.Location = new System.Drawing.Point(371, 219);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(145, 101);
            this.btn_Reload.TabIndex = 15;
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // KhoiPhucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1103, 1331);
            this.Controls.Add(this.grid_NV);
            this.Controls.Add(this.btn_KhoiPhuc);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.textBox_TimNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KhoiPhucNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KhoiPhucNhanVien";
            this.Load += new System.EventHandler(this.KhoiPhucNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_NV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_NV;
        private System.Windows.Forms.Button btn_KhoiPhuc;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.TextBox textBox_TimNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}