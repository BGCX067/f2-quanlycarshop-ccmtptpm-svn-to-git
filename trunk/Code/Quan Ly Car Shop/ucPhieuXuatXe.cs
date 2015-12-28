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
    public partial class ucPhieuXuatXe : UserControl
    {
        public ucPhieuXuatXe()
        {
            InitializeComponent();
        }

        private void chk_All_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_All.Checked)
            {
                chk_All.Text = "Bỏ Chọn Tất Cả";
                for (int i = 0; i < grid_ChiTietPhieuXuat.Rows.Count; i++)
                {
                    CheckBox chk_box = (CheckBox)grid_ChiTietPhieuXuat.Rows[i].Cells["Check"].Value;
                    chk_box.Checked = true;
                }
            }
            else if (!chk_All.Checked)
            {
                chk_All.Text = "Chọn Tất Cả";
                for (int i = 0; i < grid_ChiTietPhieuXuat.Rows.Count; i++)
                {
                    CheckBox chk_box = (CheckBox)grid_ChiTietPhieuXuat.Rows[i].Cells["Check"].Value;
                    chk_box.Checked = false;
                }
            }
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            if (chk_All.Checked)
            {
                chk_All.Checked = false;
                chk_All.Text = "Bỏ Chọn Tất Cả";
            }
            
            for (int i = 0; i < grid_ChiTietPhieuXuat.RowCount;i++ )
            {
                CheckBox chk_box = (CheckBox)grid_ChiTietPhieuXuat.Rows[i].Cells["Check"].Value;
                chk_box.Checked = false;
            }
        }

        private void btn_LapPhieu_Click(object sender, EventArgs e)
        {
            PHIEUXUATXE_DTO PhieuXuatDto = new PHIEUXUATXE_DTO();
            PhieuXuatDto.MaNhanVien = int.Parse(txt_MaNhanVien.Text.Trim());
            PhieuXuatDto.NgayXuat = DateTime.Parse(txt_NgayXuat.Text.Trim());
            PhieuXuatDto.TongSoLuong = 0;

            //Tao cac chi tiet phieu xuat
            List<CHITIETPHIEUXUATXE_DTO> CTPhieuXuatDto_List = new List<CHITIETPHIEUXUATXE_DTO>();
            for (int i = 0; i < grid_ChiTietPhieuXuat.Rows.Count;i++ )
            {
                CheckBox chk_box = (CheckBox)grid_ChiTietPhieuXuat.Rows[i].Cells["Check"].Value;
                if (chk_box.Checked)
                {
                    CHITIETPHIEUXUATXE_DTO CTPhieuXuatDto = new CHITIETPHIEUXUATXE_DTO();
                    CTPhieuXuatDto.MaXe = int.Parse(grid_ChiTietPhieuXuat.Rows[i].Cells["Ma"].Value.ToString());
                    CTPhieuXuatDto.MaMau = grid_ChiTietPhieuXuat.Rows[i].Cells["MaMau"].Value.ToString();
                    CTPhieuXuatDto.SoLuong = int.Parse(grid_ChiTietPhieuXuat.Rows[i].Cells["SoLuongXuat"].Value.ToString());

                    CTPhieuXuatDto_List.Add(CTPhieuXuatDto);
                    PhieuXuatDto.TongSoLuong += CTPhieuXuatDto.SoLuong;
                }
            }

            txt_TongSoLuong.Text = PhieuXuatDto.TongSoLuong.ToString();

            //them 1 phieu xuat moi vao CSDL
            PHIEUXUATXE_BUS PhieuXuatBus = new PHIEUXUATXE_BUS();
            PhieuXuatBus.Insert(PhieuXuatDto);
            txt_MaPhieuXuat.Text = PhieuXuatDto.Ma.ToString();

            //Cap nhat lai thong tin ma phieu xuat xe vao chi tiet phieu xuat xe, va them chi tiet phieu xe vao CSDL
            CHITIETPHIEUXUATXE_BUS CTPhieuXuatBus = new CHITIETPHIEUXUATXE_BUS();
            for (int i = 0; i < CTPhieuXuatDto_List.Count;i++ )
            {
                CTPhieuXuatDto_List[i].MaPhieuXuatXe = PhieuXuatDto.Ma;
                CTPhieuXuatBus.Insert(CTPhieuXuatDto_List[i]);
            }
        }

        public int MaNhanVien;
        private void ucPhieuXuatXe_Load(object sender, EventArgs e)
        {
            txt_MaNhanVien.Text = MaNhanVien.ToString();
            List<XE_DTO> XeDto_List = new XE_BUS().SelectAll();
            if(XeDto_List.Count > 0)
            {
                grid_ChiTietPhieuXuat.DataSource = XeDto_List;
            }
            
        }
    }
}
