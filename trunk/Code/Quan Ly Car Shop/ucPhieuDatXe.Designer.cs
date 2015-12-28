namespace Quan_Ly_Car_Shop
{
    partial class ucPhieuDatXe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Tim = new System.Windows.Forms.Button();
            this.rd_KhachHangMoi = new System.Windows.Forms.RadioButton();
            this.rd_KhachHangCu = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combo_Phai = new System.Windows.Forms.ComboBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_DienThoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grid_DanhSachXeDat = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_ThemXe = new System.Windows.Forms.Button();
            this.bt_XoaXe = new System.Windows.Forms.Button();
            this.bt_ThemDonDatXe = new System.Windows.Forms.Button();
            this.bt_Huy = new System.Windows.Forms.Button();
            this.bt_XoaHetXe = new System.Windows.Forms.Button();
            this.txt_ro_TongTienTruocThue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ro_Thue = new System.Windows.Forms.TextBox();
            this.txt_ro_TongTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_ro_TenNhanVien = new System.Windows.Forms.TextBox();
            this.txt_ro_MaNhanVien = new System.Windows.Forms.TextBox();
            this.dtpicker_NgayHenLay = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_TienTraTruoc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_ro_TienConLai = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTienBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DanhSachXeDat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu Đặt Xe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Tim);
            this.groupBox1.Controls.Add(this.rd_KhachHangMoi);
            this.groupBox1.Controls.Add(this.rd_KhachHangCu);
            this.groupBox1.Location = new System.Drawing.Point(3, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại Khách Hàng";
            // 
            // bt_Tim
            // 
            this.bt_Tim.Location = new System.Drawing.Point(142, 16);
            this.bt_Tim.Name = "bt_Tim";
            this.bt_Tim.Size = new System.Drawing.Size(47, 23);
            this.bt_Tim.TabIndex = 1;
            this.bt_Tim.Text = "Tìm";
            this.bt_Tim.UseVisualStyleBackColor = true;
            this.bt_Tim.Click += new System.EventHandler(this.bt_Tim_Click);
            // 
            // rd_KhachHangMoi
            // 
            this.rd_KhachHangMoi.AutoSize = true;
            this.rd_KhachHangMoi.Location = new System.Drawing.Point(6, 42);
            this.rd_KhachHangMoi.Name = "rd_KhachHangMoi";
            this.rd_KhachHangMoi.Size = new System.Drawing.Size(102, 17);
            this.rd_KhachHangMoi.TabIndex = 0;
            this.rd_KhachHangMoi.Text = "Khách hàng mới";
            this.rd_KhachHangMoi.UseVisualStyleBackColor = true;
            this.rd_KhachHangMoi.CheckedChanged += new System.EventHandler(this.rd_LoaiKhachHang_CheckedChanged);
            // 
            // rd_KhachHangCu
            // 
            this.rd_KhachHangCu.AutoSize = true;
            this.rd_KhachHangCu.Checked = true;
            this.rd_KhachHangCu.Location = new System.Drawing.Point(6, 19);
            this.rd_KhachHangCu.Name = "rd_KhachHangCu";
            this.rd_KhachHangCu.Size = new System.Drawing.Size(130, 17);
            this.rd_KhachHangCu.TabIndex = 0;
            this.rd_KhachHangCu.TabStop = true;
            this.rd_KhachHangCu.Text = "Khách hàng thân thiết";
            this.rd_KhachHangCu.UseVisualStyleBackColor = true;
            this.rd_KhachHangCu.CheckedChanged += new System.EventHandler(this.rd_LoaiKhachHang_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combo_Phai);
            this.groupBox2.Controls.Add(this.txt_DiaChi);
            this.groupBox2.Controls.Add(this.txt_DienThoai);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_HoTen);
            this.groupBox2.Controls.Add(this.txt_CMND);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(205, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 126);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết Khách Hàng";
            // 
            // combo_Phai
            // 
            this.combo_Phai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Phai.Enabled = false;
            this.combo_Phai.FormattingEnabled = true;
            this.combo_Phai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.combo_Phai.Location = new System.Drawing.Point(70, 45);
            this.combo_Phai.Name = "combo_Phai";
            this.combo_Phai.Size = new System.Drawing.Size(49, 21);
            this.combo_Phai.TabIndex = 2;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(70, 74);
            this.txt_DiaChi.MaxLength = 150;
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.ReadOnly = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(346, 46);
            this.txt_DiaChi.TabIndex = 1;
            // 
            // txt_DienThoai
            // 
            this.txt_DienThoai.Location = new System.Drawing.Point(302, 19);
            this.txt_DienThoai.Name = "txt_DienThoai";
            this.txt_DienThoai.ReadOnly = true;
            this.txt_DienThoai.Size = new System.Drawing.Size(114, 20);
            this.txt_DienThoai.TabIndex = 1;
            this.txt_DienThoai.TextChanged += new System.EventHandler(this.txt_DienThoai_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phái:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ:";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(70, 19);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.ReadOnly = true;
            this.txt_HoTen.Size = new System.Drawing.Size(137, 20);
            this.txt_HoTen.TabIndex = 1;
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(303, 45);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.ReadOnly = true;
            this.txt_CMND.Size = new System.Drawing.Size(113, 20);
            this.txt_CMND.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "CMND:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng tiền trước thuế:";
            // 
            // grid_DanhSachXeDat
            // 
            this.grid_DanhSachXeDat.AllowUserToAddRows = false;
            this.grid_DanhSachXeDat.AllowUserToDeleteRows = false;
            this.grid_DanhSachXeDat.AllowUserToResizeColumns = false;
            this.grid_DanhSachXeDat.AllowUserToResizeRows = false;
            this.grid_DanhSachXeDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DanhSachXeDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXe,
            this.TenXe,
            this.HangXe,
            this.Mau,
            this.MaMau,
            this.GiaTienBan,
            this.SoLuong,
            this.ThanhTien});
            this.grid_DanhSachXeDat.Location = new System.Drawing.Point(3, 202);
            this.grid_DanhSachXeDat.Name = "grid_DanhSachXeDat";
            this.grid_DanhSachXeDat.ReadOnly = true;
            this.grid_DanhSachXeDat.RowHeadersVisible = false;
            this.grid_DanhSachXeDat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_DanhSachXeDat.Size = new System.Drawing.Size(574, 150);
            this.grid_DanhSachXeDat.TabIndex = 3;
            this.grid_DanhSachXeDat.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(grid_DanhSachXeDat_RowsAdded);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(225, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Danh Sách Xe Muốn Đặt";
            // 
            // bt_ThemXe
            // 
            this.bt_ThemXe.Location = new System.Drawing.Point(580, 220);
            this.bt_ThemXe.Name = "bt_ThemXe";
            this.bt_ThemXe.Size = new System.Drawing.Size(47, 23);
            this.bt_ThemXe.TabIndex = 1;
            this.bt_ThemXe.Text = "Thêm";
            this.bt_ThemXe.UseVisualStyleBackColor = true;
            this.bt_ThemXe.Click += new System.EventHandler(this.bt_ThemXe_Click);
            // 
            // bt_XoaXe
            // 
            this.bt_XoaXe.Location = new System.Drawing.Point(580, 249);
            this.bt_XoaXe.Name = "bt_XoaXe";
            this.bt_XoaXe.Size = new System.Drawing.Size(47, 23);
            this.bt_XoaXe.TabIndex = 1;
            this.bt_XoaXe.Text = "Xoá";
            this.bt_XoaXe.UseVisualStyleBackColor = true;
            this.bt_XoaXe.Click += new System.EventHandler(this.bt_XoaXe_Click);
            // 
            // bt_ThemDonDatXe
            // 
            this.bt_ThemDonDatXe.Location = new System.Drawing.Point(222, 488);
            this.bt_ThemDonDatXe.Name = "bt_ThemDonDatXe";
            this.bt_ThemDonDatXe.Size = new System.Drawing.Size(106, 23);
            this.bt_ThemDonDatXe.TabIndex = 4;
            this.bt_ThemDonDatXe.Text = "Thêm Đơn Đặt Xe";
            this.bt_ThemDonDatXe.UseVisualStyleBackColor = true;
            this.bt_ThemDonDatXe.Click += new System.EventHandler(this.bt_ThemDonDatXe_Click);
            // 
            // bt_Huy
            // 
            this.bt_Huy.Location = new System.Drawing.Point(334, 488);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(75, 23);
            this.bt_Huy.TabIndex = 5;
            this.bt_Huy.Text = "Huỷ";
            this.bt_Huy.UseVisualStyleBackColor = true;
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // bt_XoaHetXe
            // 
            this.bt_XoaHetXe.Location = new System.Drawing.Point(580, 278);
            this.bt_XoaHetXe.Name = "bt_XoaHetXe";
            this.bt_XoaHetXe.Size = new System.Drawing.Size(47, 41);
            this.bt_XoaHetXe.TabIndex = 1;
            this.bt_XoaHetXe.Text = "Xoá\r\nHết";
            this.bt_XoaHetXe.UseVisualStyleBackColor = true;
            this.bt_XoaHetXe.Click += new System.EventHandler(this.bt_XoaHetXe_Click);
            // 
            // txt_ro_TongTienTruocThue
            // 
            this.txt_ro_TongTienTruocThue.Location = new System.Drawing.Point(489, 358);
            this.txt_ro_TongTienTruocThue.Name = "txt_ro_TongTienTruocThue";
            this.txt_ro_TongTienTruocThue.ReadOnly = true;
            this.txt_ro_TongTienTruocThue.Size = new System.Drawing.Size(88, 20);
            this.txt_ro_TongTienTruocThue.TabIndex = 1;
            this.txt_ro_TongTienTruocThue.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng tiền sau thuế:";
            // 
            // txt_ro_Thue
            // 
            this.txt_ro_Thue.Location = new System.Drawing.Point(489, 384);
            this.txt_ro_Thue.Name = "txt_ro_Thue";
            this.txt_ro_Thue.ReadOnly = true;
            this.txt_ro_Thue.Size = new System.Drawing.Size(88, 20);
            this.txt_ro_Thue.TabIndex = 1;
            this.txt_ro_Thue.Text = "0";
            // 
            // txt_ro_TongTien
            // 
            this.txt_ro_TongTien.Location = new System.Drawing.Point(489, 410);
            this.txt_ro_TongTien.Name = "txt_ro_TongTien";
            this.txt_ro_TongTien.ReadOnly = true;
            this.txt_ro_TongTien.Size = new System.Drawing.Size(88, 20);
            this.txt_ro_TongTien.TabIndex = 1;
            this.txt_ro_TongTien.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(583, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "VND";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(448, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Thuế:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(583, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "VND";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(583, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "VND";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 387);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Nhân viên:";
            // 
            // txt_ro_TenNhanVien
            // 
            this.txt_ro_TenNhanVien.Location = new System.Drawing.Point(81, 384);
            this.txt_ro_TenNhanVien.Name = "txt_ro_TenNhanVien";
            this.txt_ro_TenNhanVien.ReadOnly = true;
            this.txt_ro_TenNhanVien.Size = new System.Drawing.Size(121, 20);
            this.txt_ro_TenNhanVien.TabIndex = 7;
            // 
            // txt_ro_MaNhanVien
            // 
            this.txt_ro_MaNhanVien.Location = new System.Drawing.Point(3, 3);
            this.txt_ro_MaNhanVien.Name = "txt_ro_MaNhanVien";
            this.txt_ro_MaNhanVien.ReadOnly = true;
            this.txt_ro_MaNhanVien.Size = new System.Drawing.Size(100, 20);
            this.txt_ro_MaNhanVien.TabIndex = 8;
            this.txt_ro_MaNhanVien.Visible = false;
            // 
            // dtpicker_NgayHenLay
            // 
            this.dtpicker_NgayHenLay.CustomFormat = "dd/MM/yyyy";
            this.dtpicker_NgayHenLay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker_NgayHenLay.Location = new System.Drawing.Point(275, 358);
            this.dtpicker_NgayHenLay.Name = "dtpicker_NgayHenLay";
            this.dtpicker_NgayHenLay.Size = new System.Drawing.Size(84, 20);
            this.dtpicker_NgayHenLay.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(175, 362);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Ngày Hẹn Lấy Xe:";
            // 
            // txt_TienTraTruoc
            // 
            this.txt_TienTraTruoc.Location = new System.Drawing.Point(489, 436);
            this.txt_TienTraTruoc.Name = "txt_TienTraTruoc";
            this.txt_TienTraTruoc.Size = new System.Drawing.Size(88, 20);
            this.txt_TienTraTruoc.TabIndex = 1;
            this.txt_TienTraTruoc.Text = "0";
            this.txt_TienTraTruoc.TextChanged += new System.EventHandler(this.txt_TienTraTruoc_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(410, 439);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Tiền trả trước:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(441, 465);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Còn lại:";
            // 
            // txt_ro_TienConLai
            // 
            this.txt_ro_TienConLai.Location = new System.Drawing.Point(489, 462);
            this.txt_ro_TienConLai.Name = "txt_ro_TienConLai";
            this.txt_ro_TienConLai.ReadOnly = true;
            this.txt_ro_TienConLai.Size = new System.Drawing.Size(88, 20);
            this.txt_ro_TienConLai.TabIndex = 1;
            this.txt_ro_TienConLai.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(583, 439);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "VND";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(583, 465);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "VND";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 413);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Ngày lập:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 410);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 7;
            // 
            // MaXe
            // 
            this.MaXe.HeaderText = "Mã Xe";
            this.MaXe.Name = "MaXe";
            this.MaXe.ReadOnly = true;
            this.MaXe.Visible = false;
            // 
            // TenXe
            // 
            this.TenXe.HeaderText = "Tên Xe";
            this.TenXe.Name = "TenXe";
            this.TenXe.ReadOnly = true;
            this.TenXe.Width = 105;
            // 
            // HangXe
            // 
            this.HangXe.HeaderText = "Hãng Xe";
            this.HangXe.Name = "HangXe";
            this.HangXe.ReadOnly = true;
            this.HangXe.Width = 145;
            // 
            // Mau
            // 
            this.Mau.HeaderText = "Màu";
            this.Mau.Name = "Mau";
            this.Mau.ReadOnly = true;
            this.Mau.Width = 70;
            // 
            // MaMau
            // 
            this.MaMau.HeaderText = "Mã Màu";
            this.MaMau.Name = "MaMau";
            this.MaMau.ReadOnly = true;
            this.MaMau.Visible = false;
            // 
            // GiaTienBan
            // 
            this.GiaTienBan.HeaderText = "Giá Tiền";
            this.GiaTienBan.Name = "GiaTienBan";
            this.GiaTienBan.ReadOnly = true;
            this.GiaTienBan.Width = 85;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 80;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 85;
            // 
            // ucPhieuDatXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpicker_NgayHenLay);
            this.Controls.Add(this.txt_ro_MaNhanVien);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_ro_TenNhanVien);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bt_Huy);
            this.Controls.Add(this.bt_ThemDonDatXe);
            this.Controls.Add(this.txt_TienTraTruoc);
            this.Controls.Add(this.txt_ro_TienConLai);
            this.Controls.Add(this.txt_ro_TongTien);
            this.Controls.Add(this.txt_ro_Thue);
            this.Controls.Add(this.txt_ro_TongTienTruocThue);
            this.Controls.Add(this.bt_XoaHetXe);
            this.Controls.Add(this.bt_XoaXe);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_ThemXe);
            this.Controls.Add(this.grid_DanhSachXeDat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "ucPhieuDatXe";
            this.Size = new System.Drawing.Size(631, 519);
            this.Load += new System.EventHandler(this.ucPhieuDatXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DanhSachXeDat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Tim;
        private System.Windows.Forms.RadioButton rd_KhachHangMoi;
        private System.Windows.Forms.RadioButton rd_KhachHangCu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_DienThoai;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.DataGridView grid_DanhSachXeDat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_ThemXe;
        private System.Windows.Forms.Button bt_XoaXe;
        private System.Windows.Forms.Button bt_ThemDonDatXe;
        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.Button bt_XoaHetXe;
        private System.Windows.Forms.ComboBox combo_Phai;
        private System.Windows.Forms.TextBox txt_ro_TongTienTruocThue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ro_Thue;
        private System.Windows.Forms.TextBox txt_ro_TongTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_ro_TenNhanVien;
        private System.Windows.Forms.TextBox txt_ro_MaNhanVien;
        private System.Windows.Forms.DateTimePicker dtpicker_NgayHenLay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_TienTraTruoc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_ro_TienConLai;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTienBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}
