using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SieuThiMini.DTO
{
    public class HoaDonDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("ma_hoa_don")]
        public int MaHoaDon { get; set; }

        [BsonElement("ngay_xuat")]
        public DateTime NgayXuat { get; set; }

        [BsonElement("ma_nhan_vien")]
        public int MaNhanVien { get; set; }

        [BsonElement("tong_tien")]
        public int TongTien { get; set; }

        [BsonElement("trang_thai")]
        public int TrangThai { get; set; }

        public HoaDonDTO(int maHoaDon, DateTime ngayXuat, int maNhanVien, int tongTien, int trangThai)
        {
            MaHoaDon = maHoaDon;
            NgayXuat = ngayXuat;
            MaNhanVien = maNhanVien;
            TongTien = tongTien;
            TrangThai = trangThai;
        }
    }
}