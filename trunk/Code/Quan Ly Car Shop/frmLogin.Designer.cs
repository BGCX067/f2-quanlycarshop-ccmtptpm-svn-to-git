namespace Quan_Ly_Car_Shop
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_DangNhap = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.lb_UserNameRequired = new System.Windows.Forms.Label();
            this.lb_PasswordRequired = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ServerName = new System.Windows.Forms.TextBox();
            this.chk_TenServer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(105, 50);
            this.txt_UserName.MaxLength = 256;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(121, 20);
            this.txt_UserName.TabIndex = 1;
            this.txt_UserName.Leave += new System.EventHandler(this.txt_UserName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(105, 76);
            this.txt_Password.MaxLength = 256;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(121, 20);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.Leave += new System.EventHandler(this.txt_Password_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đăng Nhập Hệ Thống";
            // 
            // bt_DangNhap
            // 
            this.bt_DangNhap.Location = new System.Drawing.Point(57, 102);
            this.bt_DangNhap.Name = "bt_DangNhap";
            this.bt_DangNhap.Size = new System.Drawing.Size(75, 23);
            this.bt_DangNhap.TabIndex = 3;
            this.bt_DangNhap.Text = "Đăng Nhập";
            this.bt_DangNhap.UseVisualStyleBackColor = true;
            this.bt_DangNhap.Click += new System.EventHandler(this.bt_DangNhap_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Location = new System.Drawing.Point(138, 102);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_Thoat.TabIndex = 4;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // lb_UserNameRequired
            // 
            this.lb_UserNameRequired.AutoSize = true;
            this.lb_UserNameRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lb_UserNameRequired.Location = new System.Drawing.Point(232, 50);
            this.lb_UserNameRequired.Name = "lb_UserNameRequired";
            this.lb_UserNameRequired.Size = new System.Drawing.Size(16, 20);
            this.lb_UserNameRequired.TabIndex = 4;
            this.lb_UserNameRequired.Text = "*";
            this.lb_UserNameRequired.Visible = false;
            // 
            // lb_PasswordRequired
            // 
            this.lb_PasswordRequired.AutoSize = true;
            this.lb_PasswordRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PasswordRequired.ForeColor = System.Drawing.Color.Red;
            this.lb_PasswordRequired.Location = new System.Drawing.Point(232, 76);
            this.lb_PasswordRequired.Name = "lb_PasswordRequired";
            this.lb_PasswordRequired.Size = new System.Drawing.Size(16, 20);
            this.lb_PasswordRequired.TabIndex = 4;
            this.lb_PasswordRequired.Text = "*";
            this.lb_PasswordRequired.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên SQL Server:";
            // 
            // txt_ServerName
            // 
            this.txt_ServerName.Enabled = false;
            this.txt_ServerName.Location = new System.Drawing.Point(121, 131);
            this.txt_ServerName.MaxLength = 256;
            this.txt_ServerName.Name = "txt_ServerName";
            this.txt_ServerName.Size = new System.Drawing.Size(121, 20);
            this.txt_ServerName.TabIndex = 6;
            this.txt_ServerName.Leave += new System.EventHandler(this.txt_Password_Leave);
            // 
            // chk_TenServer
            // 
            this.chk_TenServer.AutoSize = true;
            this.chk_TenServer.Location = new System.Drawing.Point(12, 134);
            this.chk_TenServer.Name = "chk_TenServer";
            this.chk_TenServer.Size = new System.Drawing.Size(15, 14);
            this.chk_TenServer.TabIndex = 5;
            this.chk_TenServer.UseVisualStyleBackColor = true;
            this.chk_TenServer.CheckedChanged += new System.EventHandler(this.chk_TenServer_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 164);
            this.Controls.Add(this.chk_TenServer);
            this.Controls.Add(this.lb_PasswordRequired);
            this.Controls.Add(this.lb_UserNameRequired);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_DangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ServerName);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_DangNhap;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Label lb_UserNameRequired;
        private System.Windows.Forms.Label lb_PasswordRequired;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ServerName;
        private System.Windows.Forms.CheckBox chk_TenServer;
    }
}