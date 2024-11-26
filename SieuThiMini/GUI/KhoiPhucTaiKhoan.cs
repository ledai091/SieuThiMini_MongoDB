using MongoDB.Bson;
using MongoDB.Driver;
using SieuThiMini.DAL;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class KhoiPhucTaiKhoan : Form
    {
        private readonly DataProvider dataProvider;
        private readonly string collectionName = "TaiKhoan";

        public KhoiPhucTaiKhoan()
        {
            InitializeComponent();
            dataProvider = DataProvider.Instance;
        }

        private void KhoiPhucTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDeletedAccounts();
        }

        private void LoadDeletedAccounts()
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("isDeleted", true);
                var deletedAccounts = dataProvider.GetCollection(collectionName)
                                                   .Find(filter)
                                                   .ToList();
                grid_TK.DataSource = deletedAccounts.Select(doc => new
                {
                    MaTaiKhoan = doc["_id"].ToString(),
                    TenTaiKhoan = doc["tenTaiKhoan"].AsString,
                    Quyen = doc["quyen"].AsInt32,
                    TrangThai = doc["isDeleted"].AsBoolean ? "Đã xóa" : "Hoạt động"
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách tài khoản đã xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            if (grid_TK.SelectedRows.Count > 0)
            {
                var selectedRow = grid_TK.SelectedRows[0];
                var accountId = selectedRow.Cells["MaTaiKhoan"].Value.ToString();

                DialogResult result = MessageBox.Show("Khôi phục tài khoản này?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(accountId));
                        var update = Builders<BsonDocument>.Update.Set("isDeleted", false);

                        dataProvider.UpdateDocument(collectionName, filter, update);
                        MessageBox.Show("Khôi phục tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDeletedAccounts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi khôi phục tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần khôi phục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadDeletedAccounts();
        }

        private void textBox_TimTK_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Eq("isDeleted", true),
                    Builders<BsonDocument>.Filter.Regex("tenTaiKhoan", new BsonRegularExpression(textBox_TimTK.Text, "i"))
                );

                var filteredAccounts = dataProvider.GetCollection(collectionName)
                                                    .Find(filter)
                                                    .ToList();

                grid_TK.DataSource = filteredAccounts.Select(doc => new
                {
                    MaTaiKhoan = doc["_id"].ToString(),
                    TenTaiKhoan = doc["tenTaiKhoan"].AsString,
                    Quyen = doc["quyen"].AsInt32,
                    TrangThai = doc["isDeleted"].AsBoolean ? "Đã xóa" : "Hoạt động"
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}