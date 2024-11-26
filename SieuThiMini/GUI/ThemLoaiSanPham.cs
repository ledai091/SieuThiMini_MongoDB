using SieuThiMini.BLL;
using SieuThiMini.DTO;
using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using SieuThiMini.DAL;

namespace SieuThiMini.GUI
{
    public partial class ThemLoaiSanPham : Form
    {
        private readonly LoaiSanPhamBLL loaiSanPhamBLL = new LoaiSanPhamBLL();

        public ThemLoaiSanPham()
        {
            InitializeComponent();
            LoadNhaCungCap();
        }

        private void LoadNhaCungCap()
        {
            var collection = DataProvider.Instance.GetCollection("nha_cung_cap");
            var nhaCungCapList = collection.Find(Builders<BsonDocument>.Filter.Empty).ToList();

            cb_MaNCC.Items.Clear();
            cb_MaNCC.Items.Add("Chọn nhà cung cấp");

            foreach (var ncc in nhaCungCapList)
            {
                cb_MaNCC.Items.Add($"{ncc["ma_ncc"]}: {ncc["ten_ncc"]}");
            }

            cb_MaNCC.SelectedIndex = 0;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThemLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (cb_MaNCC.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedNCC = cb_MaNCC.SelectedItem.ToString();
            int maNCC = int.Parse(selectedNCC.Split(':')[0].Trim());
            string tenLoai = textBox_TenLoaiSanPham.Text;

            if (string.IsNullOrWhiteSpace(tenLoai))
            {
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var loaiSanPham = new LoaiSanPhamDTO(0, tenLoai, maNCC, 1);
            loaiSanPhamBLL.Insert(loaiSanPham);

            MessageBox.Show("Thêm loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}