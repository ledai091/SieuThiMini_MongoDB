using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SieuThiMini.DAL
{
    class ThongKeDAL
    {
        public ThongKeDAL() { }

        private IMongoCollection<BsonDocument> GetCollection(string collectionName)
        {
            return DataProvider.Instance.GetCollection(collectionName);
        }

        public int TongDoanhThuCacHoaDon()
        {
            var collection = GetCollection("hoa_don");
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 1);
            var result = collection.Aggregate()
                .Match(filter)
                .Group(new BsonDocument { { "_id", BsonNull.Value }, { "TongDoanhThu", new BsonDocument("$sum", "$tong_tien") } })
                .FirstOrDefault();

            return result == null ? 0 : result["TongDoanhThu"].AsInt32;
        }

        public int TongDoanhThuTheoNam(int selectedYear)
        {
            var collection = GetCollection("hoa_don");

            // Set startDate to the first day of the selected year at midnight
            DateTime startDate = new DateTime(selectedYear, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            // Set endDate to the first day of the next year at midnight
            DateTime endDate = startDate.AddYears(1);

            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("trang_thai", 1), // Use "1" if "trang_thai" is stored as a string
                Builders<BsonDocument>.Filter.Gte("ngay_xuat", startDate),
                Builders<BsonDocument>.Filter.Lt("ngay_xuat", endDate)
            );

            var result = collection.Aggregate()
                .Match(filter)
                .Group(new BsonDocument
                {
            { "_id", BsonNull.Value },
            { "TongDoanhThu", new BsonDocument("$sum", "$tong_tien") }
                })
                .FirstOrDefault();

            return result == null ? 0 : result["TongDoanhThu"].ToInt32();
        }

        public int TongDoanhThuTheoThang(int selectedMonth, int selectedYear)
        {
            var collection = GetCollection("hoa_don");

            // Set startDate to the first day of the selected month at midnight
            DateTime startDate = new DateTime(selectedYear, selectedMonth, 1, 0, 0, 0, DateTimeKind.Utc);
            // Set endDate to the first day of the next month at midnight
            DateTime endDate = DateTime.Now;

            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("trang_thai", 1), // Use "1" if "trang_thai" is stored as a string
                Builders<BsonDocument>.Filter.Gte("ngay_xuat", startDate),
                Builders<BsonDocument>.Filter.Lt("ngay_xuat", endDate)
            );

            var result = collection.Aggregate()
                .Match(filter)
                .Group(new BsonDocument
                {
            { "_id", BsonNull.Value },
            { "TongDoanhThu", new BsonDocument("$sum", "$tong_tien") }
                })
                .FirstOrDefault();

            return result == null ? 0 : result["TongDoanhThu"].ToInt32();
        }


        public int TongHoaDon()
        {
            var collection = GetCollection("hoa_don");
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 1);
            return (int)collection.CountDocuments(filter);
        }

        public int TongHoaDonTheoNam(int selectedYear)
        {
            var collection = GetCollection("hoa_don");

            // Set startDate to the first day of the selected year at midnight
            DateTime startDate = new DateTime(selectedYear, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            // Set endDate to the first day of the next year at midnight
            DateTime endDate = DateTime.Now;

            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("trang_thai", 1), // Use "1" if "trang_thai" is stored as a string
                Builders<BsonDocument>.Filter.Gte("ngay_xuat", startDate),
                Builders<BsonDocument>.Filter.Lt("ngay_xuat", endDate)
            );

            return (int)collection.CountDocuments(filter);
        }


        public int TongHoaDonTheoThang(int selectedMonth, int selectedYear)
        {
            var collection = GetCollection("hoa_don");

            // Set startDate to the first day of the selected month at midnight
            DateTime startDate = new DateTime(selectedYear, selectedMonth, 1, 0, 0, 0, DateTimeKind.Utc);
            // Set endDate to the first day of the next month at midnight
            DateTime endDate = DateTime.Now;

            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("trang_thai", 1), // Use "1" if "trang_thai" is stored as a string
                Builders<BsonDocument>.Filter.Gte("ngay_xuat", startDate),
                Builders<BsonDocument>.Filter.Lt("ngay_xuat", endDate)
            );

            return (int)collection.CountDocuments(filter);
        }


        public int TongDonNH()
        {
            var collection = GetCollection("don_nhap_hang");
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 1);
            return (int)collection.CountDocuments(filter);
        }

        public int TongDonNHTheoNam(int selectedYear)
        {
            var collection = GetCollection("don_nhap_hang");

            // Set startDate to the first day of the selected year at midnight
            DateTime startDate = new DateTime(selectedYear, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            // Set endDate to the first day of the next year at midnight
            DateTime endDate = DateTime.Now;


            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("trang_thai", 1), // Use "1" if "trang_thai" is stored as a string
                Builders<BsonDocument>.Filter.Gte("ngay_nhap", startDate),
                Builders<BsonDocument>.Filter.Lt("ngay_nhap", endDate)
            );

            return (int)collection.CountDocuments(filter);
        }


        public int TongDonNHTheoThang(int selectedMonth, int selectedYear)
        {
            var collection = GetCollection("don_nhap_hang");

            DateTime startDate = new DateTime(selectedYear, selectedMonth, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime endDate = DateTime.Now;

            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("trang_thai", 1), // Hoặc "1" nếu "trang_thai" là chuỗi
                Builders<BsonDocument>.Filter.Gte("ngay_nhap", startDate),
                Builders<BsonDocument>.Filter.Lt("ngay_nhap", endDate)
            );

            return (int)collection.CountDocuments(filter);
        }


        public int TongChiPhiNhapHang()
        {
            var collection = GetCollection("don_nhap_hang");
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 1);
            var result = collection.Aggregate()
                .Match(filter)
                .Group(new BsonDocument { { "_id", BsonNull.Value }, { "TongChiPhi", new BsonDocument("$sum", "$tong_tien_nhap") } })
                .FirstOrDefault();

            return result == null ? 0 : result["TongChiPhi"].AsInt32;
        }
        public int TongChiPhiNhapHangTheoNam(int selectedYear)
        {
            try
            {
                var collection = GetCollection("don_nhap_hang");

                DateTime startDate = new DateTime(selectedYear, 1, 1, 0, 0, 0, DateTimeKind.Utc);

                DateTime endDate = DateTime.Now;

                var filter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Eq("trang_thai", 1), // Adjust to "1" if stored as a string
                    Builders<BsonDocument>.Filter.Gte("ngay_nhap", startDate),
                    Builders<BsonDocument>.Filter.Lt("ngay_nhap", endDate)
                );

                var matchedDocuments = collection.Find(filter).ToList();
                var result = collection.Aggregate()
                    .Match(filter)
                    .Group(new BsonDocument
                    {
                { "_id", BsonNull.Value },
                { "TongChiPhi", new BsonDocument("$sum", "$tong_tien_nhap") }
                    })
                    .FirstOrDefault();

                return result == null ? 0 : result["TongChiPhi"].ToInt32();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return 0;
            }
        }

        public int TongChiPhiNhapHangTheoThang(int selectedMonth, int selectedYear)
        {
            try
            {
                var collection = GetCollection("don_nhap_hang");

                DateTime startDate = new DateTime(selectedYear, selectedMonth, 1, 0, 0, 0, DateTimeKind.Utc);
                DateTime endDate = DateTime.Now;

                var filter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Eq("trang_thai", 1),
                    Builders<BsonDocument>.Filter.Gte("ngay_nhap", startDate),
                    Builders<BsonDocument>.Filter.Lt("ngay_nhap", endDate)
                );

                var matchedDocuments = collection.Find(filter).ToList();

                foreach (var doc in matchedDocuments)
                {
                    Console.WriteLine(doc.ToJson());
                }

                var result = collection.Aggregate()
                    .Match(filter)
                    .Group(new BsonDocument
                    {
                { "_id", BsonNull.Value },
                { "TongChiPhi", new BsonDocument("$sum", "$tong_tien_nhap") }
                    })
                    .FirstOrDefault();

                return result == null ? 0 : result["TongChiPhi"].ToInt32();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return 0;
            }
        }

        public int SoTaiKhoan()
        {
            var collection = GetCollection("tai_khoan");
            return (int)collection.CountDocuments(new BsonDocument());
        }

        public int TongSoSanPham()
        {
            var collection = GetCollection("san_pham");
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 1);
            return (int)collection.CountDocuments(filter);
        }

        public int SoLuongNCC()
        {
            var collection = GetCollection("nha_cung_cap");
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 1);
            return (int)collection.CountDocuments(filter);
        }

        public int SoLuongNV()
        {
            var collection = GetCollection("nhan_vien");
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 1);
            return (int)collection.CountDocuments(filter);
        }

        public DataTable TimMaNVCoTongTienLonNhatTheoNam(int selectedYear)
        {
            var collection = GetCollection("hoa_don");

            // Set startDate to the first day of the selected year
            DateTime startDate = new DateTime(selectedYear, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            // Set endDate to the first day of the next year
            DateTime endDate = DateTime.Now;

            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("trang_thai", 1), // Sử dụng "1" nếu trang_thai được lưu dưới dạng chuỗi
                Builders<BsonDocument>.Filter.Gte("ngay_xuat", startDate),
                Builders<BsonDocument>.Filter.Lt("ngay_xuat", endDate)
            );

            var result = collection.Aggregate()
                .AppendStage<BsonDocument>(new BsonDocument("$lookup", new BsonDocument
                {
                    { "from", "nhan_vien" },                 // Tên bộ sưu tập để join
                    { "localField", "ma_nhan_vien" },        // Trường trong bộ sưu tập hiện tại
                    { "foreignField", "ma_nhan_vien" },      // Trường trong bộ sưu tập được join
                    { "as", "nhan_vien_info" }               // Tên trường chứa kết quả
                }))
                .Unwind("nhan_vien_info")
                .Group(new BsonDocument
                {
                    { "_id", "$ma_nhan_vien" },
                    { "ten_nhan_vien", new BsonDocument("$first", "$nhan_vien_info.ten_nhan_vien") },
                    { "TongTienLonNhat", new BsonDocument("$sum", "$tong_tien") }
                })
                .Sort(new BsonDocument("TongTienLonNhat", -1))
                .Limit(1)
                .ToList();


            return ConvertToDataTable(result);
        }


        public DataTable TimMaNVCoTongTienLonNhatTheoThang(int selectedMonth, int selectedYear)
        {
            var collection = GetCollection("hoa_don");

            // Thiết lập startDate là ngày đầu tiên của tháng được chọn
            DateTime startDate = new DateTime(selectedYear, selectedMonth, 1, 0, 0, 0, DateTimeKind.Utc);
            // Thiết lập endDate là ngày đầu tiên của tháng tiếp theo
            DateTime endDate = DateTime.Now;

            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("trang_thai", 1), // Sử dụng "1" nếu trang_thai được lưu dưới dạng chuỗi
                Builders<BsonDocument>.Filter.Gte("ngay_xuat", startDate),
                Builders<BsonDocument>.Filter.Lt("ngay_xuat", endDate)
            );

            var result = collection.Aggregate()
                .AppendStage<BsonDocument>(new BsonDocument("$lookup", new BsonDocument
                {
                    { "from", "nhan_vien" },                 // Tên bộ sưu tập để join
                    { "localField", "ma_nhan_vien" },        // Trường trong bộ sưu tập hiện tại
                    { "foreignField", "ma_nhan_vien" },      // Trường trong bộ sưu tập được join
                    { "as", "nhan_vien_info" }               // Tên trường chứa kết quả
                }))
                .Unwind("nhan_vien_info")
                .Group(new BsonDocument
                {
                    { "_id", "$ma_nhan_vien" },
                    { "ten_nhan_vien", new BsonDocument("$first", "$nhan_vien_info.ten_nhan_vien") },
                    { "TongTienLonNhat", new BsonDocument("$sum", "$tong_tien") }
                })
                .Sort(new BsonDocument("TongTienLonNhat", -1))
                .Limit(1)
                .ToList();


            return ConvertToDataTable(result);
        }

        private DataTable ConvertToDataTable(IEnumerable<BsonDocument> bsonDocuments)
        {
            DataTable dt = new DataTable();

            // Kiểm tra nếu danh sách tài liệu không rỗng
            if (bsonDocuments != null && bsonDocuments.Any())
            {
                // Lấy danh sách các tên trường từ tài liệu đầu tiên
                foreach (var name in bsonDocuments.First().Names)
                {
                    dt.Columns.Add(name);
                }

                // Thêm từng tài liệu vào DataTable
                foreach (var doc in bsonDocuments)
                {
                    var row = dt.NewRow();
                    foreach (var name in doc.Names)
                    {
                        if (doc[name].IsBsonNull)
                        {
                            row[name] = DBNull.Value;
                        }
                        else
                        {
                            row[name] = doc[name].ToString();
                        }
                    }
                    dt.Rows.Add(row);
                }
            }

            return dt;
        }
    }
    }


