using SieuThiMini.BLL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;

namespace SieuThiMini.GUI
{
    public partial class ChiTietHoaDon : Form
    {
        private int maHD;
        private string maNV;
        private CTHoaDonBLL cthdBLL;
        public ChiTietHoaDon(int maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
            this.cthdBLL = new CTHoaDonBLL();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            HoaDonBLL hdBLL = new HoaDonBLL();
            HoaDonDTO hd = hdBLL.GetHDByMaHD(maHD);

            display_Time.Text = hd.NgayXuat.ToString();
            display_MaNV.Text = hd.MaNhanVien.ToString();

            grid_CTHD.Columns.Add("ten_san_pham", "Tên sản phẩm");
            this.Controls.Add(grid_CTHD);

            List<CTHoaDonDTO> cthdList = cthdBLL.GetCTHDByMaHD(maHD);

            DataTable dt = new DataTable();
            dt.Columns.Add("ten_san_pham", typeof(string));
            dt.Columns.Add("so_luong", typeof(string));
            dt.Columns.Add("gia_san_pham", typeof(string));
            dt.Columns.Add("thanh_tien", typeof(int));

            dt.Columns["ten_san_pham"].ColumnName = "Tên sản phẩm";
            dt.Columns["so_luong"].ColumnName = "Số lượng";
            dt.Columns["gia_san_pham"].ColumnName = "Giá sản phẩm";
            dt.Columns["thanh_tien"].ColumnName = "Thành tiền";

            double tongTien = 0;
            int mhd = 0;
            foreach(var cthd in cthdList)
            {
                dt.Rows.Add(cthd.TenSanPham, cthd.SoLuong, cthd.GiaSanPham, cthd.ThanhTien);
                tongTien += cthd.ThanhTien;
                mhd = cthd.MaHoaDon;
            }
            display_MaHD.Text = mhd.ToString();
            dt.Rows.Add("Tổng tiền", "", "", tongTien);
            grid_CTHD.Columns.Remove("ten_san_pham");
            grid_CTHD.DataSource = dt;

            grid_CTHD.Columns["Tên sản phẩm"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_CTHD.Columns["Số lượng"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_CTHD.Columns["Giá sản phẩm"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_CTHD.Columns["Thành tiền"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grid_CTHD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_CTHD.Columns["Tên sản phẩm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_CTHD.Columns["Số lượng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_CTHD.Columns["Giá sản phẩm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_CTHD.Columns["Thành tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 20);
            XFont fontTitle = new XFont("Arial bold", 14);
            XFont fontHeader = new XFont("Arial bold", 16);

            int y = 50, x = 100;
            gfx.DrawString("HOÁ ĐƠN BÁN HÀNG", fontHeader, XBrushes.Black, new XRect(0, y, page.Width, page.Height), XStringFormats.TopCenter);
            y += 50;
            gfx.DrawString($"Ngày xuất: {display_Time.Text}", font, XBrushes.Black, new XRect(x, y, page.Width, page.Height), XStringFormats.TopLeft);
            y += 50;
            gfx.DrawString($"Mã hoá đơn: {display_MaHD.Text}", font, XBrushes.Black, new XRect(x, y, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Mã nhân viên: {display_MaNV.Text}", font, XBrushes.Black, new XRect(x + 50, y, page.Width, page.Height), XStringFormats.TopCenter);
            y += 50;

            int tableX = x;
            int tableY = y;
            int cellWidth = 100;
            int cellHeight = 20;
            int numRows = grid_CTHD.Rows.Count;
            int numCols = 4;

            gfx.DrawRectangle(XPens.Black, tableX, tableY, cellWidth * numCols, cellHeight);
            gfx.DrawString("Tên sản phẩm", fontTitle, XBrushes.Black, new XRect(tableX, tableY, cellWidth, cellHeight), XStringFormats.Center);
            gfx.DrawString("Số lượng", fontTitle, XBrushes.Black, new XRect(tableX + cellWidth, tableY, cellWidth, cellHeight), XStringFormats.Center);
            gfx.DrawString("Giá sản phẩm", fontTitle, XBrushes.Black, new XRect(tableX + cellWidth * 2, tableY, cellWidth, cellHeight), XStringFormats.Center);
            gfx.DrawString("Thành tiền", fontTitle, XBrushes.Black, new XRect(tableX + cellWidth * 3, tableY, cellWidth, cellHeight), XStringFormats.Center);

            for (int rowIdx = 0; rowIdx < numRows; rowIdx++)
            {
                y += cellHeight;
                tableY += cellHeight;
                gfx.DrawRectangle(XPens.Black, tableX, tableY, cellWidth * numCols, cellHeight);
                for (int colIdx = 0; colIdx < numCols; colIdx++)
                {
                    var cell = grid_CTHD.Rows[rowIdx].Cells[colIdx];
                    string cellValue = cell?.Value?.ToString() ?? "N/A";
                    gfx.DrawString(cellValue, font, XBrushes.Black, new XRect(tableX + cellWidth * colIdx, tableY, cellWidth, cellHeight), XStringFormats.Center);
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                doc.Save(filePath);
                Process.Start(filePath);
            }
        }
    }
}
