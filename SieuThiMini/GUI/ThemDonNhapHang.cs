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
    public partial class ThemDonNhapHang : Form
    {
        private readonly SanPhamBLL sanPhamBLL = new SanPhamBLL();
        private readonly NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
        private readonly DonNhapHangBLL donNhapHangBLL = new DonNhapHangBLL();
        private readonly CTDonNhapHangBLL ctDonNhapHangBLL = new CTDonNhapHangBLL();
        private readonly int maNV;

        public ThemDonNhapHang(int maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }

        private void ThemDonNhapHang_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
            InitializeGridDonNhapHang();
        }

        private void LoadNhaCungCap()
        {
            cbo_NCC.Items.Clear();
            cbo_NCC.Items.Add(" ");
            cbo_NCC.SelectedIndex = 0;

            var collection = DataProvider.Instance.GetCollection("nha_cung_cap");
            var nccList = collection.Find(Builders<BsonDocument>.Filter.Empty).ToList();

            foreach (var ncc in nccList)
            {
                cbo_NCC.Items.Add(ncc["ten_ncc"].AsString);
            }
        }

        private void InitializeGridDonNhapHang()
        {
            grid_DonNhapHang.Columns.Clear();
            grid_DonNhapHang.Columns.Add("ma_san_pham", "Mã sản phẩm");
            grid_DonNhapHang.Columns.Add("ten_san_pham", "Tên sản phẩm");
            grid_DonNhapHang.Columns.Add("so_luong", "Số lượng");
            grid_DonNhapHang.Columns.Add("gia", "Giá");
            grid_DonNhapHang.Columns.Add("thanh_tien", "Thành tiền");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (grid_SanPham.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cbo_NCC.Enabled = false;
            var selectedRow = grid_SanPham.CurrentRow;

            int maSanPham = Convert.ToInt32(selectedRow.Cells["ma_san_pham"].Value);
            string tenSanPham = selectedRow.Cells["ten_san_pham"].Value.ToString();
            int soLuong = (int)ud_SoLuong.Value;
            decimal giaNhap = Convert.ToDecimal(selectedRow.Cells["gia_nhap"].Value);
            decimal thanhTien = soLuong * giaNhap;

            foreach (DataGridViewRow row in grid_DonNhapHang.Rows)
            {
                if (Convert.ToInt32(row.Cells["ma_san_pham"].Value) == maSanPham)
                {
                    row.Cells["so_luong"].Value = Convert.ToInt32(row.Cells["so_luong"].Value) + soLuong;
                    row.Cells["thanh_tien"].Value = Convert.ToDecimal(row.Cells["gia"].Value) * Convert.ToInt32(row.Cells["so_luong"].Value);
                    UpdateTotalPrice();
                    return;
                }
            }

            grid_DonNhapHang.Rows.Add(maSanPham, tenSanPham, soLuong, giaNhap, thanhTien);
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            decimal totalGia = grid_DonNhapHang.Rows.Cast<DataGridViewRow>()
                .Sum(row => Convert.ToDecimal(row.Cells["thanh_tien"].Value));
            label_TT.Text = totalGia.ToString("N0");
        }

        private void cbo_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_NCC.SelectedIndex == 0)
            {
                grid_SanPham.DataSource = new List<SanPhamDTO>();
                return;
            }

            string selectedNCC = cbo_NCC.SelectedItem.ToString();
            var nhaCungCap = nhaCungCapBLL.GetNCCByName(selectedNCC).FirstOrDefault();

            if (nhaCungCap != null)
            {
                var sanPhamList = sanPhamBLL.GetSPByLoaiSP(nhaCungCap.MaNhaCungCap);
                grid_SanPham.DataSource = sanPhamList;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (grid_DonNhapHang.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            grid_DonNhapHang.Rows.Remove(grid_DonNhapHang.CurrentRow);

            if (grid_DonNhapHang.Rows.Count == 0)
            {
                cbo_NCC.Enabled = true;
            }

            UpdateTotalPrice();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (grid_DonNhapHang.Rows.Count == 0)
            {
                MessageBox.Show("Chưa chọn sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbo_NCC.SelectedIndex == 0)
            {
                MessageBox.Show("Chưa chọn nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedNCC = cbo_NCC.SelectedItem.ToString();
            var nhaCungCap = nhaCungCapBLL.GetNCCByName(selectedNCC).FirstOrDefault();

            if (nhaCungCap == null)
            {
                MessageBox.Show("Nhà cung cấp không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngayNhap = DateTime.Now;
            decimal tongTien = decimal.Parse(label_TT.Text);
            var donNhapHang = new DonNhapHangDTO(0, nhaCungCap.MaNhaCungCap, maNV, ngayNhap, (int)tongTien, 1);
            donNhapHangBLL.Insert(donNhapHang);

            foreach (DataGridViewRow row in grid_DonNhapHang.Rows)
            {
                int maSP = Convert.ToInt32(row.Cells["ma_san_pham"].Value);
                string tenSP = row.Cells["ten_san_pham"].Value.ToString();
                int soLuong = Convert.ToInt32(row.Cells["so_luong"].Value);
                decimal gia = Convert.ToDecimal(row.Cells["gia"].Value);
                decimal thanhTien = Convert.ToDecimal(row.Cells["thanh_tien"].Value);

                var chiTietDonNhap = new CTDonNhapHangDTO(donNhapHang.MaDonNhapHang, maSP, tenSP, soLuong, (int)gia, (int)thanhTien);
                ctDonNhapHangBLL.Insert(chiTietDonNhap);

                var sanPham = sanPhamBLL.GetSPByMaSP(maSP);
                if (sanPham != null)
                {
                    sanPhamBLL.UpdateSoLuong(maSP, sanPham.SoLuong + soLuong);
                }
            }

            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grid_DonNhapHang.Rows.Clear();
            label_TT.Text = "0";
            cbo_NCC.Enabled = true;
        }
        private void grid_DonNhapHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == grid_DonNhapHang.Columns["thanh_tien"].Index)
            {
                decimal totalGia = 0;
                foreach (DataGridViewRow dr in grid_DonNhapHang.Rows)
                {
                    totalGia += Convert.ToDecimal(dr.Cells["thanh_tien"].Value);
                }
                label_TT.Text = totalGia.ToString();
            }
        }
    }
}
