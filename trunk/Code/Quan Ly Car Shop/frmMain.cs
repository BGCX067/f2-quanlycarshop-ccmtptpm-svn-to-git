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
    public enum CurrentUC
    {
        enum_BienNhanThanhToanTheoDot,
        enum_PhieuDatXe,
        enum_PhieuNhapXe,
        enum_PhieuXuatXe,
        enum_HoaDon,
        enum_KhongCo,
        enum_KhoiTao,
    }

    public partial class frmMain : Form
    {
        public NHANVIEN_DTO NhanVien;

        frmLogin Login;
        ucPhieuDatXe PhieuDatXe;
        ucBienNhanThanhToanTheoDot BienNhanTheoDot;
        ucHoaDon HoaDon;
        ucPhieuNhapXe PhieuNhapXe;
        ucPhieuXuatXe PhieuXuatXe;
        CurrentUC UC = CurrentUC.enum_KhoiTao;

        public frmMain()
        {
            InitializeComponent();
            PhieuDatXe = new ucPhieuDatXe();
            Login = new frmLogin();
            BienNhanTheoDot = new ucBienNhanThanhToanTheoDot();
            PhieuNhapXe = new ucPhieuNhapXe();
            PhieuXuatXe = new ucPhieuXuatXe();
            HoaDon = new ucHoaDon();            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            Login.ShowDialog(this);
            Login.Location = new Point((int)((Width - Login.Width) / 2) + Location.X, (int)((Height - Login.Height) / 2) + Location.Y);
            if (Login.NhanVien == null)
                Close();
            NhanVien = Login.NhanVien;
        }

        private void MainSplitContainer_Panel2_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control == PhieuDatXe)
                PhieuDatXe.SetNhanVien(NhanVien);
            if (e.Control == BienNhanTheoDot)
                BienNhanTheoDot.MaNhanVienHienTai = NhanVien.Ma;
            if (e.Control == PhieuXuatXe)
                PhieuXuatXe.MaNhanVien = NhanVien.Ma;
        }

        private void bt_DangXuat_Click(object sender, EventArgs e)
        {
            NhanVien = null;
            Login.ShowDialog(this);
            if (Login.NhanVien == null)
                Close();
            NhanVien = Login.NhanVien;
        }

        private void btn_NhapXe_Click(object sender, EventArgs e)
        {
            MainSplitContainer.Panel2.Controls.Add(PhieuNhapXe);
        }

        private void btn_XuatXe_Click(object sender, EventArgs e)
        {
            MainSplitContainer.Panel2.Controls.Add(PhieuXuatXe);
        }

        private void tree_MainMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (MainSplitContainer.Panel2.Controls.Count > 0 || UC != CurrentUC.enum_KhongCo)
                MainSplitContainer.Panel2.Controls.Clear();
            switch(e.Node.Name)
            {
                case "node_NhapXe":
                    if (NhanVien.TenLoaiNhanVien != "Quản Lý")
                    {
                        MessageBox.Show("Chỉ nhân viên Quản Lý mới được sử dụng chức năng này", "Lỗi Truy Cập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.Size = new Size(PhieuNhapXe.Size.Width + tree_MainMenu.Size.Width + 15, PhieuNhapXe.Size.Height + 30);
                    MainSplitContainer.Panel2.Controls.Add(PhieuNhapXe);
                    UC = CurrentUC.enum_PhieuNhapXe;
                    break;
                case "node_XuatXe":
                    if (NhanVien.TenLoaiNhanVien != "Quản Lý")
                    {
                        MessageBox.Show("Chỉ nhân viên Quản Lý mới được sử dụng chức năng này", "Lỗi Truy Cập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.Size = new Size(PhieuXuatXe.Size.Width + tree_MainMenu.Size.Width + 15, PhieuXuatXe.Size.Height + 30);
                    MainSplitContainer.Panel2.Controls.Add(PhieuXuatXe);
                    UC = CurrentUC.enum_PhieuNhapXe;
                    break;
                case "node_DatXe":
                    if (NhanVien.TenLoaiNhanVien != "Quản Lý")
                    {
                        MessageBox.Show("Chỉ nhân viên Quản Lý mới được sử dụng chức năng này", "Lỗi Truy Cập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case "node_LapHoaDon":
                    this.Size = new Size(HoaDon.Size.Width + tree_MainMenu.Size.Width + 15, HoaDon.Size.Height + 30);
                    MainSplitContainer.Panel2.Controls.Add(HoaDon);
                    UC = CurrentUC.enum_PhieuNhapXe;
                    break;
                case "node_LapBienNhan":
                    this.Size = new Size(PhieuNhapXe.Size.Width + tree_MainMenu.Size.Width + 15, PhieuNhapXe.Size.Height + 30);
                    MainSplitContainer.Panel2.Controls.Add(PhieuNhapXe);
                    UC = CurrentUC.enum_PhieuNhapXe;
                    break;
                case "node_KhachHangDatXe":
                    this.Size = new Size(PhieuDatXe.Size.Width + tree_MainMenu.Size.Width + 15, PhieuDatXe.Size.Height + 30);
                    MainSplitContainer.Panel2.Controls.Add(PhieuDatXe);
                    UC = CurrentUC.enum_PhieuNhapXe;
                    break;
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                System.Diagnostics.Process.Start("WinHelp\\Quan_Ly_Car_Shop.chm");
        }
    }
}