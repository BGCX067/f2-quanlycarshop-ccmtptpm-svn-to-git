namespace Quan_Ly_Car_Shop
{
    partial class ucPhieuXuatXe
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
            this.grp_ChiTietPhieuXuat = new System.Windows.Forms.GroupBox();
            this.grid_ChiTietPhieuXuat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grpThongTinPhieuNhap = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_HuyBo = new System.Windows.Forms.Button();
            this.btn_LapPhieu = new System.Windows.Forms.Button();
            this.txt_TongSoLuong = new System.Windows.Forms.TextBox();
            this.txt_NgayXuat = new System.Windows.Forms.TextBox();
            this.txt_MaNhanVien = new System.Windows.Forms.TextBox();
            this.txt_MaPhieuXuat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chk_All = new System.Windows.Forms.CheckBox();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_ChiTietPhieuXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ChiTietPhieuXuat)).BeginInit();
            this.grpThongTinPhieuNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_ChiTietPhieuXuat
            // 
            this.grp_ChiTietPhieuXuat.Controls.Add(this.chk_All);
            this.grp_ChiTietPhieuXuat.Controls.Add(this.grid_ChiTietPhieuXuat);
            this.grp_ChiTietPhieuXuat.Location = new System.Drawing.Point(63, 182);
            this.grp_ChiTietPhieuXuat.Name = "grp_ChiTietPhieuXuat";
            this.grp_ChiTietPhieuXuat.Size = new System.Drawing.Size(504, 360);
            this.grp_ChiTietPhieuXuat.TabIndex = 8;
            this.grp_ChiTietPhieuXuat.TabStop = false;
            this.grp_ChiTietPhieuXuat.Text = "Chi Tiết Phiếu Xuất";
            // 
            // grid_ChiTietPhieuXuat
            // 
            this.grid_ChiTietPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ChiTietPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.SoLuongXuat});
            this.grid_ChiTietPhieuXuat.Location = new System.Drawing.Point(6, 19);
            this.grid_ChiTietPhieuXuat.Name = "grid_ChiTietPhieuXuat";
            this.grid_ChiTietPhieuXuat.Size = new System.Drawing.Size(492, 311);
            this.grid_ChiTietPhieuXuat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Phiếu Xuất Xe";
            // 
            // grpThongTinPhieuNhap
            // 
            this.grpThongTinPhieuNhap.Controls.Add(this.btn_Thoat);
            this.grpThongTinPhieuNhap.Controls.Add(this.btn_HuyBo);
            this.grpThongTinPhieuNhap.Controls.Add(this.btn_LapPhieu);
            this.grpThongTinPhieuNhap.Controls.Add(this.txt_TongSoLuong);
            this.grpThongTinPhieuNhap.Controls.Add(this.txt_NgayXuat);
            this.grpThongTinPhieuNhap.Controls.Add(this.txt_MaNhanVien);
            this.grpThongTinPhieuNhap.Controls.Add(this.txt_MaPhieuXuat);
            this.grpThongTinPhieuNhap.Controls.Add(this.label11);
            this.grpThongTinPhieuNhap.Controls.Add(this.label8);
            this.grpThongTinPhieuNhap.Controls.Add(this.label9);
            this.grpThongTinPhieuNhap.Controls.Add(this.label10);
            this.grpThongTinPhieuNhap.Location = new System.Drawing.Point(63, 52);
            this.grpThongTinPhieuNhap.Name = "grpThongTinPhieuNhap";
            this.grpThongTinPhieuNhap.Size = new System.Drawing.Size(504, 110);
            this.grpThongTinPhieuNhap.TabIndex = 6;
            this.grpThongTinPhieuNhap.TabStop = false;
            this.grpThongTinPhieuNhap.Text = "Thông Tin Phiếu Xuất Xe";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(312, 81);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_HuyBo
            // 
            this.btn_HuyBo.Enabled = false;
            this.btn_HuyBo.Location = new System.Drawing.Point(215, 81);
            this.btn_HuyBo.Name = "btn_HuyBo";
            this.btn_HuyBo.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyBo.TabIndex = 4;
            this.btn_HuyBo.Text = "Hủy Bỏ";
            this.btn_HuyBo.UseVisualStyleBackColor = true;
            this.btn_HuyBo.Click += new System.EventHandler(this.btn_HuyBo_Click);
            // 
            // btn_LapPhieu
            // 
            this.btn_LapPhieu.Enabled = false;
            this.btn_LapPhieu.Location = new System.Drawing.Point(118, 81);
            this.btn_LapPhieu.Name = "btn_LapPhieu";
            this.btn_LapPhieu.Size = new System.Drawing.Size(75, 23);
            this.btn_LapPhieu.TabIndex = 3;
            this.btn_LapPhieu.Text = "Lập Phiếu";
            this.btn_LapPhieu.UseVisualStyleBackColor = true;
            this.btn_LapPhieu.Click += new System.EventHandler(this.btn_LapPhieu_Click);
            // 
            // txt_TongSoLuong
            // 
            this.txt_TongSoLuong.Location = new System.Drawing.Point(360, 44);
            this.txt_TongSoLuong.Name = "txt_TongSoLuong";
            this.txt_TongSoLuong.ReadOnly = true;
            this.txt_TongSoLuong.Size = new System.Drawing.Size(128, 20);
            this.txt_TongSoLuong.TabIndex = 1;
            // 
            // txt_NgayXuat
            // 
            this.txt_NgayXuat.Location = new System.Drawing.Point(360, 18);
            this.txt_NgayXuat.Name = "txt_NgayXuat";
            this.txt_NgayXuat.ReadOnly = true;
            this.txt_NgayXuat.Size = new System.Drawing.Size(128, 20);
            this.txt_NgayXuat.TabIndex = 1;
            // 
            // txt_MaNhanVien
            // 
            this.txt_MaNhanVien.Location = new System.Drawing.Point(123, 44);
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.ReadOnly = true;
            this.txt_MaNhanVien.Size = new System.Drawing.Size(128, 20);
            this.txt_MaNhanVien.TabIndex = 1;
            // 
            // txt_MaPhieuXuat
            // 
            this.txt_MaPhieuXuat.Location = new System.Drawing.Point(123, 18);
            this.txt_MaPhieuXuat.Name = "txt_MaPhieuXuat";
            this.txt_MaPhieuXuat.ReadOnly = true;
            this.txt_MaPhieuXuat.Size = new System.Drawing.Size(128, 20);
            this.txt_MaPhieuXuat.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tổng Số Lượng :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày Xuất :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã Nhân Viên :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã Phiếu Xuất :";
            // 
            // chk_All
            // 
            this.chk_All.AutoSize = true;
            this.chk_All.Location = new System.Drawing.Point(69, 336);
            this.chk_All.Name = "chk_All";
            this.chk_All.Size = new System.Drawing.Size(86, 17);
            this.chk_All.TabIndex = 2;
            this.chk_All.Text = "Chọn Tất Cả";
            this.chk_All.UseVisualStyleBackColor = true;
            this.chk_All.CheckedChanged += new System.EventHandler(this.chk_All_CheckedChanged);
            // 
            // Check
            // 
            this.Check.HeaderText = "Chọn";
            this.Check.Name = "Check";
            this.Check.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ma";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Xe";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaMau";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Màu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số Lượng Tồn";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // SoLuongXuat
            // 
            this.SoLuongXuat.HeaderText = "Số Lượng Xuất";
            this.SoLuongXuat.Name = "SoLuongXuat";
            this.SoLuongXuat.Width = 110;
            // 
            // ucPhieuXuatXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grp_ChiTietPhieuXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpThongTinPhieuNhap);
            this.Name = "ucPhieuXuatXe";
            this.Size = new System.Drawing.Size(631, 557);
            this.Load += new System.EventHandler(this.ucPhieuXuatXe_Load);
            this.grp_ChiTietPhieuXuat.ResumeLayout(false);
            this.grp_ChiTietPhieuXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ChiTietPhieuXuat)).EndInit();
            this.grpThongTinPhieuNhap.ResumeLayout(false);
            this.grpThongTinPhieuNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_ChiTietPhieuXuat;
        private System.Windows.Forms.DataGridView grid_ChiTietPhieuXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpThongTinPhieuNhap;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_HuyBo;
        private System.Windows.Forms.Button btn_LapPhieu;
        private System.Windows.Forms.TextBox txt_TongSoLuong;
        private System.Windows.Forms.TextBox txt_NgayXuat;
        private System.Windows.Forms.TextBox txt_MaNhanVien;
        private System.Windows.Forms.TextBox txt_MaPhieuXuat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chk_All;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongXuat;
    }
}
