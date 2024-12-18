using System.Collections.Generic;
using SieuThiMini.DTO;
using SieuThiMini.DAL;

namespace SieuThiMini.BLL
{
    class NhaCungCapBLL
    {
        private NhaCungCapDAL dal;

        public NhaCungCapBLL()
        {
            dal = new NhaCungCapDAL();
        }

        public List<NhaCungCapDTO> SelectAll()
        {
            return dal.SelectAll();
        }

        public List<NhaCungCapDTO> SelectAllDeleted()
        {
            return dal.SelectAllDeleted();
        }

        public void Insert(NhaCungCapDTO target)
        {
            dal.Insert(target);
        }

        public void Restore(int id)
        {
            dal.Restore(id);
        }

        public void Update(NhaCungCapDTO target)
        {
            dal.Update(target);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public List<NhaCungCapDTO> GetNCCByMaNCC(int id)
        {
            return dal.GetNCCByMaNCC(id);
        }

        public List<NhaCungCapDTO> GetNCCByName(string name)
        {
            return dal.GetNCCByName(name);
        }
    }
}
