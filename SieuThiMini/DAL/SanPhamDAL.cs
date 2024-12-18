using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using SieuThiMini.DTO;

namespace SieuThiMini.DAL
{
    class SanPhamDAL
    {
        private readonly IMongoCollection<BsonDocument> _collection;

        public SanPhamDAL()
        {
            var connection = new DataConnection();
            connection.OpenConnection();
            _collection = connection.Database.GetCollection<BsonDocument>("san_pham");
        }

        public List<SanPhamDTO> SelectAll()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 1);
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public int Insert(SanPhamDTO target)
        {
            var document = new BsonDocument
            {
                { "ma_san_pham", target.MaSanPham },
                { "ten_san_pham", target.TenSanPham },
                { "so_luong", target.SoLuong },
                { "gia", target.Gia },
                { "gia_nhap", target.GiaNhap },
                { "ma_loai", target.MaLoai },
                { "trang_thai", target.TrangThai }
            };
            _collection.InsertOne(document);
            return 1; // Return success
        }

        public void Update(SanPhamDTO target)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_san_pham", target.MaSanPham);
            var update = Builders<BsonDocument>.Update
                .Set("ten_san_pham", target.TenSanPham)
                .Set("so_luong", target.SoLuong)
                .Set("gia", target.Gia)
                .Set("gia_nhap", target.GiaNhap)
                .Set("ma_loai", target.MaLoai);
            _collection.UpdateOne(filter, update);
        }

        public void UpdateSoLuong(int ma_san_pham, int so_luong)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_san_pham", ma_san_pham);
            var update = Builders<BsonDocument>.Update.Set("so_luong", so_luong);
            _collection.UpdateOne(filter, update);
        }

        public int Delete(int id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_san_pham", id);
            var update = Builders<BsonDocument>.Update.Set("trang_thai", 0);
            _collection.UpdateOne(filter, update);
            return 1; // Return success
        }

        public int Restore(int id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_san_pham", id);
            var update = Builders<BsonDocument>.Update.Set("trang_thai", 1);
            _collection.UpdateOne(filter, update);
            return 1; // Return success
        }

        public List<SanPhamDTO> GetSPByLoaiSP(int ma_loai)
        {
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("ma_loai", ma_loai),
                Builders<BsonDocument>.Filter.Eq("trang_thai", 1)
            );
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public List<SanPhamDTO> GetSPByMaSP(int ma_san_pham)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_san_pham", ma_san_pham);
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public List<SanPhamDTO> GetSPByNameSP(string name)
        {
            var filter = Builders<BsonDocument>.Filter.Regex("ten_san_pham", new BsonRegularExpression(name, "i"));
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public List<SanPhamDTO> TimKiem(string value)
        {
            var filter = Builders<BsonDocument>.Filter.Or(
                Builders<BsonDocument>.Filter.Regex("ten_san_pham", new BsonRegularExpression(value, "i")),
                Builders<BsonDocument>.Filter.Regex("ma_san_pham", new BsonRegularExpression(value, "i")),
                Builders<BsonDocument>.Filter.Regex("ma_loai", new BsonRegularExpression(value, "i"))
            );
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        private List<SanPhamDTO> MapToDTOList(List<BsonDocument> documents)
        {
            var dtoList = new List<SanPhamDTO>();
            foreach (var doc in documents)
            {
                var dto = new SanPhamDTO(
                    doc.Contains("ma_san_pham") ? doc["ma_san_pham"].AsInt32 : 0,
                    doc.Contains("ten_san_pham") ? doc["ten_san_pham"].AsString : null,
                    doc.Contains("so_luong") ? doc["so_luong"].AsInt32 : 0,
                    doc.Contains("gia") ? doc["gia"].AsInt32 : 0,
                    doc.Contains("gia_nhap") ? doc["gia_nhap"].AsInt32 : 0,
                    doc.Contains("ma_loai") ? doc["ma_loai"].AsInt32 : 0,
                    doc.Contains("trang_thai") ? doc["trang_thai"].AsInt32 : 0
                );
                dtoList.Add(dto);
            }
            return dtoList;
        }
    }
}
