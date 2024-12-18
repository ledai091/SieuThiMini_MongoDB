using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using SieuThiMini.DTO;

namespace SieuThiMini.DAL
{
    class LoaiSanPhamDAL
    {
        private readonly IMongoCollection<BsonDocument> _collection;

        public LoaiSanPhamDAL()
        {
            var connection = new DataConnection();
            connection.OpenConnection();
            _collection = connection.Database.GetCollection<BsonDocument>("loai_san_pham");
        }

        public List<LoaiSanPhamDTO> SelectAll()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 1);
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public List<LoaiSanPhamDTO> SelectAllDeleted()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 0);
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public void Insert(LoaiSanPhamDTO target)
        {
            var document = new BsonDocument
            {
                { "ten_loai", target.TenLoai },
                { "ma_ncc", target.MaNhaCungCap },
                { "trang_thai", "1" }
            };
            _collection.InsertOne(document);
        }

        public void Update(LoaiSanPhamDTO target)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_loai", target.MaLoai);
            var update = Builders<BsonDocument>.Update
                .Set("ten_loai", target.TenLoai)
                .Set("ma_ncc", target.MaNhaCungCap);
            _collection.UpdateOne(filter, update);
        }

        public void Delete(int id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_loai", id);
            var update = Builders<BsonDocument>.Update.Set("trang_thai", 0);
            _collection.UpdateOne(filter, update);
        }

        public void Restore(int id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_loai", id);
            var update = Builders<BsonDocument>.Update.Set("trang_thai", 1);
            _collection.UpdateOne(filter, update);
        }

        public List<LoaiSanPhamDTO> GetLSPByMaLSP(string id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(id));
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public List<LoaiSanPhamDTO> GetLSPByNCC(int maNcc)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_ncc", maNcc);
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public List<LoaiSanPhamDTO> GetLSPByName(string name)
        {
            var filter = Builders<BsonDocument>.Filter.Regex("ten_loai", new BsonRegularExpression(name, "i"));
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public List<LoaiSanPhamDTO> TimKiem(string timkiem)
        {
            var baseFilter = Builders<BsonDocument>.Filter.Eq("trang_thai", 1);
            var filters = new List<FilterDefinition<BsonDocument>>();

            // Always add name regex search filter
            filters.Add(Builders<BsonDocument>.Filter.Regex("ten_loai", new BsonRegularExpression(timkiem, "i")));

            // Try to parse timkiem as an integer
            if (int.TryParse(timkiem, out int timkiemInt))
            {
                // If successful, add the ma_loai filter as well
                filters.Add(Builders<BsonDocument>.Filter.Eq("ma_loai", timkiemInt));
            }

            // Combine with OR condition
            var orFilter = Builders<BsonDocument>.Filter.Or(filters);

            // Combine trang_thai and the OR filters
            var finalFilter = Builders<BsonDocument>.Filter.And(baseFilter, orFilter);

            var documents = _collection.Find(finalFilter).ToList();
            return MapToDTOList(documents);
        }


        public List<LoaiSanPhamDTO> TimKiemDeleted(string timkiem)
        {
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("trang_thai", 0),
                Builders<BsonDocument>.Filter.Or(
                    Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(timkiem)),
                    Builders<BsonDocument>.Filter.Regex("ten_loai", new BsonRegularExpression(timkiem, "i"))
                )
            );
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        private List<LoaiSanPhamDTO> MapToDTOList(List<BsonDocument> documents)
        {
            var dtoList = new List<LoaiSanPhamDTO>();
            foreach (var doc in documents)
            {
                var dto = new LoaiSanPhamDTO(
                    doc.Contains("ma_loai") ? doc["ma_loai"].AsInt32 : 0,
                    doc.Contains("ten_loai") ? doc["ten_loai"].AsString : null,
                    doc.Contains("ma_ncc") ? doc["ma_ncc"].AsInt32 : 0,
                    doc.Contains("trang_thai") ? doc["trang_thai"].AsInt32 : 0
                );

                dtoList.Add(dto);
            }
            return dtoList;
        }
    }
}
