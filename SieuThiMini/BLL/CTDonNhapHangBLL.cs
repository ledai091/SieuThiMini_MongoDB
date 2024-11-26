using SieuThiMini.DAL;
using SieuThiMini.DTO;
using System.Collections.Generic;

namespace SieuThiMini.BLL
{
    class CTDonNhapHangBLL
    {
        private CTDonNhapHangDAL DAL;
        private List<CTDonNhapHangDTO> listDTO;

        public CTDonNhapHangBLL()
        {
            this.DAL = new CTDonNhapHangDAL();
        }

        public List<CTDonNhapHangDTO> GetList()
        {
            listDTO = this.DAL.SelectAll();
            return listDTO;
        }

        public void Insert(CTDonNhapHangDTO dto)
        {
            this.DAL.Insert(dto);
        }

        public List<CTDonNhapHangDTO> GetCTDNHByMaDNH(int ma_don_nh)
        {
            return this.DAL.GetCTDNHByMaDNH(ma_don_nh);
        }
    }
}