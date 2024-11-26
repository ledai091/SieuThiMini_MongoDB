using System.Collections.Generic;
using SieuThiMini.DTO;
using SieuThiMini.DAL;

namespace SieuThiMini.BLL
{
    class PhanQuyenBLL
    {
        private readonly PhanQuyenDAL dal;

        public PhanQuyenBLL()
        {
            this.dal = new PhanQuyenDAL();
        }

        public List<PhanQuyenDTO> SelectAll()
        {
            return dal.SelectAll();
        }

        public int Insert(PhanQuyenDTO target)
        {
            return dal.Insert(target);
        }

        public void Update(PhanQuyenDTO target)
        {
            dal.Update(target);
        }

        public int Delete(string id)
        {
            return dal.Delete(id);
        }

        public List<PhanQuyenDTO> GetPQByMaPQ(string ma_phan_quyen)
        {
            return dal.GetPQByMaPQ(ma_phan_quyen);
        }

        public List<PhanQuyenDTO> GetPQByNamePQ(string name)
        {
            return dal.GetPQByNamePQ(name);
        }
    }
}
