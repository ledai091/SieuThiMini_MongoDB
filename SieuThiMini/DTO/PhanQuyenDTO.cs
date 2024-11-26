using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SieuThiMini.DTO
{
    public class PhanQuyenDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("ma_quyen")]
        public int MaQuyen { get; set; }

        [BsonElement("ten_quyen")]
        public string TenQuyen { get; set; }

        public PhanQuyenDTO(int maQuyen, string tenQuyen)
        {
            MaQuyen = maQuyen;
            TenQuyen = tenQuyen;
        }

        public PhanQuyenDTO() { } // Constructor mặc định
    }
}
