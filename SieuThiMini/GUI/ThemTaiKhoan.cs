using SieuThiMini.BLL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class ThemTaiKhoan : Form
    {

        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void ThemTaiKhoan_Load(object sender, EventArgs e)
        {
            // Load danh sách phân quyền
            try
            {
                List<int> danhSachQuyen = new List<int> { 1, 2, 3 }; // Giả sử các quyền là 1, 2, 3
                cb_PhanQuyen.DataSource = danhSachQuyen;
                cb_PhanQuyen.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi tải phân quyền: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ThemTK_Click(object sender, EventArgs e)
        {
            TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
            string tenTaiKhoan = textBox_TenTK.Text.Trim();
            string matKhau = textBox_MK.Text.Trim();
            int phanQuyen;

            // Kiểm tra đầu vào
            if (string.IsNullOrWhiteSpace(tenTaiKhoan) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cb_PhanQuyen.SelectedItem.ToString(), out phanQuyen))
            {
                MessageBox.Show("Phân quyền không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<TaiKhoanDTO> taiKhoanDTOs = taiKhoanBLL.SelectAll();
            // Tạo đối tượng TaiKhoanDTO
            var taiKhoan = new TaiKhoanDTO(
                taiKhoanDTOs.Count + 1,                  // ma_tai_khoan 
                tenTaiKhoan,        // ten_tai_khoan
                matKhau,            // mat_khau
                phanQuyen,          // phan_quyen
                1                   // trang_thai (hoạt động)
            );

            try
            {
                // Gọi BLL để thêm tài khoản
                taiKhoanBLL.Insert(taiKhoan);
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi thêm tài khoản: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}