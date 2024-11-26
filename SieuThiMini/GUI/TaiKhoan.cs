using MongoDB.Bson;
using MongoDB.Driver;
using SieuThiMini.BLL;
using SieuThiMini.DAL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class TaiKhoan : Form
    {
        private readonly TaiKhoanBLL tkBLL = new TaiKhoanBLL();

        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void LoadPhanQuyen()
        {
            var collection = DataProvider.Instance.GetCollection("phan_quyen");
            var phanQuyenList = collection.Find(Builders<BsonDocument>.Filter.Empty).ToList();

            cb_PhanQuyen.Items.Clear();
            foreach (var quyen in phanQuyenList)
            {
                cb_PhanQuyen.Items.Add(Convert.ToInt32(quyen["ma_quyen"]));
            }
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            LoadPhanQuyen();
        }

        private void LoadDataGrid()
        {
            var listTK = tkBLL.SelectAll();
            grid_TK.DataSource = listTK;

            grid_TK.Columns["Id"].Visible = false;

            grid_TK.Columns["MaTaiKhoan"].HeaderText = "Mã tài khoản";
            grid_TK.Columns["TenTaiKhoan"].HeaderText = "Tên tài khoản";
            grid_TK.Columns["MatKhau"].HeaderText = "Mật khẩu";
            grid_TK.Columns["PhanQuyen"].HeaderText = "Phân quyền";

            grid_TK.Columns["MaTaiKhoan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_TK.Columns["TenTaiKhoan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_TK.Columns["MatKhau"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_TK.Columns["PhanQuyen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grid_TK.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TK.Columns["MaTaiKhoan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TK.Columns["MatKhau"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TK.Columns["PhanQuyen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (grid_TK.Rows.Count > 0)
            {
                var dataGridViewArgs = new DataGridViewCellEventArgs(0, 0);
                grid_TK_CellClick(null, dataGridViewArgs);
            }
        }

        private void grid_TK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = grid_TK.Rows[e.RowIndex];
            textBox_MaTK.Text = row.Cells["MaTaiKhoan"].Value.ToString();
            textBox_TenTK.Text = row.Cells["TenTaiKhoan"].Value.ToString();
            textBox_MK.Text = row.Cells["MatKhau"].Value.ToString();
            cb_PhanQuyen.Text = row.Cells["PhanQuyen"].Value.ToString();

            ToggleInputFields(false);
        }

        private void ToggleInputFields(bool isEnabled)
        {
            textBox_TenTK.Enabled = isEnabled;
            textBox_MK.Enabled = isEnabled;
            cb_PhanQuyen.Enabled = isEnabled;

            btn_Save.Visible = isEnabled;
            btn_Huy.Visible = isEnabled;
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadPhanQuyen();
            LoadDataGrid();
        }

        private void btn_ThemTK_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan themTK = new ThemTaiKhoan();
            themTK.ShowDialog();
            LoadDataGrid();
        }

        private void btn_SuaTK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_MaTK.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ToggleInputFields(true);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int maTK = int.Parse(textBox_MaTK.Text);
                string tenTK = textBox_TenTK.Text;
                string matKhau = textBox_MK.Text;
                int phanQuyen = int.Parse(cb_PhanQuyen.Text);

                var tkDTO = new TaiKhoanDTO(maTK, tenTK, matKhau, phanQuyen, 1);
                tkBLL.Update(tkDTO);

                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGrid();
                ToggleInputFields(false);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBox_TenTK.Text) ||
                string.IsNullOrWhiteSpace(textBox_MK.Text) ||
                string.IsNullOrWhiteSpace(cb_PhanQuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            var dataGridViewArgs = new DataGridViewCellEventArgs(0, grid_TK.CurrentRow?.Index ?? 0);
            grid_TK_CellClick(null, dataGridViewArgs);
        }

        private void btn_XoaTK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_MaTK.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maTK = int.Parse(textBox_MaTK.Text);
            if (maTK != 1) // Không xóa tài khoản admin
            {
                tkBLL.Delete(maTK);
                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Không thể xóa tài khoản này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            KhoiPhucTaiKhoan kpTK = new KhoiPhucTaiKhoan();
            kpTK.ShowDialog();
            LoadDataGrid();
        }

        private void textBox_TimTK_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox_TimTK.Text.ToLower();
            var listTK = tkBLL.TimKiem(keyword);
            grid_TK.DataSource = listTK;
        }
    }
}