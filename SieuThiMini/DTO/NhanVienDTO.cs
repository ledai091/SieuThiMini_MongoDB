using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace SieuThiMini.DTO
{
    public class NhanVienDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("ma_nhan_vien")]
        public int MaNhanVien { get; set; }

        [BsonElement("ten_nhan_vien")]
        public string TenNhanVien { get; set; }

        [BsonElement("ngay_sinh")]
        public DateTime NgaySinh { get; set; }

        [BsonElement("sdt")]
        public string SoDienThoai { get; set; }

        [BsonElement("mail")]
        public string Email { get; set; }

        [BsonElement("tai_khoan")]
        public int TaiKhoan { get; set; }

        [BsonElement("trang_thai")]
        public int TrangThai { get; set; }

        public NhanVienDTO(int maNhanVien, string tenNhanVien, DateTime ngaySinh, string soDienThoai, string email, int taiKhoan, int trangThai)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            NgaySinh = ngaySinh;
            SoDienThoai = soDienThoai;
            Email = email;
            TaiKhoan = taiKhoan;
            TrangThai = trangThai;
        }
    }
}