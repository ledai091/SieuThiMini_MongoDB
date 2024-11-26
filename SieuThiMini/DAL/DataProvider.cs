using MongoDB.Driver;
using MongoDB.Bson;
using System;

namespace SieuThiMini.DAL
{
    class DataProvider
    {
        private static DataProvider _instance;
        public static DataProvider Instance
        {
            get
            {
                if (_instance == null) _instance = new DataProvider();
                return DataProvider._instance;
            }
            private set { DataProvider._instance = value; }
        }

        private readonly DataConnection _dataConnection;

        public DataProvider()
        {
            _dataConnection = new DataConnection();
            _dataConnection.OpenConnection();
        }

        public IMongoCollection<BsonDocument> GetCollection(string collectionName)
        {
            try
            {
                return _dataConnection.Database.GetCollection<BsonDocument>(collectionName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy collection: " + ex.Message);
                throw;
            }
        }

        public void InsertDocument(string collectionName, BsonDocument document)
        {
            try
            {
                var collection = GetCollection(collectionName);
                collection.InsertOne(document);
                Console.WriteLine("Thêm tài liệu thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm tài liệu: " + ex.Message);
            }
        }

        public void UpdateDocument(string collectionName, FilterDefinition<BsonDocument> filter, UpdateDefinition<BsonDocument> update)
        {
            try
            {
                var collection = GetCollection(collectionName);
                collection.UpdateOne(filter, update);
                Console.WriteLine("Cập nhật tài liệu thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật tài liệu: " + ex.Message);
            }
        }

        public void DeleteDocument(string collectionName, FilterDefinition<BsonDocument> filter)
        {
            try
            {
                var collection = GetCollection(collectionName);
                collection.DeleteOne(filter);
                Console.WriteLine("Xóa tài liệu thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa tài liệu: " + ex.Message);
            }
        }

        public void QueryDocuments(string collectionName, FilterDefinition<BsonDocument> filter)
        {
            try
            {
                var collection = GetCollection(collectionName);
                var documents = collection.Find(filter).ToList();

                Console.WriteLine($"Tìm thấy {documents.Count} tài liệu:");
                foreach (var doc in documents)
                {
                    Console.WriteLine(doc.ToJson());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi truy vấn tài liệu: " + ex.Message);
            }
        }
    }
}