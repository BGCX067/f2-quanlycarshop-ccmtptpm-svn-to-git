using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Layers.DTO;
using Layers.BUS;

namespace Quan_Ly_Car_Shop
{
    public partial class frmTimXe : Form
    {
        public XE_DTO Xe;
        public int SoLuong;
        public MAUXE_DTO MauXe;

        public frmTimXe()
        {
            InitializeComponent();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Tim_Click(object sender, EventArgs e)
        {
            Xe = null;
            if (txt_TuKhoa.Text == "")
            {
                MessageBox.Show("Chưa nhập từ khoá", "Thiếu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TuKhoa.Focus();
                return;
            }
            if (rd_MaXe.Checked)
            {
                int Ma = 0;
                try
                {
                    Ma = int.Parse(txt_TuKhoa.Text);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Mã Xe phải là số nguyên dương", "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_TuKhoa.SelectAll();
                    txt_TuKhoa.Focus();
                    return;
                }
                Xe = new XE_BUS().Select(Ma);
            }
            else
                Xe = new XE_BUS().SelectByTenXe(txt_TuKhoa.Text);
            if (Xe != null)
            {
                txt_ro_MaXe.Text = Xe.Ma.ToString();
                txt_ro_TenXe.Text = Xe.TenXe;
                txt_ro_LoaiDiaHinh.Text = Xe.LoaiDiaHinh;
                txt_ro_KieuXe.Text = Xe.TenKieuXe;
                txt_ro_HangSanXuat.Text = Xe.TenHangXe;
                txt_ro_DoiXe.Text = Xe.DoiXe.ToString();
                txt_ro_SoLuong.Text = Xe.SoLuong.ToString();
                txt_ro_ChiSoNhienLieu.Text = Xe.ChiSoNhienLieu.ToString();
                txt_ro_LoaiDiaHinh.Text = Xe.LoaiDiaHinh;
                txt_ro_TocDoToiDa.Text = Xe.MaxSpeed.ToString();
                txt_ro_SoLuong.Text = Xe.SoLuong.ToString();
                combo_Mau.DataSource = new MAUXE_BUS().SelectAllByMaXe(Xe.Ma);
                if (combo_Mau.DataSource != null)
                {
                    combo_Mau.Enabled = true;
                    txt_ro_SoLuongTheoMau.Text = MauXe.SoLuong.ToString();
                    bt_XacNhan.Enabled = true;
                    updown_SoLuong.Enabled = true;
                }
                else
                {
                    combo_Mau.Enabled = false;
                    txt_ro_SoLuongTheoMau.Text = "0";
                    bt_XacNhan.Enabled = false;
                    updown_SoLuong.Items.Clear();
                    updown_SoLuong.Enabled = false;
                }                
            }
        }

        private void combo_Mau_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_ro_SoLuongTheoMau.Text = ((MAUXE_DTO)combo_Mau.SelectedItem).SoLuong.ToString();
            MauXe = (MAUXE_DTO)combo_Mau.SelectedItem;
            updown_SoLuong.Items.Clear();
            for (int i = MauXe.SoLuong; i >= 1; i--)
                updown_SoLuong.Items.Add(i);
            updown_SoLuong.SelectedItem = 1;
        }

        private void bt_XacNhan_Click(object sender, EventArgs e)
        {
            SoLuong = int.Parse(updown_SoLuong.Text);
            Close();
        }
    }
}