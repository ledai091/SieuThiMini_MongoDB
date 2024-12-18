using SieuThiMini.BLL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class CTDonNhapHang : Form
    {
        private int maDonNhapHang;

        public CTDonNhapHang(int ma)
        {
            InitializeComponent();
            this.maDonNhapHang = ma;
        }

        private void CTDonNhapHang_Load(object sender, EventArgs e)
        {
            DonNhapHangBLL donNhapHangBLL = new DonNhapHangBLL();
            DonNhapHangDTO donNhapHangDTO = donNhapHangBLL.GetDNHByMaDNH(maDonNhapHang);

            display_Time.Text = donNhapHangDTO.NgayNhap.ToString();
            display_MaDNH.Text = donNhapHangDTO.MaDonNhapHang.ToString();
            display_MaNV.Text = donNhapHangDTO.MaNhanVien.ToString();

            grid_CTDNH.Columns.Add("ten_san_pham", "Tên sản phẩm");
            this.Controls.Add(grid_CTDNH);

            CTDonNhapHangBLL bll = new CTDonNhapHangBLL();

            List<CTDonNhapHangDTO> cTDonNhapHangDTOs = bll.GetCTDNHByMaDNH(Convert.ToInt32(maDonNhapHang));
            DataTable dt = new DataTable();
            dt.Columns.Add("ten_san_pham", typeof(string));
            dt.Columns.Add("so_luong", typeof(string));
            dt.Columns.Add("gia", typeof(string));
            dt.Columns.Add("thanh_tien", typeof(double));

            dt.Columns["ten_san_pham"].ColumnName = "Tên sản phẩm";
            dt.Columns["so_luong"].ColumnName = "Số lượng";
            dt.Columns["gia"].ColumnName = "Giá tiền";
            dt.Columns["thanh_tien"].ColumnName = "Thành tiền";
            grid_CTDNH.DataSource = dt;

            grid_CTDNH.Columns["Tên sản phẩm"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_CTDNH.Columns["Số lượng"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_CTDNH.Columns["Giá tiền"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_CTDNH.Columns["Thành tiền"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grid_CTDNH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_CTDNH.Columns["Tên sản phẩm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_CTDNH.Columns["Số lượng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_CTDNH.Columns["Giá tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_CTDNH.Columns["Thành tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        

            double tongTien = 0;
            int mhd = 0;

            foreach (var ctdnh in cTDonNhapHangDTOs)
            {
                dt.Rows.Add(ctdnh.TenSanPham, ctdnh.SoLuong, ctdnh.Gia, ctdnh.ThanhTien);
                tongTien += ctdnh.ThanhTien;
                mhd = ctdnh.MaDonNhapHang;
            }
            display_MaDNH.Text = mhd.ToString();
            dt.Rows.Add("Tổng tiền", "", "", tongTien);
            grid_CTDNH.Columns.Remove("ten_san_pham");
            grid_CTDNH.DataSource = dt;
        }
    }
}
