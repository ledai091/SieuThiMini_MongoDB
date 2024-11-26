using SieuThiMini.BLL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class KhoiPhucNhanVien : Form
    {
        private NhanVienBLL nvBLL;

        public KhoiPhucNhanVien()
        {
            InitializeComponent();
            nvBLL = new NhanVienBLL();
        }

        private void KhoiPhucNhanVien_Load(object sender, EventArgs e)
        {
            LoadDeletedNhanVien();
        }

        private void LoadDeletedNhanVien()
        {
            // Lấy danh sách nhân viên đã bị xóa (trang_thai = 0) và hiển thị lên DataGridView
            List<NhanVienDTO> list = nvBLL.GetDeletedNhanVien();
            grid_NV.DataSource = list;

            // Tùy chỉnh tiêu đề cột và căn chỉnh
            grid_NV.Columns["Id"].HeaderText = "ID";
            grid_NV.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            grid_NV.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
            grid_NV.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            grid_NV.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            grid_NV.Columns["Email"].HeaderText = "Email";
            grid_NV.Columns["TaiKhoan"].HeaderText = "Mã Tài Khoản";
            grid_NV.Columns["TrangThai"].HeaderText = "Trạng Thái";

            grid_NV.Columns["Id"].Visible = false; // Ẩn cột ID nếu không cần hiển thị
            grid_NV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_NV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void textBox_TimNV_TextChanged(object sender, EventArgs e)
        {
            string query = textBox_TimNV.Text.Trim();

            if (!string.IsNullOrEmpty(query))
            {
                // Tìm kiếm nhân viên đã xóa dựa trên từ khóa nhập vào
                List<NhanVienDTO> filteredList = nvBLL.GetDeletedNhanVienByKey(query);
                grid_NV.DataSource = filteredList;
            }
            else
            {
                // Nếu không nhập từ khóa, tải lại danh sách toàn bộ nhân viên đã xóa
                LoadDeletedNhanVien();
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            // Reload lại danh sách nhân viên đã xóa
            LoadDeletedNhanVien();
        }

        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            if (grid_NV.SelectedRows.Count > 0)
            {
                // Lấy ID nhân viên được chọn để khôi phục
                string selectedId = grid_NV.SelectedRows[0].Cells["Id"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn khôi phục nhân viên này?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Thực hiện khôi phục nhân viên
                    nvBLL.Restore(selectedId);
                    MessageBox.Show("Khôi phục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại danh sách nhân viên đã xóa sau khi khôi phục
                    LoadDeletedNhanVien();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần khôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}