using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using SieuThiMini.BLL;
using SieuThiMini.DTO;
namespace SieuThiMini.GUI
{
    public partial class DonNhapHang : Form
    {
        public DonNhapHang()
        {
            InitializeComponent();
        }

        private void DonNhapHang_Load(object sender, EventArgs e)
        {
            DonNhapHangBLL bll = new DonNhapHangBLL();
            List<DonNhapHangDTO> ds = bll.GetList();

            grid_DSDonNhapHang.DataSource = ds;
            grid_DSDonNhapHang.Columns["Id"].Visible = false;

            grid_DSDonNhapHang.Columns["MaDonNhapHang"].HeaderText = "Mã Đơn Nhập";
            grid_DSDonNhapHang.Columns["MaNhaCungCap"].HeaderText = "Mã Nhà Cung Cấp";
            grid_DSDonNhapHang.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            grid_DSDonNhapHang.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
            grid_DSDonNhapHang.Columns["TongTienNhap"].HeaderText = "Tổng Tiền Nhập";
            grid_DSDonNhapHang.Columns["TrangThai"].HeaderText = "Trạng Thái";

            grid_DSDonNhapHang.Columns["MaDonNhapHang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSDonNhapHang.Columns["MaNhaCungCap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSDonNhapHang.Columns["MaNhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSDonNhapHang.Columns["NgayNhap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSDonNhapHang.Columns["TongTienNhap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSDonNhapHang.Columns["TrangThai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int maNV = 4;
            ThemDonNhapHang them = new ThemDonNhapHang(maNV);
            them.ShowDialog();
        }

        private void textFind_TextChanged(object sender, EventArgs e)
        {
            string searchText = textFind.Text.Trim().ToLower();
            DonNhapHangBLL bll = new DonNhapHangBLL();
            List<DonNhapHangDTO> ds = bll.GetList();
            if (string.IsNullOrEmpty(searchText))
            {
                grid_DSDonNhapHang.DataSource = ds;
            }
            else
            {
                var filteredRows = ds.AsEnumerable()
                    .Where(row => row.MaDonNhapHang.ToString().ToLower().Contains(searchText)
                    || row.MaNhaCungCap.ToString().ToLower().Contains(searchText)).ToList();
                grid_DSDonNhapHang.DataSource = filteredRows;
            }
        }
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            DonNhapHang_Load(null, null);
        }

        private void btn_ViewDetails_Click(object sender, EventArgs e)
        {
            if (grid_DSDonNhapHang.SelectedRows.Count > 0)
            {
                int selectedRowIndex = grid_DSDonNhapHang.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_DSDonNhapHang.Rows[selectedRowIndex];
                int maDonNhap = Convert.ToInt32(selectedRow.Cells["MaDonNhapHang"].Value);
                CTDonNhapHang ct = new CTDonNhapHang(maDonNhap);
                ct.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi xem thông tin.");
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Chọn nơi lưu tệp Excel.";
            saveFileDialog.FileName = "DanhSachDonNhapHang.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                IWorkbook workbook = new XSSFWorkbook();
                ISheet sheet = workbook.CreateSheet("Sheet1");

                DataTable dt = new DataTable();

                foreach (DataGridViewColumn col in grid_DSDonNhapHang.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in grid_DSDonNhapHang.Rows)
                {
                    DataRow dRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dRow);
                }

                IRow headerRow = sheet.CreateRow(0);
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    headerRow.CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    IRow excelRow = sheet.CreateRow(i + 1);
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        excelRow.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());
                    }
                }
                using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(file);
                }
                MessageBox.Show("Dữ liệu đã được xuất ra tệp Excel và lưu tại đường dẫn: " + filePath);
            }
        }

        private void findDate_Click(object sender, EventArgs e)
        {
            DateTime dateStart = pick_DateStart.Value;
            DateTime dateEnd = pick_DateEnd.Value;

            DonNhapHangBLL bll = new DonNhapHangBLL();
            List<DonNhapHangDTO> ds = bll.GetList();

            if (dateStart < dateEnd)
            {
                var filteredRows = ds.AsEnumerable()
                                 .Where(row => row.NgayNhap.Date >= dateStart && row.NgayNhap.Date <= dateEnd).ToList();
                grid_DSDonNhapHang.DataSource = filteredRows;
            }
            else
            {
                MessageBox.Show("Không hợp lệ");
                grid_DSDonNhapHang.DataSource = grid_DSDonNhapHang;
                text_DateStart.Text = "";
                text_DateEnd.Text = "";
            }
        }

        private void pick_DateStart_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDateStart = pick_DateStart.Value;
            DateTime currentDate = DateTime.Now;

            if (selectedDateStart > currentDate)
            {
                MessageBox.Show("Vui lòng chọn ngày không lớn hơn ngày hiện tại.");
                pick_DateStart.Value = currentDate;
            }
            else
            {
                text_DateStart.Text = selectedDateStart.ToShortDateString();
            }
        }

        private void pick_DateEnd_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDateStart = pick_DateStart.Value;
            DateTime selectedDateEnd = pick_DateEnd.Value;
            DateTime currentDate = DateTime.Now;

            if (selectedDateEnd > currentDate)
            {
                MessageBox.Show("Vui lòng chọn ngày không lớn hơn ngày hiện tại.");
                pick_DateEnd.Value = currentDate;
            }
            else if (selectedDateEnd < selectedDateStart)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.");
                pick_DateEnd.Value = selectedDateStart;
            }
            else
            {
                text_DateEnd.Text = selectedDateEnd.ToShortDateString();
            }
        }


        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if(grid_DSDonNhapHang.SelectedRows.Count > 0)
            {
                int selectedRowIndex = grid_DSDonNhapHang.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_DSDonNhapHang.Rows[selectedRowIndex];
                int maDonNhap = Convert.ToInt32(selectedRow.Cells["MaDonNhapHang"].Value);
                DonNhapHangBLL bll = new DonNhapHangBLL();
                bll.Delete(maDonNhap);
                MessageBox.Show("Xóa thành công");
                List<DonNhapHangDTO> ds = bll.GetList();
                grid_DSDonNhapHang.DataSource = ds;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi xem thông tin.");
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            KhoiPhucDonNhapHang khoiPhucDonNhapHang = new KhoiPhucDonNhapHang();
            khoiPhucDonNhapHang.ShowDialog();
        }
    }
}
