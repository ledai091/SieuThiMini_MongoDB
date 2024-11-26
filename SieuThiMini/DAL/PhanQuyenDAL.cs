using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using SieuThiMini.DTO;

namespace SieuThiMini.DAL
{
    class PhanQuyenDAL
    {
        private readonly IMongoCollection<BsonDocument> _collection;

        public PhanQuyenDAL()
        {
            var connection = new DataConnection();
            connection.OpenConnection();
            _collection = connection.Database.GetCollection<BsonDocument>("phan_quyen");
        }

        public List<PhanQuyenDTO> SelectAll()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public int Insert(PhanQuyenDTO target)
        {
            var document = new BsonDocument
            {
                { "ma_quyen", target.MaQuyen },
                { "ten_quyen", target.TenQuyen }
            };
            _collection.InsertOne(document);
            return 1; // Return success indicator
        }

        public void Update(PhanQuyenDTO target)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(target.Id));
            var update = Builders<BsonDocument>.Update
                .Set("ten_quyen", target.TenQuyen);
            _collection.UpdateOne(filter, update);
        }

        public int Delete(string id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(id));
            _collection.DeleteOne(filter);
            return 1; // Return success indicator
        }

        public List<PhanQuyenDTO> GetPQByMaPQ(string ma_phan_quyen)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_quyen", ma_phan_quyen);
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public List<PhanQuyenDTO> GetPQByNamePQ(string name)
        {
            var filter = Builders<BsonDocument>.Filter.Regex("ten_quyen", new BsonRegularExpression(name, "i"));
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        private List<PhanQuyenDTO> MapToDTOList(List<BsonDocument> documents)
        {
            var dtoList = new List<PhanQuyenDTO>();
            foreach (var doc in documents)
            {
                var dto = new PhanQuyenDTO(
                    doc.Contains("ma_quyen") ? doc["ma_quyen"].AsInt32 : 0,
                    doc.Contains("ten_quyen") ? doc["ten_quyen"].AsString : null
                )
                {
                    Id = doc.Contains("_id") ? doc["_id"].ToString() : null
                };
                dtoList.Add(dto);
            }
            return dtoList;
        }
    }
}