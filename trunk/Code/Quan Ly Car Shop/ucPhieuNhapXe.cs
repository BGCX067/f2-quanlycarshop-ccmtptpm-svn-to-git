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
    public partial class ucPhieuNhapXe : UserControl
    {
        public ucPhieuNhapXe()
        {
            InitializeComponent();
        }

        private void ucPhieuNhapXe_Load(object sender, EventArgs e)
        {
            btn_LapPhieu.Enabled = false;
            btn_HuyBo.Enabled = false;
            txt_MaDDH.Focus();            
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if(txt_MaDDH.Text != String.Empty)
            {
                DONDATHANG_DTO dondathangDto = new DONDATHANG_DTO();
                dondathangDto.Ma = int.Parse(txt_MaDDH.Text.Trim());
                dondathangDto=new DONDATHANG_BUS().Select(dondathangDto.Ma);
                if (dondathangDto != null)
                {
                    MessageBox.Show("Không có đơn đặt hàng có mã này. Vui lòng kiểm tra lại", "", MessageBoxButtons.OK);
                    txt_MaDDH.Focus();
                    txt_MaDDH.SelectAll();
                    return;
                }                

                //Hien thi thong tin chi tiet don dat hang
                List<Layers.DTO.CTDONDATHANG_DTO> CTDDH_DtoList = new Layers.BUS.CTDONDATHANG_BUS().SelectAllByMaDonDatHang(dondathangDto.Ma);
                if (CTDDH_DtoList.Count == 0)
                {
                    MessageBox.Show("Hiện chưa có chi tiết nào của đơn đặt hàng này.Vui lòng kiểm tra lại.", "", MessageBoxButtons.OK);
                    txt_MaDDH.Focus();
                    txt_MaDDH.SelectAll();
                    return;
                }

                txt_NgayNhap.Text = DateTime.Today.ToShortDateString();                
                                
                
            }
            
        }

        public List<CTPHIEUNHAPXE_DTO> CTPhieuNhapDto_List;

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            //Chon cac chi tiet don dat hang dua vao chi tiet phieu nhap xe                
            CTPhieuNhapDto_List = new List<CTPHIEUNHAPXE_DTO>();
            int SoLuongXeNhap = 0;
            if (chk_All.Checked)
            {
                for (int i = 0; i < grid_ChiTietDDH.Rows.Count; i++)
                {
                    CTPHIEUNHAPXE_DTO CTPhieuNhapDto = new CTPHIEUNHAPXE_DTO();
                    CTPhieuNhapDto.MaXe = int.Parse(grid_ChiTietDDH.Rows[i].Cells["MaXe"].Value.ToString());
                    CTPhieuNhapDto.MaMau = grid_ChiTietDDH.Rows[i].Cells["MaMau"].Value.ToString();
                    //CTPhieuNhapDto.MaPhieuNhapXe = 'sau khi them phieu nhap xe moi bo sung vao'
                    CTPhieuNhapDto.SoLuong = int.Parse(grid_ChiTietDDH.Rows[i].Cells["SoLuong"].Value.ToString());

                    CTPhieuNhapDto_List.Add(CTPhieuNhapDto);
                    SoLuongXeNhap += CTPhieuNhapDto.SoLuong;
                }
            }
            else
            {
                for (int i = 0; i < grid_ChiTietDDH.Rows.Count; i++)
                {
                    CheckBox chk_box = (CheckBox)grid_ChiTietDDH.Rows[i].Cells["Check"].Value;
                    if (chk_box.Checked)
                    {
                        CTPHIEUNHAPXE_DTO CTPhieuNhapDto = new CTPHIEUNHAPXE_DTO();
                        CTPhieuNhapDto.MaXe = int.Parse(grid_ChiTietDDH.Rows[i].Cells["MaXe"].Value.ToString());
                        CTPhieuNhapDto.MaMau = grid_ChiTietDDH.Rows[i].Cells["MaMau"].Value.ToString();
                        //CTPhieuNhapDto.MaPhieuNhapXe = 'sau khi them phieu nhap xe moi bo sung vao'
                        CTPhieuNhapDto.SoLuong = int.Parse(grid_ChiTietDDH.Rows[i].Cells["SoLuong"].Value.ToString());

                        CTPhieuNhapDto_List.Add(CTPhieuNhapDto);
                        SoLuongXeNhap += CTPhieuNhapDto.SoLuong;
                    }
                }
            }
            grid_ChiTietPhieuNhap.DataSource = CTPhieuNhapDto_List;
            txt_TongSoLuong.Text = SoLuongXeNhap.ToString();
        }

        private void chk_All_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_All.Checked)
            {
                chk_All.Text = "Bỏ Chọn Tất Cả";
                for (int i = 0; i < grid_ChiTietDDH.Rows.Count; i++)
                {
                    CheckBox chk_box = (CheckBox)grid_ChiTietDDH.Rows[i].Cells["Check"].Value;
                    chk_box.Checked = true;
                }
            }
            else if(!chk_All.Checked)
            {
                chk_All.Text = "Chọn Tất Cả";
                for (int i = 0; i < grid_ChiTietDDH.Rows.Count; i++)
                {
                    CheckBox chk_box = (CheckBox)grid_ChiTietDDH.Rows[i].Cells["Check"].Value;
                    chk_box.Checked = false;
                }
            }
        }

        private void btn_LapPhieu_Click(object sender, EventArgs e)
        {
            PHIEUNHAPXE_DTO PhieuNhapXeDto = new PHIEUNHAPXE_DTO();
            PhieuNhapXeDto.MaDonDatHang = int.Parse(txt_MaDDH.Text.Trim());
            PhieuNhapXeDto.NgayNhap = DateTime.Parse(txt_NgayNhap.Text.Trim());
            PhieuNhapXeDto.TongSoLuong = int.Parse(txt_TongSoLuong.Text.Trim());
            PHIEUNHAPXE_BUS PhieuNhapBus = new PHIEUNHAPXE_BUS();
            PhieuNhapBus.Insert(PhieuNhapXeDto);

            CTPHIEUNHAPXE_BUS CTPhieuNhapBus = new CTPHIEUNHAPXE_BUS();
            for (int i = 0; i < CTPhieuNhapDto_List.Count;i++ )
            {
                CTPhieuNhapDto_List[i].MaPhieuNhapXe = PhieuNhapXeDto.Ma;
                CTPhieuNhapBus.Insert(CTPhieuNhapDto_List[i]);
            }
            MessageBox.Show("Đã lập xong phiếu nhập xe", "", MessageBoxButtons.OK);
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            txt_MaPhieuNhap.Text = String.Empty;
            txt_TongSoLuong.Text = String.Empty;
            if (grid_ChiTietDDH.Rows.Count != 0)
            {
                grid_ChiTietDDH.Rows.Clear();
            }            
            if (grid_ChiTietPhieuNhap.Rows.Count != 0)
            {
                grid_ChiTietPhieuNhap.Rows.Clear();
            }
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
