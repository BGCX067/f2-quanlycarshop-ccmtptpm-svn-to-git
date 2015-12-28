namespace Quan_Ly_Car_Shop
{
    partial class frmMain
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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Nhập Xe");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Xuất Xe");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Đặt Xe");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Quản Lý Nhập/Xuất Xe", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Lập Hóa Đơn");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Lập Biên Nhận");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Khách Hàng Đặt Xe");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Quản Lý Bán Xe", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Báo Cáo");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Hệ Thống Quản Lý Bán Xe", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode18,
            treeNode19});
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tree_MainMenu = new System.Windows.Forms.TreeView();
            this.bt_DangXuat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainSplitContainer.IsSplitterFixed = true;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.tree_MainMenu);
            this.MainSplitContainer.Panel1.Controls.Add(this.bt_DangXuat);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.pictureBox1);
            this.MainSplitContainer.Panel2.Controls.Add(this.label1);
            this.MainSplitContainer.Panel2.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.MainSplitContainer_Panel2_ControlAdded);
            this.MainSplitContainer.Size = new System.Drawing.Size(779, 483);
            this.MainSplitContainer.SplitterDistance = 214;
            this.MainSplitContainer.TabIndex = 1;
            // 
            // tree_MainMenu
            // 
            this.tree_MainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tree_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.tree_MainMenu.Name = "tree_MainMenu";
            treeNode11.Name = "node_NhapXe";
            treeNode11.Text = "Nhập Xe";
            treeNode12.Name = "node_XuatXe";
            treeNode12.Text = "Xuất Xe";
            treeNode13.Name = "Node_DatXe";
            treeNode13.Text = "Đặt Xe";
            treeNode14.Name = "node_QuanLyNhapXuatXe";
            treeNode14.Text = "Quản Lý Nhập/Xuất Xe";
            treeNode15.Name = "node_LapHoaDon";
            treeNode15.Text = "Lập Hóa Đơn";
            treeNode16.Name = "node_LapBienNhan";
            treeNode16.Text = "Lập Biên Nhận";
            treeNode17.Name = "node_KhachHangDatXe";
            treeNode17.Text = "Khách Hàng Đặt Xe";
            treeNode18.Name = "node_QuanLyBanXe";
            treeNode18.Text = "Quản Lý Bán Xe";
            treeNode19.Name = "node_BaoCao";
            treeNode19.Text = "Báo Cáo";
            treeNode20.Name = "node_Main";
            treeNode20.Text = "Hệ Thống Quản Lý Bán Xe";
            this.tree_MainMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.tree_MainMenu.Size = new System.Drawing.Size(214, 442);
            this.tree_MainMenu.TabIndex = 2;
            this.tree_MainMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_MainMenu_AfterSelect);
            // 
            // bt_DangXuat
            // 
            this.bt_DangXuat.Location = new System.Drawing.Point(70, 448);
            this.bt_DangXuat.Name = "bt_DangXuat";
            this.bt_DangXuat.Size = new System.Drawing.Size(75, 23);
            this.bt_DangXuat.TabIndex = 1;
            this.bt_DangXuat.Text = "Ðang Xuất";
            this.bt_DangXuat.UseVisualStyleBackColor = true;
            this.bt_DangXuat.Click += new System.EventHandler(this.bt_DangXuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::Quan_Ly_Car_Shop.Properties.Resources.Banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ Thống Quản Lý Cửa Hàng ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 483);
            this.Controls.Add(this.MainSplitContainer);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Hệ Thống Quản Lý Cửa Hàng Xe Ô Tô F5";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            this.MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.Button bt_DangXuat;
        private System.Windows.Forms.TreeView tree_MainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}