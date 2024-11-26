using SieuThiMini.DAL;
using SieuThiMini.DTO;
using System.Collections.Generic;

namespace SieuThiMini.BLL
{
    class LoaiSanPhamBLL
    {
        private LoaiSanPhamDAL DAL;

        public LoaiSanPhamBLL()
        {
            this.DAL = new LoaiSanPhamDAL();
        }

        public List<LoaiSanPhamDTO> GetList()
        {
            return this.DAL.SelectAll();
        }

        public List<LoaiSanPhamDTO> GetListDeleted()
        {
            return this.DAL.SelectAllDeleted();
        }

        public void Insert(LoaiSanPhamDTO dto)
        {
            this.DAL.Insert(dto);
        }

        public void Update(LoaiSanPhamDTO dto)
        {
            this.DAL.Update(dto);
        }

        public void Delete(string id)
        {
            this.DAL.Delete(id);
        }

        public void Restore(string id)
        {
            this.DAL.Restore(id);
        }

        public List<LoaiSanPhamDTO> GetLSPByNCC(string ma_ncc)
        {
            return this.DAL.GetLSPByNCC(ma_ncc);
        }

        public List<LoaiSanPhamDTO> TimKiem(string timkiem)
        {
            return this.DAL.TimKiem(timkiem);
        }

        public List<LoaiSanPhamDTO> TimKiemDeleted(string timkiem)
        {
            return this.DAL.TimKiemDeleted(timkiem);
        }

        public LoaiSanPhamDTO GetLSPByMaLSP(string ma_loai)
        {
            var result = this.DAL.GetLSPByMaLSP(ma_loai);
            return result.Count > 0 ? result[0] : null;
        }

        public List<LoaiSanPhamDTO> GetLSPByName(string ten_loai_san_pham)
        {
            return this.DAL.GetLSPByName(ten_loai_san_pham);
        }
    }
}