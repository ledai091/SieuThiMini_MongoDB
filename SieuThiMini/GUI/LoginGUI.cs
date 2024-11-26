using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using SieuThiMini.BLL;
using SieuThiMini.DAL;
using SieuThiMini.DTO;

namespace SieuThiMini.GUI
{
    public partial class LoginGUI : Form
    {
        private TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private TaiKhoanDTO tkDTO;

        public LoginGUI()
        {
            InitializeComponent();
        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "quanly1";
            txtPassword.Text = "123456";
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                tkDTO = tkBLL.SignIn(txtUsername.Text, txtPassword.Text);
                if (tkDTO == null)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đăng nhập thành công.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (tkDTO.PhanQuyen == 2)
            {
                
                this.Hide();
                NhanVienBLL nvBLL = new NhanVienBLL();
                List<NhanVienDTO> nvDTOList = nvBLL.GetNVByMaTK(tkDTO.MaTaiKhoan);

                if (nvDTOList.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên phù hợp với tài khoản này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Show();
                    return;
                }

                NhanVienDTO nvDTO = nvDTOList[0];
                var formBH = new BanHang(nvDTO.MaNhanVien);
                formBH.FormClosed += (s, args) => this.Close();
                formBH.Show();
            }
            else
            {

                this.Hide();
                NhanVienBLL nvBLL = new NhanVienBLL();
                List<NhanVienDTO> nvDTOlist = nvBLL.GetNVByMaTK(tkDTO.MaTaiKhoan);

                if (nvDTOlist.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy quản lý phù hợp với tài khoản này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Show();
                    return;
                }

                NhanVienDTO nvDTO = nvDTOlist[0];
                var formQL = new QuanLy(nvDTO.MaNhanVien);
                formQL.FormClosed += (s, args) => this.Close();
                formQL.Show();
            }

        }

    }
}
