using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SieuThiMini.BLL;
using SieuThiMini.DTO;
namespace SieuThiMini.GUI
{
    public partial class KhoiPhucDonNhapHang : Form
    {
        public KhoiPhucDonNhapHang()
        {
            InitializeComponent();
        }

        private void textFind_TextChanged(object sender, EventArgs e)
        {
            string searchText = textFind.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                DonNhapHangBLL bll = new DonNhapHangBLL();
                List<DonNhapHangDTO> ds = bll.GetListDeleted();
                grid_DNHDeleted.DataSource = ds;
            }
            else
            {
                DonNhapHangBLL bll = new DonNhapHangBLL();
                List<DonNhapHangDTO> ds = bll.GetList();
                List<DonNhapHangDTO> result = new List<DonNhapHangDTO>();
                foreach (DonNhapHangDTO item in ds)
                {
                    if (item.MaDonNhapHang.ToString().Contains(searchText) || item.MaNhaCungCap.ToString().Contains(searchText) || item.MaNhanVien.ToString().Contains(searchText) || item.NgayNhap.ToString().Contains(searchText) || item.TongTienNhap.ToString().Contains(searchText) || item.TrangThai.ToString().Contains(searchText))
                    {
                        result.Add(item);
                    }
                }
                grid_DNHDeleted.DataSource = result;

            }
        }

        private void KhoiPhucDonNhapHang_Load(object sender, EventArgs e)
        {
            DonNhapHangBLL donNhapHangBLL = new DonNhapHangBLL();
            List<DonNhapHangDTO> danhSachDonNhapHang = donNhapHangBLL.GetListDeleted();

            grid_DNHDeleted.DataSource = danhSachDonNhapHang;

            grid_DNHDeleted.Columns["MaDonNhapHang"].HeaderText = "Mã Đơn Nhập";
            grid_DNHDeleted.Columns["MaNhaCungCap"].HeaderText = "Mã Nhà Cung Cấp";
            grid_DNHDeleted.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            grid_DNHDeleted.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
            grid_DNHDeleted.Columns["TongTienNhap"].HeaderText = "Tổng Tiền Nhập";
            grid_DNHDeleted.Columns["TrangThai"].HeaderText = "Trạng Thái";

            grid_DNHDeleted.Columns["MaDonNhapHang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DNHDeleted.Columns["MaNhaCungCap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DNHDeleted.Columns["MaNhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DNHDeleted.Columns["NgayNhap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DNHDeleted.Columns["TongTienNhap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DNHDeleted.Columns["TrangThai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DNHDeleted.Columns["Id"].Visible = false;

        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            if(grid_DNHDeleted.SelectedRows.Count > 0)
            {
                int selectedRowIndex = grid_DNHDeleted.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_DNHDeleted.Rows[selectedRowIndex];
                int maDNH = Convert.ToInt32(selectedRow.Cells["MaDonNhapHang"].Value.ToString());
                DonNhapHangBLL donNhapHangBLL = new DonNhapHangBLL();
                donNhapHangBLL.Restore(maDNH);

                List<DonNhapHangDTO> ds = donNhapHangBLL.GetListDeleted();
                grid_DNHDeleted.DataSource = ds;
            }
        }
    }
}
