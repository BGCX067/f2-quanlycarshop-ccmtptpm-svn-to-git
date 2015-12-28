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
    public partial class ucBienNhanThanhToanTheoDot : UserControl
    {
        public int MaNhanVienHienTai;
        public ucBienNhanThanhToanTheoDot()
        {
            InitializeComponent();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if (txt_HD_MaHoaDon.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập mã số hóa đơn cần thanh toán.", "", MessageBoxButtons.OK);
                txt_HD_MaHoaDon.Focus();
                return;
            }

            int MaHoaDon = int.Parse(txt_HD_MaHoaDon.Text.Trim());
            HOADON_DTO hoadonDto = new HOADON_BUS().Select(MaHoaDon);
            if(hoadonDto != null)
            {
                btn_LapPhieu.Enabled = true;
                btn_HuyBo.Enabled = true;

                txt_HD_NgayLap.Text = hoadonDto.NgayLap.ToShortDateString();
                txt_HD_TongTien.Text = hoadonDto.TongTien.ToString();
                txt_HD_SoLanTra.Text = hoadonDto.SoLanTra.ToString();

                List<BIENNHAN_DTO> biennhanDtoList = new BIENNHAN_BUS().SelectAllByMaHoaDon(MaHoaDon);
                if (biennhanDtoList.Count != 0)
                {
                    lb_CacBienNhanTruoc.Visible = true;
                    txt_HD_SoLanDaTra.Text = biennhanDtoList.Count.ToString();
                    grid_CacDotDaThanhToan.Visible = true;
                    grid_CacDotDaThanhToan.DataSource = biennhanDtoList;
                    if(biennhanDtoList.Count == hoadonDto.SoLanTra)
                    {
                        txt_BN_SoTienTra.ReadOnly = true;
                        btn_LapPhieu.Enabled = false;
                        btn_HuyBo.Enabled = false;
                        MessageBox.Show("Hóa đơn " + MaHoaDon.ToString() + " đã được thanh toán đầy đủ", "", MessageBoxButtons.OK);
                    }
                }

                txt_BN_NgayTra.Text = DateTime.Today.ToShortDateString();
                
                //Customer's Info
                KHACHHANG_DTO khachhangDto = new KHACHHANG_BUS().SelectByMaHoaDon(MaHoaDon);
                txt_KH_MaKhachHang.Text = khachhangDto.Ma.ToString();
                txt_KH_TenKhachHang.Text = khachhangDto.HoTen;
                txt_KH_DiaChi.Text = khachhangDto.DiaChi;
                txt_KH_DienThoai.Text = khachhangDto.DienThoai;
                txt_KH_CMND.Text = khachhangDto.Cmnd;                       
                

                //Staff's Info
                NHANVIEN_DTO nhanvienDto = new NHANVIEN_BUS().SelectByMaHoaDon(MaHoaDon);
                txt_NV_MaNV_LapHoaDon.Text = nhanvienDto.Ma.ToString();
                txt_NV_TenNhanVien.Text = nhanvienDto.HoTen;

                LOAINHANVIEN_DTO loainvDto = new LOAINHANVIEN_BUS().Select(nhanvienDto.MaLoaiNhanVien);
                txt_NV_LoaiNhanVien.Text = loainvDto.TenLoaiNhanVien;

                //Thong tin bien nhan
                txt_BN_SoTienTra.Text = hoadonDto.TienTraMoiDot.ToString();
            }
        }

        private void btn_LapPhieu_Click(object sender, EventArgs e)
        {
            if(txt_BN_SoTienTra.Text != String.Empty)
            {
                BIENNHAN_DTO biennhanDto = new BIENNHAN_DTO();
                biennhanDto.MaHoaDon = int.Parse(txt_HD_MaHoaDon.Text);
                biennhanDto.MaNhanVien = int.Parse(txt_BN_MaNV_LapBienNhan.Text);
                biennhanDto.NgayThanhToan = DateTime.Today;
                biennhanDto.SoTien = decimal.Parse(txt_BN_SoTienTra.Text.Trim());

                new BIENNHAN_BUS().Insert(biennhanDto);
                txt_BN_MaBienNhan.Text = biennhanDto.Ma.ToString();
                MessageBox.Show("Đã lập xong biên nhận thanh toán đợt mới cho hóa đơn " + txt_HD_MaHoaDon.Text, "", MessageBoxButtons.OK);
                btn_LapPhieu.Enabled = false;
            }
        }

        private void ucBienNhanThanhToanTheoDot_Load(object sender, EventArgs e)
        {
            txt_BN_SoTienTra.ReadOnly = false;
            btn_LapPhieu.Enabled = false;
            btn_HuyBo.Enabled = false;
            txt_BN_MaNV_LapBienNhan.Text = MaNhanVienHienTai.ToString();
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            txt_BN_SoTienTra.Text = String.Empty;
            txt_HD_MaHoaDon.Text = String.Empty;
            txt_HD_NgayLap.Text = String.Empty;
            txt_HD_SoLanDaTra.Text = String.Empty;
            txt_HD_SoLanTra.Text = String.Empty;
            txt_HD_TongTien.Text = String.Empty;
            
            txt_KH_MaKhachHang.Text = String.Empty;
            txt_KH_TenKhachHang.Text = String.Empty;
            txt_KH_DienThoai.Text = String.Empty;
            txt_KH_DiaChi.Text = String.Empty;
            txt_KH_CMND.Text = String.Empty;

            txt_NV_MaNV_LapHoaDon.Text = String.Empty;
            txt_NV_TenNhanVien.Text = String.Empty;
            txt_NV_LoaiNhanVien.Text = String.Empty;
                  

            lb_CacBienNhanTruoc.Visible = false;
            grid_CacDotDaThanhToan.Visible = false;
            btn_LapPhieu.Enabled = false;
            btn_HuyBo.Enabled = false;
            txt_HD_MaHoaDon.Focus();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
