using System.Collections.Generic;
using SieuThiMini.DTO;
using SieuThiMini.DAL;

namespace SieuThiMini.BLL
{
    class TaiKhoanBLL
    {
        private readonly TaiKhoanDAL dal;

        public TaiKhoanBLL()
        {
            dal = new TaiKhoanDAL();
        }

        public List<TaiKhoanDTO> SelectAll()
        {
            return dal.SelectAll();
        }

        public List<TaiKhoanDTO> SelectAllDeleted()
        {
            return dal.SelectAllDeleted();
        }

        public List<TaiKhoanDTO> TimKiem(string timkiem)
        {
            return dal.TimKiem(timkiem);
        }

        public int Insert(TaiKhoanDTO target)
        {
            return dal.Insert(target);
        }

        public void Update(TaiKhoanDTO target)
        {
            dal.Update(target);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Restore(int id)
        {
            dal.Restore(id);
        }

        public TaiKhoanDTO GetTKByMaTK(int maTaiKhoan)
        {
            return dal.GetTKByMaTK(maTaiKhoan);
        }

        public List<TaiKhoanDTO> GetTKByQuyen(int quyen)
        {
            return dal.GetTKByQuyen(quyen);
        }

        public List<TaiKhoanDTO> GetTKByNameTK(string name)
        {
            return dal.GetTKByNameTK(name);
        }

        public TaiKhoanDTO SignIn(string tenTaiKhoan, string matKhau)
        {
            return dal.SignIn(tenTaiKhoan, matKhau);
        }
    }
}
