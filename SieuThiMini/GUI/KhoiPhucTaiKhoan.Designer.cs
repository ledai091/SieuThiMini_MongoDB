namespace SieuThiMini.GUI
{
    partial class KhoiPhucTaiKhoan
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
            this.grid_TK = new System.Windows.Forms.DataGridView();
            this.btn_KhoiPhuc = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.textBox_TimTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TK)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_TK
            // 
            this.grid_TK.BackgroundColor = System.Drawing.Color.White;
            this.grid_TK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_TK.Location = new System.Drawing.Point(22, 351);
            this.grid_TK.Name = "grid_TK";
            this.grid_TK.RowHeadersWidth = 82;
            this.grid_TK.RowTemplate.Height = 33;
            this.grid_TK.Size = new System.Drawing.Size(1058, 960);
            this.grid_TK.TabIndex = 11;
            // 
            // btn_KhoiPhuc
            // 
            this.btn_KhoiPhuc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_KhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btn_KhoiPhuc.Location = new System.Drawing.Point(692, 213);
            this.btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            this.btn_KhoiPhuc.Size = new System.Drawing.Size(171, 101);
            this.btn_KhoiPhuc.TabIndex = 10;
            this.btn_KhoiPhuc.Text = "Khôi phục";
            this.btn_KhoiPhuc.UseVisualStyleBackColor = false;
            this.btn_KhoiPhuc.Click += new System.EventHandler(this.btn_KhoiPhuc_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reload.Image = global::SieuThiMini.Properties.Resources.refresh;
            this.btn_Reload.Location = new System.Drawing.Point(371, 213);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(145, 101);
            this.btn_Reload.TabIndex = 9;
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // textBox_TimTK
            // 
            this.textBox_TimTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TimTK.Location = new System.Drawing.Point(371, 133);
            this.textBox_TimTK.Name = "textBox_TimTK";
            this.textBox_TimTK.Size = new System.Drawing.Size(492, 56);
            this.textBox_TimTK.TabIndex = 8;
            this.textBox_TimTK.TextChanged += new System.EventHandler(this.textBox_TimTK_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(168, 138);
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
            this.label1.Location = new System.Drawing.Point(224, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 63);
            this.label1.TabIndex = 6;
            this.label1.Text = "KHÔI PHỤC TÀI KHOẢN";
            // 
            // KhoiPhucTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1102, 1324);
            this.Controls.Add(this.grid_TK);
            this.Controls.Add(this.btn_KhoiPhuc);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.textBox_TimTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KhoiPhucTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KhoiPhucTaiKhoan";
            this.Load += new System.EventHandler(this.KhoiPhucTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_TK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_TK;
        private System.Windows.Forms.Button btn_KhoiPhuc;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.TextBox textBox_TimTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}