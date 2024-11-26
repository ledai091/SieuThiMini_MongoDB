using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using SieuThiMini.DTO;

namespace SieuThiMini.DAL
{
    class NhaCungCapDAL
    {
        private readonly IMongoCollection<BsonDocument> _collection;

        public NhaCungCapDAL()
        {
            var connection = new DataConnection();
            connection.OpenConnection();
            _collection = connection.Database.GetCollection<BsonDocument>("nha_cung_cap");
        }

        public List<NhaCungCapDTO> SelectAll()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 1);
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public List<NhaCungCapDTO> SelectAllDeleted()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", "0");
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public void Insert(NhaCungCapDTO target)
        {
            var document = new BsonDocument
            {
                { "ten_ncc", target.TenNhaCungCap },
                { "dia_chi", target.DiaChi },
                { "trang_thai", "1" }
            };
            _collection.InsertOne(document);
        }

        public void Update(NhaCungCapDTO target)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(target.Id));
            var update = Builders<BsonDocument>.Update
                .Set("ten_ncc", target.TenNhaCungCap)
                .Set("dia_chi", target.DiaChi);
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

        public List<NhaCungCapDTO> GetNCCByMaNCC(string id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(id));
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public List<NhaCungCapDTO> GetNCCByName(string name)
        {
            var filter = Builders<BsonDocument>.Filter.Regex("ten_ncc", new BsonRegularExpression(name, "i"));
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        private List<NhaCungCapDTO> MapToDTOList(List<BsonDocument> documents)
        {
            var dtoList = new List<NhaCungCapDTO>();
            foreach (var doc in documents)
            {
                var dto = new NhaCungCapDTO
                {
                    MaNhaCungCap = doc.Contains("ma_ncc") ? doc["ma_ncc"].AsInt32 : 0,
                    TenNhaCungCap = doc.Contains("ten_ncc") ? doc["ten_ncc"].AsString : null,
                    DiaChi = doc.Contains("dia_chi") ? doc["dia_chi"].AsString : null,
                    TrangThai = doc.Contains("trang_thai") ? doc["trang_thai"].AsInt32 : 0
                };
                dtoList.Add(dto);
            }
            return dtoList;
        }

    }
}
