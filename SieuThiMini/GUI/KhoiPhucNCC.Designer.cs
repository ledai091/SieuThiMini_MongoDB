namespace SieuThiMini.GUI
{
    partial class KhoiPhucNCC
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
            this.grid_NCC = new System.Windows.Forms.DataGridView();
            this.btn_KhoiPhuc = new System.Windows.Forms.Button();
            this.textBox_TimNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_NCC)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_NCC
            // 
            this.grid_NCC.BackgroundColor = System.Drawing.Color.White;
            this.grid_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_NCC.Location = new System.Drawing.Point(12, 365);
            this.grid_NCC.Name = "grid_NCC";
            this.grid_NCC.RowHeadersWidth = 82;
            this.grid_NCC.RowTemplate.Height = 33;
            this.grid_NCC.Size = new System.Drawing.Size(1058, 960);
            this.grid_NCC.TabIndex = 11;
            // 
            // btn_KhoiPhuc
            // 
            this.btn_KhoiPhuc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_KhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btn_KhoiPhuc.Location = new System.Drawing.Point(682, 227);
            this.btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            this.btn_KhoiPhuc.Size = new System.Drawing.Size(171, 101);
            this.btn_KhoiPhuc.TabIndex = 10;
            this.btn_KhoiPhuc.Text = "Khôi phục";
            this.btn_KhoiPhuc.UseVisualStyleBackColor = false;
            this.btn_KhoiPhuc.Click += new System.EventHandler(this.btn_KhoiPhuc_Click);
            // 
            // textBox_TimNCC
            // 
            this.textBox_TimNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TimNCC.Location = new System.Drawing.Point(361, 147);
            this.textBox_TimNCC.Name = "textBox_TimNCC";
            this.textBox_TimNCC.Size = new System.Drawing.Size(492, 56);
            this.textBox_TimNCC.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(158, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(992, 63);
            this.label1.TabIndex = 6;
            this.label1.Text = "DANH SÁCH NHÀ CUNG CẤP BỊ XOÁ";
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reload.Image = global::SieuThiMini.Properties.Resources.refresh;
            this.btn_Reload.Location = new System.Drawing.Point(361, 227);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(145, 101);
            this.btn_Reload.TabIndex = 9;
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // KhoiPhucNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1082, 1348);
            this.Controls.Add(this.grid_NCC);
            this.Controls.Add(this.btn_KhoiPhuc);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.textBox_TimNCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KhoiPhucNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KhoiPhucNCC";
            this.Load += new System.EventHandler(this.KhoiPhucNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_NCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_NCC;
        private System.Windows.Forms.Button btn_KhoiPhuc;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.TextBox textBox_TimNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}