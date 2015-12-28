using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Layers.DTO;
using Layers.BUS;

namespace Quan_Ly_Car_Shop
{
    public partial class ucHoaDon : UserControl
    {
        frmTimKhachHang TimKhachHang;
        frmTimXe TimXe;
        KHACHHANG_DTO KhachHang;
        XE_DTO Xe;
        MAUXE_DTO MauXe;

        public ucHoaDon()
        {
            InitializeComponent();
            TimKhachHang = new frmTimKhachHang();
            TimXe = new frmTimXe();
        }

        private void bt_Tim_Click(object sender, EventArgs e)
        {
            TimKhachHang.ShowDialog(this);
            if (TimKhachHang.KhachHang != null)
            {
                KhachHang = TimKhachHang.KhachHang;
                txt_HoTen.Text = KhachHang.HoTen;
                txt_CMND.Text = KhachHang.Cmnd;
                txt_DiaChi.Text = KhachHang.DiaChi;
                txt_DienThoai.Text = KhachHang.DienThoai;
                combo_Phai.SelectedItem = KhachHang.PhaiChu;
            }
        }

        private void rd_LoaiKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_KhachHangCu.Checked)
            {
                txt_HoTen.ReadOnly = true;
                txt_HoTen.Text = "";
                txt_CMND.ReadOnly = true;
                txt_CMND.Text = "";
                txt_DienThoai.ReadOnly = true;
                txt_DienThoai.Text = "";
                txt_DiaChi.ReadOnly = true;
                txt_DiaChi.Text = "";
                combo_Phai.Enabled = false;
                bt_Tim.Enabled = true;
            }
            else
            {
                txt_HoTen.ReadOnly = false;
                txt_CMND.ReadOnly = false;
                txt_DienThoai.ReadOnly = false;
                txt_DiaChi.ReadOnly = false;
                combo_Phai.Enabled = true;
                bt_Tim.Enabled = false;
            }
        }

        private void bt_ThemXe_Click(object sender, EventArgs e)
        {
            TimXe.ShowDialog(this);
            if (TimXe.Xe != null)
            {
                Xe = TimXe.Xe;
                MauXe = TimXe.MauXe;
                grid_DanhSachXeMua.Rows.Add(1);
            }
        }

        private void bt_XoaXe_Click(object sender, EventArgs e)
        {
            if (grid_DanhSachXeMua.SelectedRows.Count > 0)
                foreach (DataGridViewRow Row in grid_DanhSachXeMua.SelectedRows)
                    grid_DanhSachXeMua.Rows.Remove(Row);
        }

        private void bt_XoaHetXe_Click(object sender, EventArgs e)
        {
            grid_DanhSachXeMua.Rows.Clear();
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            grid_DanhSachXeMua.Rows.Clear();
            KhachHang = null;
            txt_HoTen.Text = "";
            txt_CMND.Text = "";
            txt_DiaChi.Text = "";
            txt_DienThoai.Text = "";
            txt_ro_Thue.Text = "0";
            txt_ro_TongTien.Text = "0";
            txt_ro_TongTienTruocThue.Text = "0";
            txt_ro_TienTraMoiDot.Text = "0";
            combo_HinhThucThanToan.SelectedIndex = 0;
            updown_SoLanThanhToan.Enabled = false;
        }

        private void bt_ThemHoaDon_Click(object sender, EventArgs e)
        {
            if (rd_KhachHangCu.Checked)
            {
                if (KhachHang == null)
                {
                    MessageBox.Show("Chua có thông tin Khách Hàng", "Thi?u Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (grid_DanhSachXeMua.Rows.Count == 0)
                {
                    MessageBox.Show("Chua ch?n Xe mu?n d?t", "Thi?u Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ThemHoaDon();
            }
            else
            {
                if (txt_HoTen.Text == "")
                {
                    MessageBox.Show("Thi?u H? Tên Khách Hàng", "Thi?u Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_HoTen.Focus();
                    return;
                }
                if (txt_CMND.Text == "")
                {
                    MessageBox.Show("Thi?u CMND Khách Hàng", "Thi?u Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_CMND.Focus();
                    return;
                }
                if (txt_DiaChi.Text == "")
                {
                    MessageBox.Show("Thi?u Ð?a Ch? Khách Hàng", "Thi?u Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_DiaChi.Focus();
                    return;
                }
                KHACHHANG_DTO KhacHang = new KHACHHANG_DTO();
                KhachHang.HoTen = txt_HoTen.Text;
                KhachHang.DiaChi = txt_DiaChi.Text;
                KhachHang.DienThoai = txt_DienThoai.Text.Trim();
                KhachHang.LoaiKhachHang = false;
                if (combo_Phai.SelectedItem.ToString() == "Nam")
                    KhachHang.Phai = true;
                else
                    KhachHang.Phai = false;
                KHACHHANG_BUS BUS_KhachHang = new KHACHHANG_BUS();
                BUS_KhachHang.Insert(KhachHang);
                ThemHoaDon();
            }
        }

        private void ThemHoaDon()
        {
            if (grid_DanhSachXeMua.Rows.Count == 0)
            {
                MessageBox.Show("Chua có thông tin Xe mu?n mua", "Thi?u Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HOADON_DTO HoaDon = new HOADON_DTO();
            HoaDon.MaKhachHang = KhachHang.Ma;
            HoaDon.MaNhanVien = int.Parse(txt_ro_MaNhanVien.Text);
            HoaDon.NgayLap = DateTime.Today;
            if (combo_HinhThucThanToan.Text == "Thanh Toán 1 L?n")
            {
                HoaDon.SoLanTra = 0;
                HoaDon.KieuThanhToan = false;
                HoaDon.TienTraMoiDot = Decimal.Parse(txt_ro_TongTien.Text);
            }
            else
            {
                HoaDon.KieuThanhToan = true;
                HoaDon.SoLanTra = (int)updown_SoLanThanhToan.SelectedItem;
                HoaDon.TienTraMoiDot = Decimal.Parse(txt_ro_TongTien.Text) / Decimal.Parse(updown_SoLanThanhToan.Text);
            }
            HoaDon.TongTien = Decimal.Parse(txt_ro_TongTien.Text);
            new HOADON_BUS().Insert(HoaDon);
            CHITIETHOADON_BUS BUS_ChiTietHoaDon = new CHITIETHOADON_BUS();
            foreach (DataGridViewRow Row in grid_DanhSachXeMua.Rows)
            {
                CHITIETHOADON_DTO ChiTietHoaDon = new CHITIETHOADON_DTO();
                ChiTietHoaDon.MaMau = Row.Cells["MaMau"].Value.ToString();
                ChiTietHoaDon.MaHoaDon = HoaDon.Ma;
                ChiTietHoaDon.MaXe = (int)Row.Cells["MaXe"].Value;
                ChiTietHoaDon.SoLuong = (int)Row.Cells["SoLuong"].Value;
                ChiTietHoaDon.ThanhTien = (Decimal)Row.Cells["ThanhTien"].Value;
                BUS_ChiTietHoaDon.Insert(ChiTietHoaDon);
            }
            MessageBox.Show("Ðã thêm Hoá Ðon", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grid_DanhSachXeMua.Rows.Clear();
            txt_ro_TongTienTruocThue.Text = "0";
            txt_ro_TongTien.Text = "0";
            txt_ro_Thue.Text = "0";
            txt_ro_TienTraMoiDot.Text = "0";
        }

        private void combo_HinhThucThanToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_HinhThucThanToan.Text == "Thanh Toán 1 Lần")
            {
                updown_SoLanThanhToan.Enabled = false;
                txt_ro_TienTraMoiDot.ReadOnly = false;
            }
            else
            {
                updown_SoLanThanhToan.Enabled = true;
                txt_ro_TienTraMoiDot.ReadOnly = true;
            }
        }

        private void ucHoaDon_Load(object sender, EventArgs e)
        {
            combo_HinhThucThanToan.SelectedIndex = 0;
            txt_ro_TenNhanVien.Text = ((frmMain)Parent.Parent.Parent).NhanVien.HoTen;
            txt_ro_MaNhanVien.Text = ((frmMain)Parent.Parent.Parent).NhanVien.Ma.ToString();
            txt_NgayLap.Text = DateTime.Today.ToShortDateString();
        }

        void grid_DanhSachXeMua_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewRow Row = grid_DanhSachXeMua.Rows[e.RowIndex];
            Row.Cells["MaXe"].Value = Xe.Ma;
            Row.Cells["TenXe"].Value = Xe.TenXe;
            Row.Cells["HangXe"].Value = Xe.TenHangXe;
            Row.Cells["Mau"].Value = MauXe.Mau;
            Row.Cells["MaMau"].Value = MauXe.MaMau;
            Row.Cells["GiaTienBan"].Value = Xe.GiaTienBan;
            Row.Cells["SoLuong"].Value = TimXe.SoLuong;
            Decimal ThanhTien = TimXe.SoLuong * Xe.GiaTienBan;
            Decimal TongTienTruocThue = Decimal.Parse(txt_ro_TongTienTruocThue.Text) + ThanhTien;
            Decimal Thue = (TongTienTruocThue * 10) / 100;
            Row.Cells["ThanhTien"].Value = ThanhTien.ToString();
            txt_ro_TongTienTruocThue.Text = TongTienTruocThue.ToString();
            txt_ro_Thue.Text = Thue.ToString();
            txt_ro_TongTien.Text = (TongTienTruocThue + Thue).ToString();
        }
    }
}
