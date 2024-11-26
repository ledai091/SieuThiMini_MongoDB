using SieuThiMini.DAL;
using SieuThiMini.DTO;
using System.Collections.Generic;

namespace SieuThiMini.BLL
{
    class HoaDonBLL
    {
        private HoaDonDAL DAL;
        private List<HoaDonDTO> listDTO;

        public HoaDonBLL()
        {
            this.DAL = new HoaDonDAL();
        }

        public List<HoaDonDTO> GetList()
        {
            return this.DAL.SelectAll();
        }

        public List<HoaDonDTO> GetListDeleted()
        {
            return this.DAL.SelectAllDeleted();
        }

        public void Insert(HoaDonDTO dto)
        {
            this.DAL.Insert(dto);
        }

        public void Delete(string dtoId)
        {
            this.DAL.Delete(dtoId);
        }

        public void Restore(string mahoadon)
        {
            this.DAL.Restore(mahoadon);
        }

        public HoaDonDTO GetHDByMaHD(int ma_hoa_don)
        {
            var result = this.DAL.GetHDByMaHD(ma_hoa_don.ToString());
            return result.Count > 0 ? result[0] : null;
        }
    }
}