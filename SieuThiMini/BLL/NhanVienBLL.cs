using System.Collections.Generic;
using SieuThiMini.DAL;
using SieuThiMini.DTO;

namespace SieuThiMini.BLL
{
    class NhanVienBLL
    {
        private NhanVienDAL dal;

        public NhanVienBLL()
        {
            dal = new NhanVienDAL();
        }

        public List<NhanVienDTO> GetList()
        {
            return dal.SelectAll();
        }

        public List<NhanVienDTO> GetDeletedNhanVien()
        {
            return dal.GetDeletedNhanVien();
        }

        public List<NhanVienDTO> GetDeletedNhanVienByKey(string key)
        {
            return dal.GetDeletedNhanVienByKey(key);
        }

        public void Insert(NhanVienDTO dto)
        {
            dal.Insert(dto);
        }

        public void Update(NhanVienDTO dto)
        {
            dal.Update(dto);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Restore(int id)
        {
            dal.Restore(id);
        }

        public NhanVienDTO GetNVByMaNV(int ma_nv)
        {
            return dal.GetNVByMaNV(ma_nv)[0];
        }

        public List<NhanVienDTO> getNVByNameNV(string ten_nv)
        {
            return dal.getNVByNameNV(ten_nv);
        }

        public List<NhanVienDTO> GetNVByMaTK(int ma_tai_khoan)
        {
            return dal.getNVByMaTK(ma_tai_khoan);
        }

        public List<NhanVienDTO> TimKiem(int key)
        {
            return dal.GetNVByMaNV(key);
        }

        public List<NhanVienDTO> TimKiemDeleted(string key)
        {
            return dal.GetDeletedNhanVienByKey(key);
        }
    }
}
