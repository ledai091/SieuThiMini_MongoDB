using System;
using System.Linq;
using System.Windows.Forms;
using SieuThiMini.BLL;
using SieuThiMini.DTO;
using MongoDB.Driver;
using MongoDB.Bson;
using SieuThiMini.DAL;
using System.Collections.Generic;

namespace SieuThiMini.GUI
{
    public partial class ThemNhanVien : Form
    {

        public ThemNhanVien()
        {
            InitializeComponent();
            LoadTaiKhoan();
        }

        private void LoadTaiKhoan()
        {
            var collection = DataProvider.Instance.GetCollection("tai_khoan");
            var taiKhoanList = collection.Find(Builders<BsonDocument>.Filter.Eq("trang_thai", 1)).ToList();

            cb_TK.Items.Clear();
            cb_TK.Items.Add("Chọn tài khoản");
            foreach (var tk in taiKhoanList)
            {
                cb_TK.Items.Add($"{tk["ma_tai_khoan"]}: {tk["ten_tai_khoan"]}");
            }

            cb_TK.SelectedIndex = 0;
        }

        private bool IsNumeric(string value)
        {
            return value.All(char.IsDigit);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            string tenNV = textBox_TenNV.Text.Trim();
            string sdt = textBox_SDT.Text.Trim();
            string mail = textBox_Email.Text.Trim();
            DateTime birth = dateTimePicker_Birth.Value;

            if (cb_TK.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tenNV) || string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(mail))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsNumeric(sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedTK = cb_TK.SelectedItem.ToString();
            int maTK = int.Parse(selectedTK.Split(':')[0].Trim());
            List<NhanVienDTO> listDTO = nhanVienBLL.GetList();
            var nhanVien = new NhanVienDTO(
                listDTO.Count + 1, // Mã nhân viên được tự động sinh bởi MongoDB
                tenNV,
                birth,
                sdt,
                mail,
                maTK,
                1 // Mặc định trạng thái là "hoạt động"
            );


            try
            {
                nhanVienBLL.Insert(nhanVien);
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi thêm nhân viên:\n{ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_TK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
