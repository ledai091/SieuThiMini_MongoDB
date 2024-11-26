using MongoDB.Driver;
using System;

namespace SieuThiMini.DAL
{
    class DataConnection
    {
        public MongoClient Client { get; private set; }
        public IMongoDatabase Database { get; private set; }

        private string ConnectionString = "mongodb://localhost:27017";
        private string DatabaseName = "sieu_thi_mini";

        public void OpenConnection()
        {
            try
            {
                if (Client == null)
                {
                    Client = new MongoClient(ConnectionString);
                    Database = Client.GetDatabase(DatabaseName);
                    Console.WriteLine("Kết nối MongoDB thành công.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi kết nối tới MongoDB: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            // MongoDB driver không yêu cầu đóng kết nối thủ công
            Console.WriteLine("Kết nối MongoDB đã được giải phóng.");
        }
    }
}