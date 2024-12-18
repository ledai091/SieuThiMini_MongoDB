using SieuThiMini.BLL;
using SieuThiMini.DAL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class KhoiPhucLoaiSanPham : Form
    {
        private LoaiSanPhamBLL bll = new LoaiSanPhamBLL();
        private List<LoaiSanPhamDTO> loaiSanPhamList;

        public KhoiPhucLoaiSanPham()
        {
            InitializeComponent();
        }

        private void KhoiPhucLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadDeletedLoaiSanPham();
        }

        private void LoadDeletedLoaiSanPham()
        {
            loaiSanPhamList = bll.GetListDeleted();
            grid_LoaiSanPham.DataSource = loaiSanPhamList;

            grid_LoaiSanPham.Columns["MaLoai"].HeaderText = "Mã Loại";
            grid_LoaiSanPham.Columns["MaNhaCungCap"].HeaderText = "Mã Nhà Cung Cấp";
            grid_LoaiSanPham.Columns["TenLoai"].HeaderText = "Tên Loại";

            grid_LoaiSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LoaiSanPham.Columns["MaLoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LoaiSanPham.Columns["MaNhaCungCap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LoaiSanPham.Columns["TenLoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_LoaiSanPham.Columns["MaLoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_LoaiSanPham.Columns["MaNhaCungCap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_LoaiSanPham.Columns["TenLoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Ẩn các cột không cần thiết
            grid_LoaiSanPham.Columns["TrangThai"].Visible = true;
            grid_LoaiSanPham.Columns["Id"].Visible = false;
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadDeletedLoaiSanPham();
        }

        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            if (grid_LoaiSanPham.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = grid_LoaiSanPham.SelectedRows[0];
                // Ensure the Id column exists and has a value
                if (selectedRow.Cells["MaLoai"] == null || selectedRow.Cells["MaLoai"].Value == null)
                {
                    MessageBox.Show("No Id found for the selected row.");
                    return;
                }

                int id = Convert.ToInt32(selectedRow.Cells["MaLoai"].Value);
                bll.Restore(id);

                MessageBox.Show("Khôi phục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDeletedLoaiSanPham();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần khôi phục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox_TimLoaiSanPham_TextChanged(object sender, EventArgs e)
        {
            string query = textBox_TimLoaiSanPham.Text;
            if (!string.IsNullOrEmpty(query))
            {
                loaiSanPhamList = bll.TimKiemDeleted(query);
                grid_LoaiSanPham.DataSource = loaiSanPhamList;
            }
            else
            {
                LoadDeletedLoaiSanPham();
            }
        }
    }
}