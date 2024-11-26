using SieuThiMini.BLL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class KhoiPhucHoaDon : Form
    {
        public KhoiPhucHoaDon()
        {
            InitializeComponent();
        }

        private void KhoiPhucHoaDon_Load(object sender, EventArgs e)
        {
            HoaDonBLL hoaDonBLL = new HoaDonBLL();
            List<HoaDonDTO> danhSachHoaDon = hoaDonBLL.GetListDeleted();

            grid_DSHDXoa.DataSource = danhSachHoaDon;
            grid_DSHDXoa.Columns["ma_hoa_don"].HeaderText = "Mã Hóa Đơn";
            grid_DSHDXoa.Columns["ngay_xuat"].HeaderText = "Ngày Xuất";
            grid_DSHDXoa.Columns["ma_nhan_vien"].HeaderText = "Mã Nhân Viên";
            grid_DSHDXoa.Columns["tong_tien"].HeaderText = "Tổng Tiền";
            grid_DSHDXoa.Columns["trang_thai"].HeaderText = "Trạng Thái";

            grid_DSHDXoa.Columns["ma_hoa_don"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSHDXoa.Columns["ngay_xuat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSHDXoa.Columns["ma_nhan_vien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSHDXoa.Columns["tong_tien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSHDXoa.Columns["trang_thai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            if (grid_DSHDXoa.SelectedRows.Count > 0)
            {
                int selectedRowIndex = grid_DSHDXoa.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_DSHDXoa.Rows[selectedRowIndex];
                string maHoaDon = selectedRow.Cells["ma_hoa_don"].Value.ToString();
                HoaDonBLL hoadon = new HoaDonBLL();
                hoadon.Restore(maHoaDon);

                HoaDonBLL hd = new HoaDonBLL();
                List<HoaDonDTO> danhSachHoaDon = hd.GetListDeleted();

                grid_DSHDXoa.DataSource = danhSachHoaDon;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi xem thông tin.");
            }
        }

        private void textFind_TextChanged(object sender, EventArgs e)
        {
            string searchText = textFind.Text.Trim().ToLower(); // Lấy nội dung của TextBox và chuyển về chữ thường

            if (string.IsNullOrEmpty(searchText))
            {

                HoaDonBLL hoaDonBLL = new HoaDonBLL();

                // Gọi phương thức để lấy danh sách hóa đơn từ BLL
                List<HoaDonDTO> danhSachHoaDon = hoaDonBLL.GetListDeleted();

                // Đặt nguồn dữ liệu cho DataGridView
                grid_DSHDXoa.DataSource = danhSachHoaDon;
            }
            else
            {
                HoaDonBLL hoaDonBLL = new HoaDonBLL();

                // Gọi phương thức để lấy danh sách hóa đơn từ BLL
                List<HoaDonDTO> danhSachHoaDon = hoaDonBLL.GetListDeleted();

                // Đặt nguồn dữ liệu cho DataGridView

                // Nếu TextBox có nội dung, tìm kiếm và lọc dữ liệu dựa trên nội dung
                var filteredRows = danhSachHoaDon.AsEnumerable()
                    .Where(row => row.MaHoaDon.ToString().ToLower().Contains(searchText)
                    || row.MaNhanVien.ToString().ToLower().Contains(searchText)
                    || row.TongTien.ToString().ToLower().Contains(searchText))
                    .ToList();

                grid_DSHDXoa.DataSource = filteredRows;
            }
        }
    }
}
