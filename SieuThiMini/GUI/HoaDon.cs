using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SieuThiMini.BLL;
using SieuThiMini.DTO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
namespace SieuThiMini.GUI
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            HoaDonBLL hdBLL = new HoaDonBLL();
            List<HoaDonDTO> dsHD = hdBLL.GetList();

            grid_DSHoaDon.DataSource = dsHD;
            grid_DSHoaDon.Columns["Id"].Visible = false;

            grid_DSHoaDon.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
            grid_DSHoaDon.Columns["NgayXuat"].HeaderText = "Ngày xuất";
            grid_DSHoaDon.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            grid_DSHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";
            grid_DSHoaDon.Columns["TrangThai"].HeaderText = "Trạng thái";

            grid_DSHoaDon.Columns["MaHoaDon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSHoaDon.Columns["NgayXuat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSHoaDon.Columns["MaNhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSHoaDon.Columns["TongTien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSHoaDon.Columns["TrangThai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "DanhSachHoaDon.xlsx";
            saveFileDialog.Title = "Chọn nơi lưu file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                IWorkbook workbook = new XSSFWorkbook();
                ISheet sheet = workbook.CreateSheet("Sheet1");
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn col in grid_DSHoaDon.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }
                foreach (DataGridViewRow row in grid_DSHoaDon.Rows)
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
                using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(stream);
                }
                MessageBox.Show("Dữ liệu đã được xuất ra tệp Excel và lưu tại đường dẫn: " + filePath);
            }
        }

        private void pick_DateStart_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDateStart = pick_DateStart.Value;
            DateTime selectedDateEnd = pick_DateEnd.Value;
            DateTime currentDate = DateTime.Now;
            if (selectedDateStart > currentDate)
            {
                MessageBox.Show("Ngày không thể lớn hơn ngày hiện tại.");
                pick_DateStart.Value = currentDate;
                return;
            }
            text_DateStart.Text = selectedDateStart.ToShortDateString();
        }

        private void pick_DateEnd_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDateStart = pick_DateStart.Value;
            DateTime selectedDateEnd = pick_DateEnd.Value;
            DateTime currentDate = DateTime.Now;

            if (selectedDateEnd > currentDate)
            {
                MessageBox.Show("Ngày không thể lớn hơn ngày hiện tại.");
                pick_DateEnd.Value = currentDate;
            }
            else if (selectedDateStart > selectedDateEnd)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.");
                pick_DateEnd.Value = currentDate;
            }
            else if (text_DateStart.Text == "" || text_DateStart.Text.Contains(" "))
            {
                MessageBox.Show("Hãy chọn ngày bắt đầu trước.");
            }
            else
            {
                text_DateEnd.Text = selectedDateEnd.ToShortDateString();
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            HoaDonBLL hdBLL = new HoaDonBLL();
            List<HoaDonDTO> dsHD = hdBLL.GetList();
            grid_DSHoaDon.DataSource = dsHD;
            text_DateStart.Text = "";
            text_DateEnd.Text = "";
        }

        private void textFind_TextChanged(object sender, EventArgs e)
        {
            string searchText = textFind.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText) )
            {
                HoaDonBLL hdBLL = new HoaDonBLL();
                List<HoaDonDTO> dshd = hdBLL.GetList();
                grid_DSHoaDon.DataSource = dshd;
            }
            else
            {
                HoaDonBLL hdBLL = new HoaDonBLL();
                List<HoaDonDTO> dsHD = hdBLL.GetList();

                var filterdRows = dsHD.AsEnumerable()
                    .Where(row => row.MaHoaDon.ToString().ToLower().Contains(searchText)
                    || row.MaNhanVien.ToString().ToLower().Contains(searchText)
                    || row.TongTien.ToString().ToLower().Contains(searchText)).ToList();

                grid_DSHoaDon.DataSource = filterdRows;
            }
        }

        private void findDate_Click(object sender, EventArgs e)
        {
            DateTime dateStart = pick_DateStart.Value.Date;
            DateTime dateEnd = pick_DateEnd.Value.Date;
            HoaDonBLL hdBLL = new HoaDonBLL();
            List<HoaDonDTO> dsHD = hdBLL.GetList();

            if(dateStart < dateEnd)
            {
                var filterdRows = dsHD
                    .Where(row => row.NgayXuat.Date >= dateStart && row.NgayXuat.Date <= dateEnd).ToList();
                grid_DSHoaDon.DataSource = filterdRows;
            }
            else
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu.");
                grid_DSHoaDon.DataSource = dsHD;
                text_DateStart.Text = "";
                text_DateEnd.Text = "";
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            KhoiPhucHoaDon kpHD = new KhoiPhucHoaDon();
            kpHD.ShowDialog();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (grid_DSHoaDon.SelectedRows.Count > 0)
            {
                int selectedRowIndex = grid_DSHoaDon.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_DSHoaDon.Rows[selectedRowIndex];
                string maHD = selectedRow.Cells["MaHoaDon"].Value.ToString();

                HoaDonBLL hdBLL = new HoaDonBLL();
                hdBLL.Delete(maHD);
                List<HoaDonDTO> dsHD = hdBLL.GetList();
                grid_DSHoaDon.DataSource = dsHD;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi xem thông tin.");
            }
        }

        private void btn_ViewDetails_Click(object sender, EventArgs e)
        {
            if (grid_DSHoaDon.SelectedRows.Count > 0)
            {
                int selectedRowIndex = grid_DSHoaDon.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_DSHoaDon.Rows[selectedRowIndex];
                int maHD = Convert.ToInt32(selectedRow.Cells["MaHoaDon"].Value.ToString());
                ChiTietHoaDon formChiTiet = new ChiTietHoaDon(maHD);
                formChiTiet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi xem thông tin.");
            }
        }
    }
}
