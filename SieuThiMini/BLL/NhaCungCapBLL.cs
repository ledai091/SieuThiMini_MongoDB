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

        public void Restore(string id)
        {
            dal.Restore(id);
        }

        public void Update(NhaCungCapDTO target)
        {
            dal.Update(target);
        }

        public void Delete(string id)
        {
            dal.Delete(id);
        }

        public List<NhaCungCapDTO> GetNCCByMaNCC(string id)
        {
            return dal.GetNCCByMaNCC(id);
        }

        public List<NhaCungCapDTO> GetNCCByName(string name)
        {
            return dal.GetNCCByName(name);
        }
    }
}
