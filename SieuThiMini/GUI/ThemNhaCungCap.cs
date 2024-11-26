using System;
using System.Windows.Forms;
using SieuThiMini.BLL;
using SieuThiMini.DTO;

namespace SieuThiMini.GUI
{
    public partial class ThemNhaCungCap : Form
    {
        private readonly NhaCungCapBLL nccBLL = new NhaCungCapBLL();

        public ThemNhaCungCap()
        {
            InitializeComponent();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThemNCC_Click(object sender, EventArgs e)
        {
            string tenNCC = textBox_NCC.Text.Trim();
            string diaChi = textBox_DiaChi.Text.Trim();
            int trangThai = 1; // Mặc định trạng thái là '1' (hoạt động)

            if (string.IsNullOrWhiteSpace(tenNCC) || string.IsNullOrWhiteSpace(diaChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng nhà cung cấp mới
            var ncc = new NhaCungCapDTO
            {
                MaNhaCungCap = 0, // Mã nhà cung cấp được tự động sinh trong MongoDB
                TenNhaCungCap = tenNCC,
                DiaChi = diaChi,
                TrangThai = trangThai
            };

            try
            {
                nccBLL.Insert(ncc);
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi thêm nhà cung cấp:\n{ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThemNhaCungCap_Load(object sender, EventArgs e)
        {
            // Nếu cần thiết, có thể thêm logic khởi tạo ở đây
        }

    }
}
