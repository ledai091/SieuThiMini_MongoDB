using SieuThiMini.DAL;
using MongoDB.Bson;
using System.Data;

namespace SieuThiMini.BLL
{
    class ThongKeBLL
    {
        private readonly ThongKeDAL dal;

        public ThongKeBLL()
        {
            dal = new ThongKeDAL();
        }

        public int TongDoanhThuCacHoaDon()
        {
            return dal.TongDoanhThuCacHoaDon();
        }

        public int TongDoanhThuTheoNam(int selectedYear)
        {
            return dal.TongDoanhThuTheoNam(selectedYear);
        }

        public int TongDoanhThuTheoThang(int selectedMonth, int selectedYear)
        {
            return dal.TongDoanhThuTheoThang(selectedMonth, selectedYear);
        }

        public int TongHoaDon()
        {
            return dal.TongHoaDon();
        }

        public int TongHoaDonTheoNam(int selectedYear)
        {
            return dal.TongHoaDonTheoNam(selectedYear);
        }

        public int TongHoaDonTheoThang(int selectedMonth, int selectedYear)
        {
            return dal.TongHoaDonTheoThang(selectedMonth, selectedYear);
        }

        public int TongDonNH()
        {
            return dal.TongDonNH();
        }

        public int TongDonNHTheoNam(int selectedYear)
        {
            return dal.TongDonNHTheoNam(selectedYear);
        }

        public int TongDonNHTheoThang(int selectedMonth, int selectedYear)
        {
            return dal.TongDonNHTheoThang(selectedMonth, selectedYear);
        }

        public int TongChiPhiNhapHang()
        {
            return dal.TongChiPhiNhapHang();
        }

        public int TongChiPhiNhapHangTheoNam(int selectedYear)
        {
            return dal.TongChiPhiNhapHangTheoNam(selectedYear);
        }

        public int TongChiPhiNhapHangTheoThang(int selectedMonth, int selectedYear)
        {
            return dal.TongChiPhiNhapHangTheoThang(selectedMonth, selectedYear);
        }

        public int TongSoSanPham()
        {
            return dal.TongSoSanPham();
        }

        public int SoTaiKhoan()
        {
            return dal.SoTaiKhoan();
        }

        public int SoLuongNCC()
        {
            return dal.SoLuongNCC();
        }

        public int SoLuongNV()
        {
            return dal.SoLuongNV();
        }

        public DataTable TimMaNVCoTongTienLonNhatTheoNam(int selectedYear)
        {
            return dal.TimMaNVCoTongTienLonNhatTheoNam(selectedYear);
        }

        public DataTable TimMaNVCoTongTienLonNhatTheoThang(int selectedMonth, int selectedYear)
        {
            return dal.TimMaNVCoTongTienLonNhatTheoThang(selectedMonth, selectedYear);
        }
    }
}