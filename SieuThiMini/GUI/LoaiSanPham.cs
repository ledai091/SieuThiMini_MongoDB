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
    public partial class LoaiSanPham : Form
    {
        LoaiSanPhamBLL bll = new LoaiSanPhamBLL();
        public LoaiSanPham()
        {
            InitializeComponent();
            LoadComboBoxNCC();
        }

        private void LoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadComboBoxNCC()
        {
            var nccCollection = DataProvider.Instance.GetCollection("nha_cung_cap");
            var nhaCungCapList = nccCollection.Find(Builders<BsonDocument>.Filter.Empty).ToList();

            cb_MaNCC.Items.Clear();
            foreach (var ncc in nhaCungCapList)
            {
                cb_MaNCC.Items.Add(ncc["ma_ncc"]);
            }
        }

        private void LoadDataGrid()
        {
            List<LoaiSanPhamDTO> list = bll.GetList();
            grid_LoaiSanPham.DataSource = list;

            grid_LoaiSanPham.Columns["Id"].Visible = false;
            grid_LoaiSanPham.Columns["TrangThai"].Visible = false;

            grid_LoaiSanPham.Columns["MaLoai"].HeaderText = "Mã Loại";
            grid_LoaiSanPham.Columns["TenLoai"].HeaderText = "Tên Loại";
            grid_LoaiSanPham.Columns["MaNhaCungCap"].HeaderText = "Mã nhà cung cấp";

            grid_LoaiSanPham.Columns["MaLoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_LoaiSanPham.Columns["TenLoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_LoaiSanPham.Columns["MaNhaCungCap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void grid_LoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = grid_LoaiSanPham.Rows[e.RowIndex];
            textBox_MaLSP.Text = row.Cells["MaLoai"].Value.ToString();
            textBox_TenLoaiSanPham.Text = row.Cells["TenLoai"].Value.ToString();
            cb_MaNCC.Text = row.Cells["MaNhaCungCap"].Value.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_TenLoaiSanPham.Text) || string.IsNullOrWhiteSpace(cb_MaNCC.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maLoai = int.Parse(textBox_MaLSP.Text);
            string tenLoai = textBox_TenLoaiSanPham.Text;
            int maNCC = int.Parse(cb_MaNCC.Text);

            LoaiSanPhamDTO lsp = new LoaiSanPhamDTO(maLoai, tenLoai, maNCC, 1);
            bll.Update(lsp);

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGrid();
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            ThemLoaiSanPham themLSP = new ThemLoaiSanPham();
            themLSP.ShowDialog();
            LoadDataGrid();
        }

        private void btn_SuaSanPham_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_MaLSP.Text))
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBox_TenLoaiSanPham.Enabled = true;
            cb_MaNCC.Enabled = true;
            btn_Save.Visible = true;
        }

        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_MaLSP.Text))
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLoai = textBox_MaLSP.Text;
            bll.Delete(maLoai);

            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGrid();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void textBox_TimSanPham_TextChanged(object sender, EventArgs e)
        {
            string timKiem = textBox_TimSanPham.Text;
            List<LoaiSanPhamDTO> list = bll.TimKiem(timKiem);
            grid_LoaiSanPham.DataSource = list;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            int index = grid_LoaiSanPham.SelectedRows[0].Index;
            var dataGridViewArgs = new DataGridViewCellEventArgs(0, index);
            grid_LoaiSanPham_CellClick(sender, dataGridViewArgs);
        }

        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            KhoiPhucLoaiSanPham kp = new KhoiPhucLoaiSanPham();
            kp.ShowDialog();
        }
    }
}
