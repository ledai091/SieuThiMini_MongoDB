using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using SieuThiMini.DTO;

namespace SieuThiMini.DAL
{
    class CTHoaDonDAL
    {
        private readonly IMongoCollection<BsonDocument> _collection;

        public CTHoaDonDAL()
        {
            var connection = new DataConnection();
            connection.OpenConnection();
            _collection = connection.Database.GetCollection<BsonDocument>("chi_tiet_hoa_don");
        }

        public List<CTHoaDonDTO> SelectAll()
        {
            var documents = _collection.Find(new BsonDocument()).ToList();
            var dtoList = new List<CTHoaDonDTO>();

            foreach (var doc in documents)
            {
                var dto = new CTHoaDonDTO(
                    doc["ma_hoa_don"].AsInt32,
                    doc["ma_san_pham"].AsInt32,
                    doc["ten_san_pham"].AsString,
                    doc["so_luong"].AsInt32,
                    doc["gia_san_pham"].AsInt32,
                    doc["thanh_tien"].AsInt32
                );
                dtoList.Add(dto);
            }

            return dtoList;
        }

        public void Insert(CTHoaDonDTO dto)
        {
            var document = new BsonDocument
            {
                { "ma_hoa_don", dto.MaHoaDon },
                { "ma_san_pham", dto.MaSanPham },
                { "ten_san_pham", dto.TenSanPham },
                { "so_luong", dto.SoLuong },
                { "gia_san_pham", dto.GiaSanPham },
                { "thanh_tien", dto.ThanhTien }
            };

            _collection.InsertOne(document);
        }

        public List<CTHoaDonDTO> GetCTHDByMaHD(int ma)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_hoa_don", ma);
            var documents = _collection.Find(filter).ToList();
            var dtoList = new List<CTHoaDonDTO>();

            foreach (var doc in documents)
            {
                var dto = new CTHoaDonDTO(
                    doc["ma_hoa_don"].AsInt32,
                    doc["ma_san_pham"].AsInt32,
                    doc["ten_san_pham"].AsString,
                    doc["so_luong"].AsInt32,
                    doc["gia_san_pham"].AsInt32,
                    doc["thanh_tien"].AsInt32
                );
                dtoList.Add(dto);
            }

            return dtoList;
        }
    }
}