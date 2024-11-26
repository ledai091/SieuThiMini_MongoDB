using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SieuThiMini.DTO
{
    public class CTDonNhapHangDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("ma_don_nh")]
        public int MaDonNhapHang { get; set; }

        [BsonElement("ma_san_pham")]
        public int MaSanPham { get; set; }

        [BsonElement("ten_san_pham")]
        public string TenSanPham { get; set; }

        [BsonElement("so_luong")]
        public int SoLuong { get; set; }

        [BsonElement("gia")]
        public int Gia { get; set; }

        [BsonElement("thanh_tien")]
        public int ThanhTien { get; set; }

        public CTDonNhapHangDTO(int maDonNhapHang, int maSanPham, string tenSanPham, int soLuong, int gia, int thanhTien)
        {
            MaDonNhapHang = maDonNhapHang;
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            SoLuong = soLuong;
            Gia = gia;
            ThanhTien = thanhTien;
        }
    }
}