using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SieuThiMini.DTO
{
    public class SanPhamDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("ma_san_pham")]
        public int MaSanPham { get; set; }

        [BsonElement("ten_san_pham")]
        public string TenSanPham { get; set; }

        [BsonElement("so_luong")]
        public int SoLuong { get; set; }

        [BsonElement("gia")]
        public int Gia { get; set; }

        [BsonElement("gia_nhap")]
        public int GiaNhap { get; set; }

        [BsonElement("ma_loai")]
        public int MaLoai { get; set; }

        [BsonElement("trang_thai")]
        public int TrangThai { get; set; }

        public SanPhamDTO(int maSanPham, string tenSanPham, int soLuong, int gia, int giaNhap, int maLoai, int trangThai)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            SoLuong = soLuong;
            Gia = gia;
            GiaNhap = giaNhap;
            MaLoai = maLoai;
            TrangThai = trangThai;
        }
    }
}
