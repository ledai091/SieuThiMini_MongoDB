namespace SieuThiMini.GUI
{
    partial class DonNhapHang
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
            this.TimKiem = new System.Windows.Forms.GroupBox();
            this.textFind = new System.Windows.Forms.TextBox();
            this.Date_start = new System.Windows.Forms.GroupBox();
            this.pick_DateStart = new System.Windows.Forms.DateTimePicker();
            this.text_DateStart = new System.Windows.Forms.TextBox();
            this.Date_end = new System.Windows.Forms.GroupBox();
            this.pick_DateEnd = new System.Windows.Forms.DateTimePicker();
            this.text_DateEnd = new System.Windows.Forms.TextBox();
            this.grid_DSDonNhapHang = new System.Windows.Forms.DataGridView();
            this.DSHoaDon = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.btn_ViewDetails = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.findDate = new System.Windows.Forms.Button();
            this.TimKiem.SuspendLayout();
            this.Date_start.SuspendLayout();
            this.Date_end.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSDonNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // TimKiem
            // 
            this.TimKiem.BackColor = System.Drawing.Color.AliceBlue;
            this.TimKiem.CausesValidation = false;
            this.TimKiem.Controls.Add(this.textFind);
            this.TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiem.ForeColor = System.Drawing.Color.Black;
            this.TimKiem.Location = new System.Drawing.Point(94, 28);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(746, 104);
            this.TimKiem.TabIndex = 10;
            this.TimKiem.TabStop = false;
            this.TimKiem.Text = "Tìm kiếm";
            // 
            // textFind
            // 
            this.textFind.Location = new System.Drawing.Point(6, 43);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(734, 44);
            this.textFind.TabIndex = 0;
            this.textFind.TextChanged += new System.EventHandler(this.textFind_TextChanged);
            // 
            // Date_start
            // 
            this.Date_start.BackColor = System.Drawing.Color.AliceBlue;
            this.Date_start.CausesValidation = false;
            this.Date_start.Controls.Add(this.pick_DateStart);
            this.Date_start.Controls.Add(this.text_DateStart);
            this.Date_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_start.Location = new System.Drawing.Point(1023, 28);
            this.Date_start.Name = "Date_start";
            this.Date_start.Size = new System.Drawing.Size(404, 104);
            this.Date_start.TabIndex = 11;
            this.Date_start.TabStop = false;
            this.Date_start.Text = "Từ ngày";
            // 
            // pick_DateStart
            // 
            this.pick_DateStart.Location = new System.Drawing.Point(346, 43);
            this.pick_DateStart.Name = "pick_DateStart";
            this.pick_DateStart.Size = new System.Drawing.Size(52, 44);
            this.pick_DateStart.TabIndex = 1;
            this.pick_DateStart.ValueChanged += new System.EventHandler(this.pick_DateStart_ValueChanged);
            // 
            // text_DateStart
            // 
            this.text_DateStart.Location = new System.Drawing.Point(6, 43);
            this.text_DateStart.Name = "text_DateStart";
            this.text_DateStart.Size = new System.Drawing.Size(334, 44);
            this.text_DateStart.TabIndex = 0;
            // 
            // Date_end
            // 
            this.Date_end.BackColor = System.Drawing.Color.AliceBlue;
            this.Date_end.CausesValidation = false;
            this.Date_end.Controls.Add(this.pick_DateEnd);
            this.Date_end.Controls.Add(this.text_DateEnd);
            this.Date_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_end.Location = new System.Drawing.Point(1433, 28);
            this.Date_end.Name = "Date_end";
            this.Date_end.Size = new System.Drawing.Size(404, 104);
            this.Date_end.TabIndex = 12;
            this.Date_end.TabStop = false;
            this.Date_end.Text = "Đến ngày";
            // 
            // pick_DateEnd
            // 
            this.pick_DateEnd.Location = new System.Drawing.Point(346, 43);
            this.pick_DateEnd.Name = "pick_DateEnd";
            this.pick_DateEnd.Size = new System.Drawing.Size(52, 44);
            this.pick_DateEnd.TabIndex = 1;
            this.pick_DateEnd.ValueChanged += new System.EventHandler(this.pick_DateEnd_ValueChanged);
            // 
            // text_DateEnd
            // 
            this.text_DateEnd.Location = new System.Drawing.Point(6, 43);
            this.text_DateEnd.Name = "text_DateEnd";
            this.text_DateEnd.Size = new System.Drawing.Size(334, 44);
            this.text_DateEnd.TabIndex = 0;
            // 
            // grid_DSDonNhapHang
            // 
            this.grid_DSDonNhapHang.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_DSDonNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DSDonNhapHang.Location = new System.Drawing.Point(94, 262);
            this.grid_DSDonNhapHang.Name = "grid_DSDonNhapHang";
            this.grid_DSDonNhapHang.RowHeadersWidth = 82;
            this.grid_DSDonNhapHang.RowTemplate.Height = 33;
            this.grid_DSDonNhapHang.Size = new System.Drawing.Size(1880, 1072);
            this.grid_DSDonNhapHang.TabIndex = 19;
            // 
            // DSHoaDon
            // 
            this.DSHoaDon.DeleteCommand = null;
            this.DSHoaDon.InsertCommand = null;
            this.DSHoaDon.SelectCommand = null;
            this.DSHoaDon.UpdateCommand = null;
            // 
            // btn_Add
            // 
            this.btn_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Add.CausesValidation = false;
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.Image = global::SieuThiMini.Properties.Resources.them1;
            this.btn_Add.Location = new System.Drawing.Point(543, 169);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(66, 66);
            this.btn_Add.TabIndex = 20;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Remove.CausesValidation = false;
            this.btn_Remove.ForeColor = System.Drawing.Color.Black;
            this.btn_Remove.Image = global::SieuThiMini.Properties.Resources.bin;
            this.btn_Remove.Location = new System.Drawing.Point(774, 169);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(66, 66);
            this.btn_Remove.TabIndex = 18;
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Restore.CausesValidation = false;
            this.btn_Restore.ForeColor = System.Drawing.Color.Black;
            this.btn_Restore.Image = global::SieuThiMini.Properties.Resources.data_restore;
            this.btn_Restore.Location = new System.Drawing.Point(655, 169);
            this.btn_Restore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(66, 66);
            this.btn_Restore.TabIndex = 17;
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // btn_Excel
            // 
            this.btn_Excel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Excel.CausesValidation = false;
            this.btn_Excel.ForeColor = System.Drawing.Color.Black;
            this.btn_Excel.Image = global::SieuThiMini.Properties.Resources.excel;
            this.btn_Excel.Location = new System.Drawing.Point(433, 169);
            this.btn_Excel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(66, 66);
            this.btn_Excel.TabIndex = 16;
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_ViewDetails
            // 
            this.btn_ViewDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ViewDetails.CausesValidation = false;
            this.btn_ViewDetails.ForeColor = System.Drawing.Color.Black;
            this.btn_ViewDetails.Image = global::SieuThiMini.Properties.Resources.view_details;
            this.btn_ViewDetails.Location = new System.Drawing.Point(328, 169);
            this.btn_ViewDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ViewDetails.Name = "btn_ViewDetails";
            this.btn_ViewDetails.Size = new System.Drawing.Size(66, 66);
            this.btn_ViewDetails.TabIndex = 15;
            this.btn_ViewDetails.UseVisualStyleBackColor = true;
            this.btn_ViewDetails.Click += new System.EventHandler(this.btn_ViewDetails_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.CausesValidation = false;
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.ForeColor = System.Drawing.Color.Black;
            this.btn_Reload.Image = global::SieuThiMini.Properties.Resources.refresh;
            this.btn_Reload.Location = new System.Drawing.Point(94, 166);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(200, 66);
            this.btn_Reload.TabIndex = 14;
            this.btn_Reload.Text = "Tải lại";
            this.btn_Reload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // findDate
            // 
            this.findDate.CausesValidation = false;
            this.findDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findDate.ForeColor = System.Drawing.Color.Black;
            this.findDate.Image = global::SieuThiMini.Properties.Resources.find;
            this.findDate.Location = new System.Drawing.Point(1869, 28);
            this.findDate.Name = "findDate";
            this.findDate.Size = new System.Drawing.Size(106, 103);
            this.findDate.TabIndex = 13;
            this.findDate.UseVisualStyleBackColor = true;
            this.findDate.Click += new System.EventHandler(this.findDate_Click);
            // 
            // DonNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(2068, 1362);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.Date_start);
            this.Controls.Add(this.Date_end);
            this.Controls.Add(this.grid_DSDonNhapHang);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Restore);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.btn_ViewDetails);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.findDate);
            this.Name = "DonNhapHang";
            this.Text = "Đơn nhập hàng";
            this.Load += new System.EventHandler(this.DonNhapHang_Load);
            this.TimKiem.ResumeLayout(false);
            this.TimKiem.PerformLayout();
            this.Date_start.ResumeLayout(false);
            this.Date_start.PerformLayout();
            this.Date_end.ResumeLayout(false);
            this.Date_end.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSDonNhapHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TimKiem;
        private System.Windows.Forms.TextBox textFind;
        private System.Windows.Forms.GroupBox Date_start;
        private System.Windows.Forms.DateTimePicker pick_DateStart;
        private System.Windows.Forms.TextBox text_DateStart;
        private System.Windows.Forms.GroupBox Date_end;
        private System.Windows.Forms.DateTimePicker pick_DateEnd;
        private System.Windows.Forms.TextBox text_DateEnd;
        private System.Windows.Forms.DataGridView grid_DSDonNhapHang;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button btn_ViewDetails;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button findDate;
        private MySql.Data.MySqlClient.MySqlDataAdapter DSHoaDon;
        private System.Windows.Forms.Button btn_Add;
    }
}