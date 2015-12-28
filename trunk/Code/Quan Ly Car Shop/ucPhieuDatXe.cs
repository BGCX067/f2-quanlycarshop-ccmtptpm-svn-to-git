using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Layers.BUS;
using Layers.DTO;

namespace Quan_Ly_Car_Shop
{
    public partial class ucPhieuDatXe : UserControl
    {
        frmTimKhachHang TimKhachHang;
        frmTimXe TimXe;
        KHACHHANG_DTO KhachHang;
        XE_DTO Xe;
        MAUXE_DTO MauXe;

        public ucPhieuDatXe()
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
                KhachHang =  TimKhachHang.KhachHang;
                txt_HoTen.Text = KhachHang.HoTen;
                txt_CMND.Text = KhachHang.Cmnd;
                txt_DiaChi.Text = KhachHang.DiaChi;
                txt_DienThoai.Text = KhachHang.DienThoai;
                combo_Phai.SelectedItem = KhachHang.PhaiChu;
            }
        }

        private void rd_LoaiKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if(rd_KhachHangCu.Checked)
            {
                txt_HoTen.ReadOnly = true;
                txt_CMND.ReadOnly = true;
                txt_DienThoai.ReadOnly = true;
                txt_DiaChi.ReadOnly = true;
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
            if (rd_KhachHangCu.Checked)
            {
                if (KhachHang == null)
                {
                    MessageBox.Show("Cần cung cấp thông tin Khách Hàng trước khi chọn xe", "Yêu Cầu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (txt_HoTen.Text == "" || txt_DiaChi.Text == "" || txt_CMND.Text == "")
                {
                    MessageBox.Show("Cần cung cấp thông tin trước khi chọn xe", "Yêu Cầu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            TimXe.ShowDialog(this);
            if (TimXe.Xe != null)
            {
                Xe = TimXe.Xe;
                MauXe = TimXe.MauXe;
                grid_DanhSachXeDat.Rows.Add(1);
            }
        }

        private void ucPhieuDatXe_Load(object sender, EventArgs e)
        {
            combo_Phai.SelectedItem = "Nam";
        }

        private void bt_XoaXe_Click(object sender, EventArgs e)
        {
            if (grid_DanhSachXeDat.SelectedRows.Count > 0)
                foreach (DataGridViewRow Row in grid_DanhSachXeDat.SelectedRows)
                    grid_DanhSachXeDat.Rows.Remove(Row);
        }

        private void bt_XoaHetXe_Click(object sender, EventArgs e)
        {
            grid_DanhSachXeDat.Rows.Clear();
        }

        private void bt_ThemDonDatXe_Click(object sender, EventArgs e)
        {
            if (rd_KhachHangCu.Checked)
            {
                if (KhachHang == null)
                {
                    MessageBox.Show("Chưa có thông tin Khách Hàng", "Thiếu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(grid_DanhSachXeDat.Rows.Count==0)
                {
                    MessageBox.Show("Chưa chọn Xe muốn đặt", "Thiếu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ThemDonDatHang();
            }
            else
            {
                if (txt_HoTen.Text == "")
                {
                    MessageBox.Show("Thiếu Họ Tên Khách Hàng", "Thiếu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_HoTen.Focus();
                    return;
                }
                if (txt_CMND.Text == "")
                {
                    MessageBox.Show("Thiếu CMND Khách Hàng", "Thiếu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_CMND.Focus();
                    return;
                }
                if (txt_DiaChi.Text == "")
                {
                    MessageBox.Show("Thiếu Địa Chỉ Khách Hàng", "Thiếu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ThemDonDatHang();
            }
        }

        private void ThemDonDatHang()
        {
            if (grid_DanhSachXeDat.Rows.Count == 0)
            {
                MessageBox.Show("Chua có thông tin Xe muốn đặt", "Thiếu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PHIEUDATXE_DTO PhieuDatXe = new PHIEUDATXE_DTO();
            PhieuDatXe.MaKhachHang = KhachHang.Ma;
            PhieuDatXe.MaNhanVien = int.Parse(txt_ro_MaNhanVien.Text);
            PhieuDatXe.NgayDat = DateTime.Today;
            PhieuDatXe.NgayHenLay = dtpicker_NgayHenLay.Value;
            PhieuDatXe.TienTraTruoc = Decimal.Parse(txt_TienTraTruoc.Text);
            PhieuDatXe.TongTien = Decimal.Parse(txt_ro_TongTien.Text);
            new PHIEUDATXE_BUS().Insert(PhieuDatXe);
            CHITIETPHIEUDATXE_BUS BUS_ChiTietPhieuDatXe = new CHITIETPHIEUDATXE_BUS();
            foreach (DataGridViewRow Row in grid_DanhSachXeDat.Rows)
            {
                CHITIETPHIEUDATXE_DTO ChiTietPhieuDatXe = new CHITIETPHIEUDATXE_DTO();
                ChiTietPhieuDatXe.MaMau = Row.Cells["MaMau"].Value.ToString();
                ChiTietPhieuDatXe.MaPhieuDat = PhieuDatXe.Ma;
                ChiTietPhieuDatXe.MaXe = (int)Row.Cells["MaXe"].Value;
                ChiTietPhieuDatXe.SoLuong = (int)Row.Cells["SoLuong"].Value;
                ChiTietPhieuDatXe.TongTien = (Decimal)Row.Cells["ThanhTien"].Value;
                BUS_ChiTietPhieuDatXe.Insert(ChiTietPhieuDatXe);
            }
            MessageBox.Show("Ðã thêm Phiếu Ðặt Xe", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grid_DanhSachXeDat.Rows.Clear();
            txt_ro_TongTienTruocThue.Text = "";
            txt_ro_TongTien.Text = "";
            txt_ro_Thue.Text = "";
            txt_TienTraTruoc.Text = "";
            txt_ro_TienConLai.Text = "";
        }

        private void txt_TienTraTruoc_TextChanged(object sender, EventArgs e)
        {
            Decimal TienTraTruoc = 0;
            try
            {
                TienTraTruoc = Decimal.Parse(txt_TienTraTruoc.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Tiền trả trước phải là số ", "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TienTraTruoc.SelectAll();
                txt_TienTraTruoc.Focus();
                return;
            }
            txt_ro_TienConLai.Text = (Decimal.Parse(txt_ro_TongTien.Text) - TienTraTruoc).ToString();
        }

        private void txt_DienThoai_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txt_DienThoai.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Số Điện Thoại không hợp lệ", "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DienThoai.SelectAll();
            }
        }

        public void SetNhanVien(NHANVIEN_DTO NhanVien)
        {
            txt_ro_TenNhanVien.Text = NhanVien.HoTen;
            txt_ro_MaNhanVien.Text = NhanVien.Ma.ToString();
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            grid_DanhSachXeDat.Rows.Clear();
            KhachHang = null;
            txt_HoTen.Text = "";
            txt_CMND.Text = "";
            txt_DiaChi.Text = "";
            txt_DienThoai.Text = "";
            txt_ro_Thue.Text = "0";
            txt_ro_TienConLai.Text = "0";
            txt_ro_TongTien.Text = "0";
            txt_ro_TongTienTruocThue.Text = "0";
            txt_TienTraTruoc.Text = "0";
        }

        void grid_DanhSachXeDat_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewRow Row = grid_DanhSachXeDat.Rows[e.RowIndex];
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
