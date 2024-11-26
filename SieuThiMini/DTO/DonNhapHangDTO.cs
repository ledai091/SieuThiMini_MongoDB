using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SieuThiMini.DTO
{
    public class DonNhapHangDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("ma_don_nh")]
        public int MaDonNhapHang { get; set; }

        [BsonElement("ma_ncc")]
        public int MaNhaCungCap { get; set; }

        [BsonElement("ma_nhan_vien")]
        public int MaNhanVien { get; set; }

        [BsonElement("ngay_nhap")]
        public DateTime NgayNhap { get; set; }

        [BsonElement("tong_tien_nhap")]
        public int TongTienNhap { get; set; }

        [BsonElement("trang_thai")]
        public int TrangThai { get; set; }

        public DonNhapHangDTO(int maDonNhapHang, int maNhaCungCap, int maNhanVien, DateTime ngayNhap, int tongTienNhap, int trangThai)
        {
            MaDonNhapHang = maDonNhapHang;
            MaNhaCungCap = maNhaCungCap;
            MaNhanVien = maNhanVien;
            NgayNhap = ngayNhap;
            TongTienNhap = tongTienNhap;
            TrangThai = trangThai;
        }
    }
}