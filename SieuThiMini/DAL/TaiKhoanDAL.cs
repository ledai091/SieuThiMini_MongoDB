using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using SieuThiMini.DTO;

namespace SieuThiMini.DAL
{
    class TaiKhoanDAL
    {
        private readonly IMongoCollection<TaiKhoanDTO> _collection;

        public TaiKhoanDAL()
        {
            var connection = new DataConnection();
            connection.OpenConnection();
            _collection = connection.Database.GetCollection<TaiKhoanDTO>("tai_khoan");
        }

        public List<TaiKhoanDTO> SelectAll()
        {
            var filter = Builders<TaiKhoanDTO>.Filter.Eq("TrangThai", 1);
            return _collection.Find(filter).ToList();
        }

        public List<TaiKhoanDTO> SelectAllDeleted()
        {
            var filter = Builders<TaiKhoanDTO>.Filter.Eq("TrangThai", 0);
            return _collection.Find(filter).ToList();
        }

        public List<TaiKhoanDTO> TimKiem(string timkiem)
        {
            var filter = Builders<TaiKhoanDTO>.Filter.Or(
                Builders<TaiKhoanDTO>.Filter.Regex("TenTaiKhoan", new BsonRegularExpression(timkiem, "i")),
                Builders<TaiKhoanDTO>.Filter.Regex("MaTaiKhoan", new BsonRegularExpression(timkiem, "i"))
            );
            return _collection.Find(filter).ToList();
        }

        public int Insert(TaiKhoanDTO target)
        {
            _collection.InsertOne(target);
            return 1; // Success
        }

        public void Update(TaiKhoanDTO target)
        {
            var filter = Builders<TaiKhoanDTO>.Filter.Eq("MaTaiKhoan", target.MaTaiKhoan);
            var update = Builders<TaiKhoanDTO>.Update
                .Set("TenTaiKhoan", target.TenTaiKhoan)
                .Set("MatKhau", target.MatKhau)
                .Set("PhanQuyen", target.PhanQuyen)
                .Set("TrangThai", target.TrangThai);
            _collection.UpdateOne(filter, update);
        }

        public void Delete(int id)
        {
            var filter = Builders<TaiKhoanDTO>.Filter.Eq("ma_tai_khoan", id);
            var update = Builders<TaiKhoanDTO>.Update.Set("trang_thai", 0);
            _collection.UpdateOne(filter, update);
        }

        public void Restore(int id)
        {
            var filter = Builders<TaiKhoanDTO>.Filter.Eq("MaTaiKhoan", id);
            var update = Builders<TaiKhoanDTO>.Update.Set("TrangThai", 1);
            _collection.UpdateOne(filter, update);
        }

        public TaiKhoanDTO GetTKByMaTK(int maTaiKhoan)
        {
            var filter = Builders<TaiKhoanDTO>.Filter.Eq("ma_tai_khoan", maTaiKhoan);
            return _collection.Find(filter).FirstOrDefault();
        }

        public List<TaiKhoanDTO> GetTKByQuyen(int quyen)
        {
            var filter = Builders<TaiKhoanDTO>.Filter.Eq("PhanQuyen", quyen);
            return _collection.Find(filter).ToList();
        }

        public List<TaiKhoanDTO> GetTKByNameTK(string name)
        {
            var filter = Builders<TaiKhoanDTO>.Filter.Regex("TenTaiKhoan", new BsonRegularExpression(name, "i"));
            return _collection.Find(filter).ToList();
        }

        public TaiKhoanDTO SignIn(string tenTaiKhoan, string matKhau)
        {
            var filter = Builders<TaiKhoanDTO>.Filter.And(
                Builders<TaiKhoanDTO>.Filter.Eq("TenTaiKhoan", tenTaiKhoan),
                Builders<TaiKhoanDTO>.Filter.Eq("MatKhau", matKhau)
            );
            return _collection.Find(filter).FirstOrDefault();
        }
    }
}
