using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SieuThiMini.DTO
{
    public class LoaiSanPhamDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("ma_loai")]
        public int MaLoai { get; set; }

        [BsonElement("ten_loai")]
        public string TenLoai { get; set; }

        [BsonElement("ma_ncc")]
        public int MaNhaCungCap { get; set; }

        [BsonElement("trang_thai")]
        public int TrangThai { get; set; }

        public LoaiSanPhamDTO(int maLoai, string tenLoai, int maNhaCungCap, int trangThai)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
            MaNhaCungCap = maNhaCungCap;
            TrangThai = trangThai;
        }
    }
}