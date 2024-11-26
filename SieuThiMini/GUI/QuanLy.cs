using System;
using System.Windows.Forms;
using SieuThiMini.BLL;
using SieuThiMini.DTO;

namespace SieuThiMini.GUI
{
    public partial class QuanLy : Form
    {
        private int maNV;
        private NhanVienBLL nvBLL = new NhanVienBLL();
        private NhanVienDTO nvDTO;
        private TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        private TaiKhoanDTO tkDTO;

        public QuanLy(int maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.nvDTO = nvBLL.GetNVByMaNV(maNV);
            this.tkDTO = tkBLL.GetTKByMaTK(nvDTO.MaNhanVien);
        }

        private Form currentChildForm;
        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null) { currentChildForm.Close(); }
            currentChildForm = childForm; 
            childForm.TopLevel = false; 
            childForm.FormBorderStyle = FormBorderStyle.None; 
            childForm.Dock = DockStyle.Fill; 
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm; 
            childForm.BringToFront(); 
            childForm.Show();
        }
        private void QuanLy_Load(object sender, EventArgs e)
        {
            label_HoTenNV.Text = nvDTO.TenNhanVien;
            if(tkDTO.PhanQuyen == 1)
            {
                panel_TaiKhoan.Visible = false;
                panel_NhanVien.Visible = false;
            }
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formLogin = new LoginGUI();
            formLogin.Closed += (s, args) => this.Close();
            formLogin.Show();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new HoaDon());
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new SanPham());
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKe());
        }

        private void btn_LoaiSanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new LoaiSanPham());
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new TaiKhoan());
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new NhanVien());
        }

        private void btn_DonNhapHang_Click(object sender, EventArgs e)
        {
            openChildForm(new DonNhapHang());
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            openChildForm(new NhaCungCap());
        }
    }
}
