﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SieuThiMini.DTO;
using SieuThiMini.DAL;
using SieuThiMini.BLL;

namespace SieuThiMini.GUI
{
    public partial class BanHang : Form
    {
        private DataProvider dp = new DataProvider();
        int maNV; 
        public BanHang(int maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }


        private void BanHang_Load(object sender, EventArgs e)
        {
            cbo_LoaiMon.Items.Add("Tất cả");
            cbo_LoaiMon.SelectedIndex = 0;
            LoaiSanPhamBLL loaispBLL = new LoaiSanPhamBLL();
            List<LoaiSanPhamDTO> listLoaiSP = loaispBLL.GetList();
            foreach(LoaiSanPhamDTO loaisp in listLoaiSP)
            {
                cbo_LoaiMon.Items.Add(loaisp.TenLoai);
            }

            SanPhamBLL spBLL = new SanPhamBLL();
            List<SanPhamDTO> listSP = spBLL.GetList();
            listSP.RemoveAll(x => x.SoLuong < 1);
            grid_SanPham.DataSource = listSP;
            grid_SanPham.Columns["MaLoai"].Visible = false;
            grid_SanPham.Columns["TrangThai"].Visible = false;
            grid_SanPham.Columns["GiaNhap"].Visible = false;
            grid_SanPham.CurrentCell.Selected = false;
            grid_SanPham.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
            grid_SanPham.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            grid_SanPham.Columns["SoLuong"].HeaderText = "Số lượng";
            grid_SanPham.Columns["Gia"].HeaderText = "Giá";
            List<CTHoaDonDTO> dsCTHD = new List<CTHoaDonDTO>();
            grid_HoaDon.DataSource = dsCTHD;
            grid_HoaDon.Columns["MaHoaDon"].Visible = false;
            grid_HoaDon.Columns["Id"].Visible = false;
            grid_HoaDon.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
            grid_HoaDon.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            grid_HoaDon.Columns["SoLuong"].HeaderText = "Số lượng";
            grid_HoaDon.Columns["GiaSanPham"].HeaderText = "Giá";
            grid_HoaDon.Columns["ThanhTien"].HeaderText = "Thành tiền";
            grid_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void update()
        {
            SanPhamBLL spBLL = new SanPhamBLL();
            LoaiSanPhamBLL loaispBLL = new LoaiSanPhamBLL();
            List<SanPhamDTO> listSP = spBLL.GetList();
            listSP.RemoveAll(x => x.SoLuong < 1);

            if (cbo_LoaiMon.SelectedIndex != 0)
            {
                string LoaiMonSelected = cbo_LoaiMon.GetItemText(cbo_LoaiMon.SelectedItem);
                var loaiSPList = loaispBLL.GetLSPByName(LoaiMonSelected);

                if (loaiSPList != null && loaiSPList.Count > 0)
                {
                    int maLoai = loaiSPList[0].MaLoai;
                    listSP.RemoveAll(x => x.MaLoai != maLoai);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy loại sản phẩm phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (listSP == null || listSP.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grid_SanPham.DataSource = null;
                return;
            }

            grid_SanPham.DataSource = listSP;

            if (grid_SanPham.Rows.Count > 0)
            {
                grid_SanPham.CurrentCell = grid_SanPham.Rows[0].Cells[0];
                grid_SanPham.CurrentCell.Selected = false;
            }
        }

        public void update_TT()
        {
            if (grid_HoaDon.Rows.Count == 0)
            {
                label_TT.Text = "0";
                return;
            }
            decimal tongtien = 0;
            foreach (DataGridViewRow row in grid_HoaDon.Rows)
            {
                tongtien += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
            }
            label_TT.Text = tongtien.ToString();
        }
        private void cbo_LoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }
        private void btn_ThemMon_Click(object sender, EventArgs e)
        {
            if(grid_SanPham.CurrentCell == null)
            {
                MessageBox.Show("Chọn sản phẩm cần thêm");
                return;
            }
            else if(ud_SoLuong.Value == 0)
            {
                MessageBox.Show("Số lượng sản phẩm đã hết.");
                return;
            }
            DataGridViewRow selectedrow = grid_SanPham.Rows[grid_SanPham.CurrentRow.Index];
            foreach(DataGridViewRow dr in grid_HoaDon.Rows)
            {
                if (Convert.ToInt32(dr.Cells["MaSanPham"].Value) == Convert.ToInt32(selectedrow.Cells["MaSanPham"].Value))
                {
                    dr.Cells["SoLuong"].Value = Convert.ToInt32(dr.Cells["SoLuong"].Value) + Convert.ToInt32(ud_SoLuong.Value);
                    dr.Cells["ThanhTien"].Value = Convert.ToInt32(dr.Cells["SoLuong"].Value) * Convert.ToDecimal(dr.Cells["GiaSanPham"].Value);
                    ud_SoLuong.Maximum = Convert.ToInt32(selectedrow.Cells["SoLuong"].Value) - Convert.ToInt32(dr.Cells["SoLuong"].Value);
                    grid_HoaDon.CurrentCell.Selected = false;
                    update_TT();
                    return;
                }
            }
            int soLuong = Convert.ToInt32(ud_SoLuong.Value);
            int maSanPham = Convert.ToInt32(selectedrow.Cells["MaSanPham"].Value);
            string tenSanPham = selectedrow.Cells["TenSanPham"].Value.ToString();
            decimal gia = Convert.ToDecimal(selectedrow.Cells["Gia"].Value);
            decimal thanhTien = soLuong * gia;
            HoaDonBLL hdBLL = new HoaDonBLL();
            List<HoaDonDTO> dsHoaDon = hdBLL.GetList();
            CTHoaDonDTO cthd = new CTHoaDonDTO(dsHoaDon.Count - 1, maSanPham, tenSanPham, soLuong, (int)gia, (int)thanhTien);
            List<CTHoaDonDTO> dsCTHD = new List<CTHoaDonDTO>();
            dsCTHD.AddRange((List<CTHoaDonDTO>)grid_HoaDon.DataSource);
            dsCTHD.Add(cthd);
            grid_HoaDon.DataSource = dsCTHD;
            ud_SoLuong.Maximum = Convert.ToInt32(selectedrow.Cells["SoLuong"].Value) - soLuong;
            update_TT();
            return;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grid_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow dr in grid_HoaDon.Rows)
            {
                if (Convert.ToInt32(dr.Cells["MaSanPham"].Value) == Convert.ToInt32(grid_SanPham.Rows[e.RowIndex].Cells["MaSanPham"].Value))
                {
                    ud_SoLuong.Maximum = Convert.ToDecimal(grid_SanPham.Rows[e.RowIndex].Cells["SoLuong"].Value) - Convert.ToDecimal(dr.Cells["SoLuong"].Value);
                    if (ud_SoLuong.Maximum > 0)
                    {
                        ud_SoLuong.Value = 1;
                    }
                    return;
                }
            }
            ud_SoLuong.Maximum = Convert.ToDecimal(grid_SanPham.Rows[e.RowIndex].Cells["SoLuong"].Value);
            if (ud_SoLuong.Maximum > 0)
            {
                ud_SoLuong.Value = 1;
            }
        }

        private void btn_XoaMon_Click(object sender, EventArgs e)
        {
            if (grid_HoaDon.CurrentCell == null)
            {
                MessageBox.Show("Chọn sản phẩm cần xóa");
                return;
            }

            // Get the selected product in the HoaDon grid
            int maSanPham = Convert.ToInt32(grid_HoaDon.Rows[grid_HoaDon.CurrentRow.Index].Cells["MaSanPham"].Value);

            // Remove the selected product from the data source
            List<CTHoaDonDTO> dsCTHD = (List<CTHoaDonDTO>)grid_HoaDon.DataSource;
            dsCTHD.RemoveAll(x => x.MaSanPham == maSanPham);

            // Update the data source of the HoaDon grid
            grid_HoaDon.DataSource = null; // Clear existing binding
            grid_HoaDon.DataSource = dsCTHD; // Bind the updated list

            // Update the total amount
            update_TT();

            // Optionally, reset selection and update other controls if needed
            grid_SanPham.CurrentCell.Selected = false;
        }


        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if(grid_HoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Chưa chọn sản phẩm nào");
                return;
            }
            DateTime ngayXuat = DateTime.Now;
            HoaDonDTO hdDTO = new HoaDonDTO(0, ngayXuat, maNV, Convert.ToInt32(label_TT.Text), 1);
            HoaDonBLL hdBLL = new HoaDonBLL();
            hdBLL.Insert(hdDTO);
            List<HoaDonDTO> lhdDTO = hdBLL.GetList();
            HoaDonDTO hdDTO_l = lhdDTO[lhdDTO.Count - 1];
            CTHoaDonBLL cthdBLL = new CTHoaDonBLL();
            List<CTHoaDonDTO> dsCTHD = new List<CTHoaDonDTO>();
            dsCTHD = (List<CTHoaDonDTO>)grid_HoaDon.DataSource;
            SanPhamBLL spBLL = new SanPhamBLL();
            
            foreach(CTHoaDonDTO cthd in dsCTHD)
            {
                cthd.MaHoaDon = hdDTO_l.MaHoaDon;
                SanPhamDTO sp = spBLL.GetSPByMaSP(cthd.MaSanPham);
                spBLL.UpdateSoLuong(cthd.MaSanPham, sp.SoLuong - cthd.SoLuong);
                cthdBLL.Insert(cthd);
            }

            List<SanPhamDTO> dsSp = spBLL.GetList();
            dsSp.RemoveAll(x => x.SoLuong < 1);
            grid_SanPham.DataSource = dsSp;
            grid_SanPham.CurrentCell.Selected = false;

            lhdDTO.Clear();
            List<CTHoaDonDTO> temp = new List<CTHoaDonDTO>();
            grid_HoaDon.DataSource = temp;

            update_TT();
            MessageBox.Show("Thanh toán thành công.");
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string input = maskedTextBox1.Text;
            SanPhamBLL spBLL = new SanPhamBLL();
            List<SanPhamDTO> dsSp = spBLL.GetList();
            dsSp.RemoveAll(x => x.SoLuong < 1);
            var filtered = dsSp.Where(x => x.TenSanPham.ToLower().Contains(input.ToLower())).ToList();
            grid_SanPham.DataSource = filtered;
        }
    }
}
