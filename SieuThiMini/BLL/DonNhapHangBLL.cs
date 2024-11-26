using SieuThiMini.DAL;
using SieuThiMini.DTO;
using System.Collections.Generic;

namespace SieuThiMini.BLL
{
    class DonNhapHangBLL
    {
        private readonly DonNhapHangDAL dal;

        public DonNhapHangBLL()
        {
            dal = new DonNhapHangDAL();
        }

        public List<DonNhapHangDTO> GetList()
        {
            return dal.SelectAll();
        }

        public List<DonNhapHangDTO> GetListDeleted()
        {
            return dal.SelectAllDeleted();
        }

        public void Insert(DonNhapHangDTO dto)
        {
            dal.Insert(dto);
        }

        public void Restore(string id)
        {
            dal.Restore(id);
        }

        public void Delete(string id)
        {
            dal.Delete(id);
        }

        public DonNhapHangDTO GetDNHByMaDNH(string maDonNhapHang)
        {
            var result = dal.GetDNHByMaDNH(maDonNhapHang);
            return result.Count > 0 ? result[0] : null;
        }
    }
}