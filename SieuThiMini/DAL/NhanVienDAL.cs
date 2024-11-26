using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using SieuThiMini.DTO;

namespace SieuThiMini.DAL
{
    class NhanVienDAL
    {
        private readonly IMongoCollection<BsonDocument> _collection;

        public NhanVienDAL()
        {
            var connection = new DataConnection();
            connection.OpenConnection();
            _collection = connection.Database.GetCollection<BsonDocument>("nhan_vien");
        }

        public List<NhanVienDTO> SelectAll()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 1);
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public List<NhanVienDTO> GetNhanVien()
        {
            return SelectAll();
        }

        public List<NhanVienDTO> GetDeletedNhanVien()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", "0");
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public List<NhanVienDTO> GetDeletedNhanVienByKey(string key)
        {
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("trang_thai", "0"),
                Builders<BsonDocument>.Filter.Or(
                    Builders<BsonDocument>.Filter.Regex("ma_nhan_vien", new BsonRegularExpression(key, "i")),
                    Builders<BsonDocument>.Filter.Regex("ten_nhan_vien", new BsonRegularExpression(key, "i"))
                )
            );
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public void Insert(NhanVienDTO target)
        {
            var document = new BsonDocument
            {
                { "ma_nhan_vien", target.MaNhanVien },
                { "ten_nhan_vien", target.TenNhanVien },
                { "ngay_sinh", target.NgaySinh },
                { "sdt", target.SoDienThoai },
                { "mail", target.Email },
                { "tai_khoan", target.TaiKhoan },
                { "trang_thai", "1" }
            };
            _collection.InsertOne(document);
        }

        public void Update(NhanVienDTO target)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_nhan_vien", target.MaNhanVien);
            var update = Builders<BsonDocument>.Update
                .Set("ten_nhan_vien", target.TenNhanVien)
                .Set("ngay_sinh", target.NgaySinh)
                .Set("sdt", target.SoDienThoai)
                .Set("mail", target.Email)
                .Set("tai_khoan", target.TaiKhoan);
            _collection.UpdateOne(filter, update);
        }

        public void Delete(string id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(id));
            var update = Builders<BsonDocument>.Update.Set("trang_thai", "0");
            _collection.UpdateOne(filter, update);
        }

        public void Restore(string id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(id));
            var update = Builders<BsonDocument>.Update.Set("trang_thai", "1");
            _collection.UpdateOne(filter, update);
        }

        public List<NhanVienDTO> GetNVByMaNV(int ma_nv)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_nhan_vien", ma_nv);
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public List<NhanVienDTO> getNVByNameNV(string ten_nv)
        {
            var filter = Builders<BsonDocument>.Filter.Regex("ten_nhan_vien", new BsonRegularExpression(ten_nv, "i"));
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public List<NhanVienDTO> getNVByMaTK(int ma_tai_khoan)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("tai_khoan", ma_tai_khoan);
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        private List<NhanVienDTO> MapToDTOList(List<BsonDocument> documents)
        {
            var dtoList = new List<NhanVienDTO>();
            foreach (var doc in documents)
            {
                var dto = new NhanVienDTO(
                    Convert.ToInt32(doc["ma_nhan_vien"]),
                    doc["ten_nhan_vien"].ToString(),
                    doc["ngay_sinh"].ToUniversalTime(),
                    doc["sdt"].ToString(),
                    doc["mail"].ToString(),
                    Convert.ToInt32(doc["tai_khoan"]),
                    Convert.ToInt32(doc["trang_thai"])
                );
                dtoList.Add(dto);
            }
            return dtoList;
        }
    }
}