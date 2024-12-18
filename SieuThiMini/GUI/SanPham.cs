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
    public partial class SanPham : Form
    {
        //private readonly SanPhamBLL spBLL = new SanPhamBLL();

        public SanPham()
        {
            InitializeComponent();
            LoadLoaiSanPham();
        }

        private void LoadLoaiSanPham()
        {
            var collection = DataProvider.Instance.GetCollection("loai_san_pham");
            var loaiSanPhamList = collection.Find(Builders<BsonDocument>.Filter.Empty).ToList();

            cb_MaLoai.Items.Clear();
            foreach (var loai in loaiSanPhamList)
            {
                cb_MaLoai.Items.Add(loai["ma_loai"].AsInt32);
            }
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            SanPhamBLL spBLL = new SanPhamBLL();
            var listSP = spBLL.GetList();
            grid_SanPham.DataSource = listSP;

            grid_SanPham.Columns["Id"].Visible = false;
            grid_SanPham.Columns["TrangThai"].Visible = false;

            grid_SanPham.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
            grid_SanPham.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            grid_SanPham.Columns["MaLoai"].HeaderText = "Mã loại";
            grid_SanPham.Columns["SoLuong"].HeaderText = "Số lượng";
            grid_SanPham.Columns["Gia"].HeaderText = "Giá";
            grid_SanPham.Columns["GiaNhap"].HeaderText = "Giá nhập";

            grid_SanPham.Columns["MaSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_SanPham.Columns["TenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_SanPham.Columns["MaLoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_SanPham.Columns["SoLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_SanPham.Columns["Gia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_SanPham.Columns["GiaNhap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (grid_SanPham.Rows.Count > 0)
            {
                var dataGridViewArgs = new DataGridViewCellEventArgs(0, 0);
                grid_SanPham_CellClick(null, dataGridViewArgs);
            }
        }

        private void grid_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = grid_SanPham.Rows[e.RowIndex];
            textBox_MaSP.Text = row.Cells["MaSanPham"].Value.ToString();
            cb_MaLoai.Text = row.Cells["MaLoai"].Value.ToString();
            textBox_TenSanPham.Text = row.Cells["TenSanPham"].Value.ToString();
            textBox_SoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            textBox_Gia.Text = row.Cells["Gia"].Value.ToString();
            textBox_GiaNhap.Text = row.Cells["GiaNhap"].Value.ToString();

            ToggleInputFields(false);
        }

        private void ToggleInputFields(bool isEnabled)
        {
            textBox_MaSP.Enabled = isEnabled;
            cb_MaLoai.Enabled = isEnabled;
            textBox_TenSanPham.Enabled = isEnabled;
            textBox_SoLuong.Enabled = isEnabled;
            textBox_Gia.Enabled = isEnabled;
            textBox_GiaNhap.Enabled = isEnabled;

            btn_Save.Visible = isEnabled;
            btn_Huy.Visible = isEnabled;
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            ThemSanPham themSP = new ThemSanPham();
            themSP.ShowDialog();
            LoadDataGrid();
        }

        private void btn_SuaSanPham_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_MaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ToggleInputFields(true);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SanPhamBLL spBLL = new SanPhamBLL();
            if (ValidateInputs())
            {
                int maSP = int.Parse(textBox_MaSP.Text);
                string tenSP = textBox_TenSanPham.Text;
                int maLoai = int.Parse(cb_MaLoai.Text);
                int soLuong = int.Parse(textBox_SoLuong.Text);
                int gia = int.Parse(textBox_Gia.Text);
                int giaNhap = int.Parse(textBox_GiaNhap.Text);

                var spDTO = new SanPhamDTO(maSP, tenSP, soLuong, gia, giaNhap, maLoai, 1);
                spBLL.Update(spDTO);

                MessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGrid();
                ToggleInputFields(false);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBox_TenSanPham.Text) ||
                string.IsNullOrWhiteSpace(cb_MaLoai.Text) ||
                string.IsNullOrWhiteSpace(textBox_Gia.Text) ||
                string.IsNullOrWhiteSpace(textBox_GiaNhap.Text) ||
                string.IsNullOrWhiteSpace(textBox_SoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (int.Parse(textBox_Gia.Text) <= 0 || int.Parse(textBox_GiaNhap.Text) <= 0)
            {
                MessageBox.Show("Giá bán và giá nhập phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            var dataGridViewArgs = new DataGridViewCellEventArgs(0, grid_SanPham.CurrentRow?.Index ?? 0);
            grid_SanPham_CellClick(null, dataGridViewArgs);
        }

        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            SanPhamBLL spBLL = new SanPhamBLL();
            if (string.IsNullOrWhiteSpace(textBox_MaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maSP = int.Parse(textBox_MaSP.Text);
            int soLuong = int.Parse(textBox_SoLuong.Text);

            if (soLuong == 0)
            {
                spBLL.Delete(maSP);
                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Không thể xóa sản phẩm vì vẫn còn hàng trong kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_TimSanPham_TextChanged(object sender, EventArgs e)
        {
            SanPhamBLL spBLL = new SanPhamBLL();
            string keyword = textBox_TimSanPham.Text.ToLower();
            var listSP = spBLL.TimKiem(keyword);
            grid_SanPham.DataSource = listSP;
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            KhoiPhucSanPham kpsp = new KhoiPhucSanPham();
            kpsp.ShowDialog();
            LoadDataGrid();
        }
    }
}