using System;
using System.Data;
using System.Windows.Forms;
using SieuThiMini.BLL;

namespace SieuThiMini.GUI
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            ThongKeBLL tkBLL = new ThongKeBLL();

            // Load initial data
            TongSP.Text = tkBLL.TongSoSanPham().ToString();
            SoNhaCC.Text = tkBLL.SoLuongNCC().ToString();
            TongNV.Text = tkBLL.SoLuongNV().ToString();
            SoTaiKhoan.Text = tkBLL.SoTaiKhoan().ToString();

            textBox_Year.Text = DateTime.Now.Year.ToString();

            // Populate comboBox with months
            comboBox1.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox1.SelectedIndex = 0; // Default selection
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            // Additional setup on form load if needed
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            ThongKeBLL thongKeBLL = new ThongKeBLL();
            int namHienTai = DateTime.Now.Year;
            int selectedMonth;
            int selectedYear;
            DataTable result;

            // Validate year input
            if (string.IsNullOrWhiteSpace(textBox_Year.Text.Trim()))
            {
                textBox_Year.Text = namHienTai.ToString();
                selectedYear = namHienTai;
            }
            else if (!int.TryParse(textBox_Year.Text.Trim(), out selectedYear) || selectedYear < 2000 || selectedYear > namHienTai)
            {
                MessageBox.Show("Vui lòng nhập năm hợp lệ (từ 2000 đến năm hiện tại).");
                textBox_Year.Text = namHienTai.ToString();
                return;
            }

            // Validate month selection
            if (comboBox1.SelectedItem == null || !int.TryParse(comboBox1.SelectedItem.ToString().Trim(), out selectedMonth))
            {
                MessageBox.Show("Vui lòng chọn tháng hợp lệ.");
                return;
            }

            if (selectedMonth == 0)
            {
                // Statistics for the whole year
                So_Von.Text = thongKeBLL.TongChiPhiNhapHangTheoNam(selectedYear).ToString("N0") + " đồng";
                So_DoanhThu.Text = thongKeBLL.TongDoanhThuTheoNam(selectedYear).ToString("N0") + " đồng";

                lbl_TKDonNhapHang.Text = thongKeBLL.TongDonNHTheoNam(selectedYear).ToString();
                lb_Sodonnhaphang.Text = thongKeBLL.TongHoaDonTheoNam(selectedYear).ToString();

                result = thongKeBLL.TimMaNVCoTongTienLonNhatTheoNam(selectedYear);
            }
            else
            {
                // Statistics for the specific month
                So_Von.Text = thongKeBLL.TongChiPhiNhapHangTheoThang(selectedMonth, selectedYear).ToString("N0") + " đồng";
                So_DoanhThu.Text = thongKeBLL.TongDoanhThuTheoThang(selectedMonth, selectedYear).ToString("N0") + " đồng";

                lbl_TKDonNhapHang.Text = thongKeBLL.TongDonNHTheoThang(selectedMonth, selectedYear).ToString();
                lb_Sodonnhaphang.Text = thongKeBLL.TongHoaDonTheoThang(selectedMonth, selectedYear).ToString();

                result = thongKeBLL.TimMaNVCoTongTienLonNhatTheoThang(selectedMonth, selectedYear);
            }

            // Update employee information
            if (result != null && result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                string maNhanVien = row["_id"].ToString();
                string tenNhanVien = row["ten_nhan_vien"].ToString();
                string tongTienLonNhat = row["TongTienLonNhat"].ToString();

                label_MaNV.Text = maNhanVien;
                label_TenNV.Text = tenNhanVien;
                label_TongTienNV.Text = tongTienLonNhat + " đồng";
            }
            else
            {
                label_MaNV.Text = "...";
                label_TenNV.Text = "...";
                label_TongTienNV.Text = "...";
            }
        }

        private void TongNV_Click(object sender, EventArgs e)
        {

        }
    }
}