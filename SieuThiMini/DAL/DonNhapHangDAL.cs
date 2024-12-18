using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using SieuThiMini.DTO;

namespace SieuThiMini.DAL
{
    class DonNhapHangDAL
    {
        private readonly IMongoCollection<BsonDocument> _collection;

        public DonNhapHangDAL()
        {
            var connection = new DataConnection();
            connection.OpenConnection();
            _collection = connection.Database.GetCollection<BsonDocument>("don_nhap_hang");
        }

        public List<DonNhapHangDTO> SelectAll()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 1);
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public List<DonNhapHangDTO> SelectAllDeleted()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 0);
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        public void Insert(DonNhapHangDTO target)
        {
            var document = new BsonDocument
            {
                { "ma_don_nh", target.MaDonNhapHang },
                { "ma_ncc", target.MaNhaCungCap },
                { "ma_nhan_vien", target.MaNhanVien },
                { "ngay_nhap", target.NgayNhap },
                { "tong_tien_nhap", target.TongTienNhap },
                { "trang_thai", target.TrangThai }
            };
            _collection.InsertOne(document);
        }

        public void Delete(int id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_don_nh", id);
            var update = Builders<BsonDocument>.Update.Set("trang_thai", 0);
            _collection.UpdateOne(filter, update);
        }

        public void Restore(int id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_don_nh", id);
            var update = Builders<BsonDocument>.Update.Set("trang_thai", 1);
            _collection.UpdateOne(filter, update);
        }

        public List<DonNhapHangDTO> GetDNHByMaDNH(int maDonNhapHang)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_don_nh", maDonNhapHang);
            var documents = _collection.Find(filter).ToList();
            return MapToDTOList(documents);
        }

        private List<DonNhapHangDTO> MapToDTOList(List<BsonDocument> documents)
        {
            var dtoList = new List<DonNhapHangDTO>();
            foreach (var doc in documents)
            {
                var dto = new DonNhapHangDTO(
                    doc.GetValue("ma_don_nh").AsInt32,
                    doc.GetValue("ma_ncc").AsInt32,
                    doc.GetValue("ma_nhan_vien").AsInt32,
                    doc.GetValue("ngay_nhap").ToUniversalTime(),
                    doc.GetValue("tong_tien_nhap").AsInt32,
                    doc.GetValue("trang_thai").AsInt32
                );
                dtoList.Add(dto);
            }
            return dtoList;
        }
    }
}