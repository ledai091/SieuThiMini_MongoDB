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
        private readonly string collectionName = "tai_khoan";

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
                var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 0);
                var deletedAccounts = dataProvider.GetCollection(collectionName)
                                                   .Find(filter)
                                                   .ToList();
                grid_TK.DataSource = deletedAccounts.Select(doc => new
                {
                    MaTaiKhoan = doc["ma_tai_khoan"].ToString(),
                    TenTaiKhoan = doc["ten_tai_khoan"].AsString,
                    Quyen = doc["phan_quyen"].AsInt32,
                    TrangThai = doc["trang_thai"].AsInt32
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
                int accountId = Convert.ToInt32(selectedRow.Cells["MaTaiKhoan"].Value.ToString());

                DialogResult result = MessageBox.Show("Khôi phục tài khoản này?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var filter = Builders<BsonDocument>.Filter.Eq("ma_tai_khoan", accountId);
                        var update = Builders<BsonDocument>.Update.Set("trang_thai", 1);

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
                    Builders<BsonDocument>.Filter.Eq("trang_thai", 0),
                    Builders<BsonDocument>.Filter.Regex("ten_tai_khoan", new BsonRegularExpression(textBox_TimTK.Text, "i"))
                );

                var filteredAccounts = dataProvider.GetCollection(collectionName)
                                                    .Find(filter)
                                                    .ToList();

                grid_TK.DataSource = filteredAccounts.Select(doc => new
                {
                    MaTaiKhoan = doc["ma_tai_khoan"].ToString(),
                    TenTaiKhoan = doc["ten_tai_khoan"].AsString,
                    Quyen = doc["phan_quyen"].AsInt32,
                    TrangThai = doc["trang_thai"].AsInt32
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}