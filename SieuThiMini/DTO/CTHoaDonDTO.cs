using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SieuThiMini.DTO
{
    public class CTHoaDonDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("ma_hoa_don")]
        public int MaHoaDon { get; set; }

        [BsonElement("ma_san_pham")]
        public int MaSanPham { get; set; }

        [BsonElement("ten_san_pham")]
        public string TenSanPham { get; set; }

        [BsonElement("so_luong")]
        public int SoLuong { get; set; }

        [BsonElement("gia_san_pham")]
        public int GiaSanPham { get; set; }

        [BsonElement("thanh_tien")]
        public int ThanhTien { get; set; }

        public CTHoaDonDTO(int maHoaDon, int maSanPham, string tenSanPham, int soLuong, int giaSanPham, int thanhTien)
        {
            MaHoaDon = maHoaDon;
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            SoLuong = soLuong;
            GiaSanPham = giaSanPham;
            ThanhTien = thanhTien;
        }
    }
}