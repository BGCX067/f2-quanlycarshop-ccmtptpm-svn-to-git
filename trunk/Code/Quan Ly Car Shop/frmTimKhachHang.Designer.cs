namespace Quan_Ly_Car_Shop
{
    partial class frmTimKhachHang
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_MaKhachHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rd_MaKhachHang = new System.Windows.Forms.RadioButton();
            this.rd_ThongTinKhachHang = new System.Windows.Forms.RadioButton();
            this.gb_ThongTinKhachHang = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.bt_Tim = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.gb_ThongTinKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_MaKhachHang
            // 
            this.txt_MaKhachHang.Location = new System.Drawing.Point(74, 54);
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.Size = new System.Drawing.Size(116, 20);
            this.txt_MaKhachHang.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã:";
            // 
            // rd_MaKhachHang
            // 
            this.rd_MaKhachHang.AutoSize = true;
            this.rd_MaKhachHang.Checked = true;
            this.rd_MaKhachHang.Location = new System.Drawing.Point(23, 31);
            this.rd_MaKhachHang.Name = "rd_MaKhachHang";
            this.rd_MaKhachHang.Size = new System.Drawing.Size(100, 17);
            this.rd_MaKhachHang.TabIndex = 3;
            this.rd_MaKhachHang.TabStop = true;
            this.rd_MaKhachHang.Text = "Mã khách hàng";
            this.rd_MaKhachHang.UseVisualStyleBackColor = true;
            this.rd_MaKhachHang.CheckedChanged += new System.EventHandler(this.rd_LoaiSearch_CheckedChanged);
            // 
            // rd_ThongTinKhachHang
            // 
            this.rd_ThongTinKhachHang.AutoSize = true;
            this.rd_ThongTinKhachHang.Location = new System.Drawing.Point(23, 80);
            this.rd_ThongTinKhachHang.Name = "rd_ThongTinKhachHang";
            this.rd_ThongTinKhachHang.Size = new System.Drawing.Size(134, 17);
            this.rd_ThongTinKhachHang.TabIndex = 3;
            this.rd_ThongTinKhachHang.Text = "Thông Tin khách hàng";
            this.rd_ThongTinKhachHang.UseVisualStyleBackColor = true;
            this.rd_ThongTinKhachHang.CheckedChanged += new System.EventHandler(this.rd_LoaiSearch_CheckedChanged);
            // 
            // gb_ThongTinKhachHang
            // 
            this.gb_ThongTinKhachHang.Controls.Add(this.label4);
            this.gb_ThongTinKhachHang.Controls.Add(this.label2);
            this.gb_ThongTinKhachHang.Controls.Add(this.label1);
            this.gb_ThongTinKhachHang.Controls.Add(this.txt_CMND);
            this.gb_ThongTinKhachHang.Controls.Add(this.txt_DiaChi);
            this.gb_ThongTinKhachHang.Controls.Add(this.txt_HoTen);
            this.gb_ThongTinKhachHang.Location = new System.Drawing.Point(12, 103);
            this.gb_ThongTinKhachHang.Name = "gb_ThongTinKhachHang";
            this.gb_ThongTinKhachHang.Size = new System.Drawing.Size(228, 135);
            this.gb_ThongTinKhachHang.TabIndex = 4;
            this.gb_ThongTinKhachHang.TabStop = false;
            this.gb_ThongTinKhachHang.Text = "Thông Tin Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "CMND:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(62, 108);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(91, 20);
            this.txt_CMND.TabIndex = 1;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(62, 50);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(158, 52);
            this.txt_DiaChi.TabIndex = 1;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(62, 24);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(130, 20);
            this.txt_HoTen.TabIndex = 1;
            // 
            // bt_Tim
            // 
            this.bt_Tim.Location = new System.Drawing.Point(59, 244);
            this.bt_Tim.Name = "bt_Tim";
            this.bt_Tim.Size = new System.Drawing.Size(63, 23);
            this.bt_Tim.TabIndex = 5;
            this.bt_Tim.Text = "Tìm";
            this.bt_Tim.UseVisualStyleBackColor = true;
            this.bt_Tim.Click += new System.EventHandler(this.bt_Tim_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Location = new System.Drawing.Point(128, 244);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(63, 23);
            this.bt_Thoat.TabIndex = 5;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // frmTimKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 275);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_Tim);
            this.Controls.Add(this.gb_ThongTinKhachHang);
            this.Controls.Add(this.rd_ThongTinKhachHang);
            this.Controls.Add(this.rd_MaKhachHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MaKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimKhachHang";
            this.Text = "Tìm Khách Hàng";
            this.gb_ThongTinKhachHang.ResumeLayout(false);
            this.gb_ThongTinKhachHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MaKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rd_MaKhachHang;
        private System.Windows.Forms.RadioButton rd_ThongTinKhachHang;
        private System.Windows.Forms.GroupBox gb_ThongTinKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.Button bt_Tim;
        private System.Windows.Forms.Button bt_Thoat;

    }
}