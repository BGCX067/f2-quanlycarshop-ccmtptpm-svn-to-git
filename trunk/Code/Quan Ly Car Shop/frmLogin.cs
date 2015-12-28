using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Layers.BUS;
using Layers.DAO;
using Layers.DTO;

namespace Quan_Ly_Car_Shop
{
    public partial class frmLogin : Form
    {
        public NHANVIEN_DTO NhanVien;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            if (chk_TenServer.Checked)
                AbstractDAO.ConnectionString = "Persist Security Info=False;Integrated Security=SSPI;Initial Catalog=QUAN_LY_CAR_SHOP;server=" + txt_ServerName.Text;
            NhanVien = null;
            if (txt_UserName.Text == "")
            {
                MessageBox.Show("Xin Nhập Tên Đăng Nhập", "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_UserName.Focus();
                return;
            }
            if (txt_Password.Text == "")
            {
                MessageBox.Show("Xin Nhập Mật Khẩu", "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Password.Focus();
                return;
            }
            NHANVIEN_BUS BUS_NhanVien = new NHANVIEN_BUS();
            NhanVien = BUS_NhanVien.SelectByUserNamePassword(txt_UserName.Text, txt_Password.Text);
            if (NhanVien == null)
            {
                MessageBox.Show("Đăng nhập thất bại, xin xem lại Tên Đăng Nhập & Mật Khẩu", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Close();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_UserName_Leave(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "")
                lb_UserNameRequired.Visible = true;
            else
                lb_UserNameRequired.Visible = false;
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
                lb_PasswordRequired.Visible = true;
            else
                lb_PasswordRequired.Visible = false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Form Cha = Owner;
            Location = new Point((int)((Cha.Width - Width) / 2) + Cha.Location.X, (int)((Cha.Height - Height) / 2) + Cha.Location.Y);
        }

        private void chk_TenServer_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_TenServer.Checked)
                txt_ServerName.Enabled = true;
            else
                txt_ServerName.Enabled = false;
        }
    }
}