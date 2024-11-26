using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using SieuThiMini.DTO;

namespace SieuThiMini.DAL
{
    class CTDonNhapHangDAL
    {
        private readonly IMongoCollection<BsonDocument> _collection;

        public CTDonNhapHangDAL()
        {
            var connection = new DataConnection();
            connection.OpenConnection();
            _collection = connection.Database.GetCollection<BsonDocument>("chi_tiet_don_nhap_hang");
        }

        public List<CTDonNhapHangDTO> SelectAll()
        {
            var documents = _collection.Find(new BsonDocument()).ToList();
            var dtoList = new List<CTDonNhapHangDTO>();

            foreach (var doc in documents)
            {
                var dto = new CTDonNhapHangDTO(
                    doc["ma_don_nh"].AsInt32,
                    doc["ma_san_pham"].AsInt32,
                    doc["ten_san_pham"].AsString,
                    doc["so_luong"].AsInt32,
                    doc["gia"].AsInt32,
                    doc["thanh_tien"].AsInt32
                );
                dtoList.Add(dto);
            }

            return dtoList;
        }

        public void Insert(CTDonNhapHangDTO dto)
        {
            var document = new BsonDocument
            {
                { "ma_don_nh", dto.MaDonNhapHang },
                { "ma_san_pham", dto.MaSanPham },
                { "ten_san_pham", dto.TenSanPham },
                { "so_luong", dto.SoLuong },
                { "gia", dto.Gia },
                { "thanh_tien", dto.ThanhTien }
            };

            _collection.InsertOne(document);
        }

        public List<CTDonNhapHangDTO> GetCTDNHByMaDNH(int ma)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_don_nh", ma);
            var documents = _collection.Find(filter).ToList();
            var dtoList = new List<CTDonNhapHangDTO>();

            foreach (var doc in documents)
            {
                var dto = new CTDonNhapHangDTO(
                    doc["ma_don_nh"].AsInt32,
                    doc["ma_san_pham"].AsInt32,
                    doc["ten_san_pham"].AsString,
                    doc["so_luong"].AsInt32,
                    doc["gia"].AsInt32,
                    doc["thanh_tien"].AsInt32
                );
                dtoList.Add(dto);
            }

            return dtoList;
        }
    }
}