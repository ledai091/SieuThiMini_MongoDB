using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using SieuThiMini.BLL;
using SieuThiMini.DAL;
using SieuThiMini.DTO;

namespace SieuThiMini.GUI
{
    public partial class ThemSanPham : Form
    {
        private readonly SanPhamBLL sanPhamBLL = new SanPhamBLL();

        public ThemSanPham()
        {
            InitializeComponent();
            LoadLoaiSanPham();
        }

        private void LoadLoaiSanPham()
        {
            // Lấy danh sách loại sản phẩm từ MongoDB
            var collection = DataProvider.Instance.GetCollection("loai_san_pham");
            var loaiSanPhamList = collection.Find(FilterDefinition<BsonDocument>.Empty).ToList();

            // Xóa và thêm lại các mục vào ComboBox
            cb_MaLoai.Items.Clear();
            cb_MaLoai.Items.Add("Chọn loại sản phẩm");
            foreach (var loai in loaiSanPhamList)
            {
                cb_MaLoai.Items.Add($"{loai["ma_loai"]}: {loai["ten_loai"]}");
            }

            cb_MaLoai.SelectedIndex = 0;
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            List<SanPhamDTO> listDTO = sanPhamBLL.GetList();
            string tenSP = textBox_TenSanPham.Text.Trim();
            string giaStr = textBox_Gia.Text.Trim();
            string giaNhapStr = textBox_GiaNhap.Text.Trim();
            int soLuong = 1;

            if (cb_MaLoai.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tenSP) || string.IsNullOrWhiteSpace(giaStr) || string.IsNullOrWhiteSpace(giaNhapStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(giaStr, out int gia) || !int.TryParse(giaNhapStr, out int giaNhap) || gia <= 0 || giaNhap <= 0)
            {
                MessageBox.Show("Giá và giá nhập phải là số nguyên lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã loại sản phẩm từ ComboBox
            string selectedLoai = cb_MaLoai.SelectedItem.ToString();
            int maLoai = int.Parse(selectedLoai.Split(':')[0].Trim());

            var sanPham = new SanPhamDTO(
                listDTO.Count + 1,           // maSanPham, giá trị mặc định là 0 (MongoDB sẽ tự sinh ID)
                tenSP,       // tenSanPham
                soLuong,     // soLuong
                gia,         // gia
                giaNhap,     // giaNhap
                maLoai,      // maLoai
                1          // trangThai (mặc định là "1" - hoạt động)
            );

            try
            {
                sanPhamBLL.Insert(sanPham);
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi thêm sản phẩm:\n{ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemSanPham_Load(object sender, EventArgs e)
        {
            // Nếu cần thiết, bạn có thể thêm logic khởi tạo ở đây
        }
    }
}
