using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SieuThiMini.DTO
{
    public class NhaCungCapDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("ma_ncc")]
        public int MaNhaCungCap { get; set; }

        [BsonElement("ten_ncc")]
        public string TenNhaCungCap { get; set; }

        [BsonElement("dia_chi")]
        public string DiaChi { get; set; }

        [BsonElement("trang_thai")]
        public int TrangThai { get; set; }

        // Constructor mặc định (cho phép khởi tạo mà không cần tham số)
        public NhaCungCapDTO() { }

        // Constructor đầy đủ (khởi tạo từ các tham số)
        public NhaCungCapDTO(int maNhaCungCap, string tenNhaCungCap, string diaChi, int trangThai)
        {
            MaNhaCungCap = maNhaCungCap;
            TenNhaCungCap = tenNhaCungCap;
            DiaChi = diaChi;
            TrangThai = trangThai;
        }
    }
}