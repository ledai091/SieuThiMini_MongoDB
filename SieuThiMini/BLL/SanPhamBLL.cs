using System.Collections.Generic;
using SieuThiMini.DTO;
using SieuThiMini.DAL;

namespace SieuThiMini.BLL
{
    class SanPhamBLL
    {
        private readonly SanPhamDAL dal;

        public SanPhamBLL()
        {
            dal = new SanPhamDAL();
        }

        public List<SanPhamDTO> GetList()
        {
            return dal.SelectAll();
        }

        public int Insert(SanPhamDTO dto)
        {
            return dal.Insert(dto);
        }

        public void Update(SanPhamDTO dto)
        {
            dal.Update(dto);
        }

        public void UpdateSoLuong(int ma_san_pham, int so_luong)
        {
            dal.UpdateSoLuong(ma_san_pham, so_luong);
        }

        public void Delete(int ma_san_pham)
        {
            dal.Delete(ma_san_pham);
        }

        public void Restore(int ma_san_pham)
        {
            dal.Restore(ma_san_pham);
        }

        public SanPhamDTO GetSPByMaSP(int ma)
        {
            var list = dal.GetSPByMaSP(ma);
            return list.Count > 0 ? list[0] : null;
        }

        public List<SanPhamDTO> GetSPByLoaiSP(int ma)
        {
            return dal.GetSPByLoaiSP(ma);
        }

        public List<SanPhamDTO> GetSPByNameSP(string name)
        {
            return dal.GetSPByNameSP(name);
        }

        public List<SanPhamDTO> TimKiem(string value)
        {
            return dal.TimKiem(value);
        }
    }
}
