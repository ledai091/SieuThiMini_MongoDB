using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using SieuThiMini.DTO;

namespace SieuThiMini.DAL
{
    class HoaDonDAL
    {
        private readonly IMongoCollection<BsonDocument> _collection;

        public HoaDonDAL()
        {
            var connection = new DataConnection();
            connection.OpenConnection();
            _collection = connection.Database.GetCollection<BsonDocument>("hoa_don");
        }

        public List<HoaDonDTO> SelectAll()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 1);
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public List<HoaDonDTO> SelectAllDeleted()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", "0");
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public void Insert(HoaDonDTO target)
        {
            var document = new BsonDocument
            {
                { "ngay_xuat", target.NgayXuat },
                { "ma_nhan_vien", target.MaNhanVien },
                { "tong_tien", target.TongTien },
                { "trang_thai", "1" }
            };
            _collection.InsertOne(document);
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

        public List<HoaDonDTO> GetHDByMaHD(string id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(id));
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        private List<HoaDonDTO> MapToDTOList(List<BsonDocument> documents)
        {
            var dtoList = new List<HoaDonDTO>();
            foreach (var doc in documents)
            {
                int maHoaDon = doc.Contains("ma_hoa_don") ? doc["ma_hoa_don"].AsInt32 : 0;
                DateTime ngayXuat = doc.Contains("ngay_xuat") ? doc["ngay_xuat"].ToUniversalTime() : DateTime.MinValue;
                int maNhanVien = doc.Contains("ma_nhan_vien") ? doc["ma_nhan_vien"].AsInt32 : 0;
                int tongTien = doc.Contains("tong_tien") ? doc["tong_tien"].AsInt32 : 0;
                int trangThai = doc.Contains("trang_thai") ? doc["trang_thai"].AsInt32 : 0;

                var dto = new HoaDonDTO(maHoaDon, ngayXuat, maNhanVien, tongTien, trangThai);
                dtoList.Add(dto);
            }
            return dtoList;
        }

    }
}