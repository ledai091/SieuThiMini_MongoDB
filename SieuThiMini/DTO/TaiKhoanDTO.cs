using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SieuThiMini.DTO
{
    public class TaiKhoanDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("ma_tai_khoan")]
        public int MaTaiKhoan { get; set; }

        [BsonElement("ten_tai_khoan")]
        public string TenTaiKhoan { get; set; }

        [BsonElement("mat_khau")]
        public string MatKhau { get; set; }

        [BsonElement("phan_quyen")]
        public int PhanQuyen { get; set; }

        [BsonElement("trang_thai")]
        public int TrangThai { get; set; }

        public TaiKhoanDTO(int maTaiKhoan, string tenTaiKhoan, string matKhau, int phanQuyen, int trangThai)
        {
            MaTaiKhoan = maTaiKhoan;
            TenTaiKhoan = tenTaiKhoan;
            MatKhau = matKhau;
            PhanQuyen = phanQuyen;
            TrangThai = trangThai;
        }
        public TaiKhoanDTO()
        {
        }
    }
}
