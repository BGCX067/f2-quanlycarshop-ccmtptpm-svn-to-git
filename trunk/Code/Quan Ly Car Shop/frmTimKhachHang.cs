using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Layers.BUS;
using Layers.DTO;

namespace Quan_Ly_Car_Shop
{
    public partial class frmTimKhachHang : Form
    {
        public KHACHHANG_DTO KhachHang;

        public frmTimKhachHang()
        {
            InitializeComponent();
        }

        private void bt_Tim_Click(object sender, EventArgs e)
        {
            KhachHang = null;
            if (rd_MaKhachHang.Checked)
            {
                if (txt_MaKhachHang.Text == "")
                {
                    MessageBox.Show("Chưa nhập Mã Khách Hàng", "Thiếu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_MaKhachHang.Focus();
                    return;
                }
                int Ma = 0;
                try
                {
                    Ma = int.Parse(txt_MaKhachHang.Text);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Mã Khách Hàng là số nguyên dương", "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_MaKhachHang.SelectAll();
                    txt_MaKhachHang.Focus();
                    return;
                }
                KhachHang = new KHACHHANG_BUS().Select(Ma);
                Close();
            }
            else
            {
                if (txt_HoTen.Text == "")
                {
                    MessageBox.Show("Phải nhập Họ Tên Khách Hàng", "Thiếu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_HoTen.Focus();
                    return;
                }
                int Dem = 0;
                if (txt_CMND.Text == "")
                    Dem++;
                if (txt_DiaChi.Text == "")
                    Dem++;
                if (Dem == 2)
                {
                    MessageBox.Show("Phải nhập tối thiểu CMND or Địa Chỉ", "Thiếu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_CMND.Focus();
                    return;
                }
                KhachHang = new KHACHHANG_BUS().SelectByThongTin(txt_HoTen.Text, txt_DiaChi.Text, txt_CMND.Text);
                Close();
            }
        }

        private void rd_LoaiSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_MaKhachHang.Checked == true)
            {
                gb_ThongTinKhachHang.Enabled = false;
                txt_MaKhachHang.Enabled = true;
            }
            else
            {
                gb_ThongTinKhachHang.Enabled = true;
                txt_MaKhachHang.Enabled = false;
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}