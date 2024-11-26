using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using SieuThiMini.BLL;
using SieuThiMini.DAL;
using SieuThiMini.DTO;

namespace SieuThiMini.GUI
{
    public partial class NhanVien : Form
    {
        private NhanVienBLL nvBLL = new NhanVienBLL();

        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadComboBoxTaiKhoan();
            LoadDataGrid();
        }

        private void LoadComboBoxTaiKhoan()
        {
            var collection = DataProvider.Instance.GetCollection("tai_khoan");
            var taiKhoanList = collection.Find(Builders<BsonDocument>.Filter.Eq("trang_thai", "1")).ToList();

            cb_TK.Items.Clear();
            foreach (var tk in taiKhoanList)
            {
                cb_TK.Items.Add(Convert.ToInt32(tk["ma_tai_khoan"]));
            }
        }

        private void LoadDataGrid()
        {
            var nhanVienList = nvBLL.GetList();
            grid_NV.DataSource = nhanVienList;

            grid_NV.Columns["Id"].Visible = false;
            grid_NV.Columns["TrangThai"].Visible = false;

            grid_NV.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            grid_NV.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            grid_NV.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            grid_NV.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            grid_NV.Columns["Email"].HeaderText = "Email";
            grid_NV.Columns["TaiKhoan"].HeaderText = "Mã tài khoản";

            grid_NV.Columns["MaNhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_NV.Columns["TenNhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_NV.Columns["NgaySinh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_NV.Columns["SoDienThoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_NV.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_NV.Columns["TaiKhoan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (grid_NV.Rows.Count > 0)
            {
                var dataGridViewArgs = new DataGridViewCellEventArgs(0, 0);
                grid_NV_CellClick(null, dataGridViewArgs);
            }
        }

        private void grid_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = grid_NV.Rows[e.RowIndex];

            textBox_MaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
            textBox_TenNV.Text = row.Cells["TenNhanVien"].Value.ToString();
            dateTimePicker_Birth.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            textBox_SDT.Text = row.Cells["SoDienThoai"].Value.ToString();
            textBox_Email.Text = row.Cells["Email"].Value.ToString();
            cb_TK.Text = row.Cells["TaiKhoan"].Value.ToString();

            ToggleInputFields(false);
        }

        private void ToggleInputFields(bool isEnabled)
        {
            textBox_TenNV.Enabled = isEnabled;
            dateTimePicker_Birth.Enabled = isEnabled;
            textBox_SDT.Enabled = isEnabled;
            textBox_Email.Enabled = isEnabled;
            cb_TK.Enabled = isEnabled;

            btn_Huy.Visible = isEnabled;
            btn_Save.Visible = isEnabled;
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            ThemNhanVien themNV = new ThemNhanVien();
            themNV.ShowDialog();
            LoadDataGrid();
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_MaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ToggleInputFields(true);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int maNV = int.Parse(textBox_MaNV.Text);
                string tenNV = textBox_TenNV.Text;
                DateTime ngaySinh = dateTimePicker_Birth.Value;
                string soDienThoai = textBox_SDT.Text;
                string email = textBox_Email.Text;
                int taiKhoan = int.Parse(cb_TK.Text);

                NhanVienDTO nhanVien = new NhanVienDTO(maNV, tenNV, ngaySinh, soDienThoai, email, taiKhoan, 1);

                nvBLL.Update(nhanVien);
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGrid();
                ToggleInputFields(false);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBox_TenNV.Text) ||
                string.IsNullOrWhiteSpace(textBox_SDT.Text) ||
                string.IsNullOrWhiteSpace(textBox_Email.Text) ||
                string.IsNullOrWhiteSpace(cb_TK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            var dataGridViewArgs = new DataGridViewCellEventArgs(0, grid_NV.CurrentRow?.Index ?? 0);
            grid_NV_CellClick(null, dataGridViewArgs);
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadComboBoxTaiKhoan();
            LoadDataGrid();
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_MaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maNV = int.Parse(textBox_MaNV.Text);
            if (cb_TK.Text == "0")
            {
                nvBLL.Delete(maNV.ToString());
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Nhân viên đang còn tài khoản sử dụng. Hãy chuyển tài khoản về mã '0' trước khi xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimKiem(object sender, EventArgs e)
        {
            string keyword = textBox_TimNV.Text.ToLower();
            var nhanVienList = nvBLL.GetList();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                nhanVienList = nhanVienList.FindAll(nv =>
                    nv.MaNhanVien.ToString().Contains(keyword) ||
                    nv.TenNhanVien.ToLower().Contains(keyword) ||
                    nv.Email.ToLower().Contains(keyword));
            }

            grid_NV.DataSource = nhanVienList;
        }
        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            KhoiPhucLoaiSanPham kplsp = new KhoiPhucLoaiSanPham();
            kplsp.ShowDialog();
        }
    }
}