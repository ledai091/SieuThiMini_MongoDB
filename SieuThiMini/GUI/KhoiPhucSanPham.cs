using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using SieuThiMini.BLL;
using SieuThiMini.DAL;

namespace SieuThiMini.GUI
{
    public partial class KhoiPhucSanPham : Form
    {
        private DataProvider dp = DataProvider.Instance;
        private IMongoCollection<BsonDocument> sanPhamCollection;

        public KhoiPhucSanPham()
        {
            InitializeComponent();
        }

        private void KhoiPhucSanPham_Load(object sender, EventArgs e)
        {
            sanPhamCollection = dp.GetCollection("san_pham");
            LoadData();
        }

        private void LoadData()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("trang_thai", 0);
            var documents = sanPhamCollection.Find(filter).ToList();

            var dataTable = new DataTable();
            dataTable.Columns.Add("ma_san_pham");
            dataTable.Columns.Add("ten_san_pham");
            dataTable.Columns.Add("ma_loai");
            dataTable.Columns.Add("so_luong");
            dataTable.Columns.Add("gia");
            dataTable.Columns.Add("gia_nhap");

            foreach (var doc in documents)
            {
                dataTable.Rows.Add(
                    Convert.ToInt32(doc["ma_san_pham"]),
                    doc["ten_san_pham"].AsString,
                    doc["ma_loai"].AsInt32,
                    doc["so_luong"].AsInt32,
                    doc["gia"].AsInt32,
                    doc["gia_nhap"].AsInt32
                );
            }

            grid_SanPham.DataSource = dataTable;

            // Cấu hình hiển thị DataGridView
            grid_SanPham.Columns["ma_san_pham"].HeaderText = "Mã sản phẩm";
            grid_SanPham.Columns["ten_san_pham"].HeaderText = "Tên sản phẩm";
            grid_SanPham.Columns["ma_loai"].HeaderText = "Mã loại";
            grid_SanPham.Columns["so_luong"].HeaderText = "Số lượng";
            grid_SanPham.Columns["gia"].HeaderText = "Giá";
            grid_SanPham.Columns["gia_nhap"].HeaderText = "Giá nhập";

            foreach (DataGridViewColumn column in grid_SanPham.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            grid_SanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            if (grid_SanPham.SelectedRows.Count > 0)
            {
                int selectedRowIndex = grid_SanPham.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_SanPham.Rows[selectedRowIndex];
                int maSP = int.Parse(selectedRow.Cells["ma_san_pham"].Value.ToString());

                var filter = Builders<BsonDocument>.Filter.Eq("ma_san_pham", maSP);
                var update = Builders<BsonDocument>.Update.Set("trang_thai", 1);

                sanPhamCollection.UpdateOne(filter, update);
                MessageBox.Show("Khôi phục sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần khôi phục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox_TimSanPham_TextChanged(object sender, EventArgs e)
        {
            string valueQuery = textBox_TimSanPham.Text;
            if (!string.IsNullOrEmpty(valueQuery))
            {
                var filter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Eq("trang_thai", 0),
                    Builders<BsonDocument>.Filter.Or(
                        Builders<BsonDocument>.Filter.Eq("ma_san_pham", valueQuery),
                        Builders<BsonDocument>.Filter.Eq("ma_loai", valueQuery),
                        Builders<BsonDocument>.Filter.Regex("ten_san_pham", new BsonRegularExpression(valueQuery, "i"))
                    )
                );

                var documents = sanPhamCollection.Find(filter).ToList();

                var dataTable = new DataTable();
                dataTable.Columns.Add("ma_san_pham");
                dataTable.Columns.Add("ten_san_pham");
                dataTable.Columns.Add("ma_loai");
                dataTable.Columns.Add("so_luong");
                dataTable.Columns.Add("gia");
                dataTable.Columns.Add("gia_nhap");

                foreach (var doc in documents)
                {
                    dataTable.Rows.Add(
                        doc["ma_san_pham"].AsInt32,
                        doc["ten_san_pham"].AsString,
                        doc["ma_loai"].AsInt32,
                        doc["so_luong"].AsInt32,
                        doc["gia"].AsDouble,
                        doc["gia_nhap"].AsDouble
                    );
                }

                grid_SanPham.DataSource = dataTable;
            }
        }
    }
}
