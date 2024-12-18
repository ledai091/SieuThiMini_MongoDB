using SieuThiMini.BLL;
using SieuThiMini.DAL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            NhaCungCapBLL bll = new NhaCungCapBLL();
            List<NhaCungCapDTO> nhaCungCapDTOs = bll.SelectAll();
            grid_NCC.DataSource = nhaCungCapDTOs;

            grid_NCC.Columns["TrangThai"].Visible = false;
            grid_NCC.Columns["Id"].Visible = false;

            grid_NCC.Columns["MaNhaCungCap"].HeaderText = "Mã nhà cung cấp";
            grid_NCC.Columns["TenNhaCungCap"].HeaderText = "Tên nhà cung cấp";
            grid_NCC.Columns["DiaChi"].HeaderText = "Địa chỉ";

            grid_NCC.Columns["MaNhaCungCap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_NCC.Columns["TenNhaCungCap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_NCC.Columns["DiaChi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (grid_NCC.Rows.Count > 0)
            {
                var dataGridViewArgs = new DataGridViewCellEventArgs(0, 0);
                grid_NCC_CellClick(null, dataGridViewArgs);
            }
        }

        private void grid_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = grid_NCC.Rows[e.RowIndex];
            textBox_MaNCC.Text = row.Cells["MaNhaCungCap"].Value.ToString();
            textBox_NCC.Text = row.Cells["TenNhaCungCap"].Value.ToString();
            textBox_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();

            textBox_MaNCC.Enabled = false;
            textBox_NCC.Enabled = false;
            textBox_DiaChi.Enabled = false;
            btn_Save.Visible = false;
            btn_Huy.Visible = false;
        }

        private void btn_ThemNCC_Click(object sender, EventArgs e)
        {
            ThemNhaCungCap them = new ThemNhaCungCap();
            them.ShowDialog();
            LoadDataGrid();
        }

        private void btn_SuaNCC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_MaNCC.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBox_NCC.Enabled = true;
            textBox_DiaChi.Enabled = true;
            btn_Huy.Visible = true;
            btn_Save.Visible = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            NhaCungCapBLL bll = new NhaCungCapBLL();
            if (string.IsNullOrWhiteSpace(textBox_NCC.Text) || string.IsNullOrWhiteSpace(textBox_DiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maNCC = int.Parse(textBox_MaNCC.Text);
            string tenNCC = textBox_NCC.Text;
            string diaChi = textBox_DiaChi.Text;

            NhaCungCapDTO ncc = new NhaCungCapDTO
            {
                MaNhaCungCap = maNCC,
                TenNhaCungCap = tenNCC,
                DiaChi = diaChi,
                TrangThai = 1
            };

            bll.Update(ncc);

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGrid();

            textBox_NCC.Enabled = false;
            textBox_DiaChi.Enabled = false;
            btn_Huy.Visible = false;
            btn_Save.Visible = false;
        }

        private void btn_XoaNCC_Click(object sender, EventArgs e)
        {
            NhaCungCapBLL bll = new NhaCungCapBLL();
            if (string.IsNullOrWhiteSpace(textBox_MaNCC.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maNCC = Convert.ToInt32(textBox_MaNCC.Text);

            List<LoaiSanPhamDTO> list = new LoaiSanPhamBLL().GetLSPByNCC(maNCC);

            if (list.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhà cung cấp này vì có loại sản phẩm liên quan!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bll.Delete(maNCC);
            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGrid();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            var dataGridViewArgs = new DataGridViewCellEventArgs(0, grid_NCC.CurrentRow?.Index ?? 0);
            grid_NCC_CellClick(null, dataGridViewArgs);
        }

        private void textBox_TimNCC_TextChanged(object sender, EventArgs e)
        {
            NhaCungCapBLL bll = new NhaCungCapBLL();
            string search = textBox_TimNCC.Text.ToLower();

            List<NhaCungCapDTO> nhaCungCapDTOs = bll.SelectAll();

            if (!string.IsNullOrWhiteSpace(search))
            {
                nhaCungCapDTOs = nhaCungCapDTOs.FindAll(ncc =>
                    ncc.MaNhaCungCap.ToString().ToLower().Contains(search) ||
                    ncc.TenNhaCungCap.ToLower().Contains(search) ||
                    ncc.DiaChi.ToLower().Contains(search));
            }

            grid_NCC.DataSource = nhaCungCapDTOs;
        }
        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            KhoiPhucNCC khoiPhucNCC = new KhoiPhucNCC();
            khoiPhucNCC.ShowDialog();
        }
    }
}
