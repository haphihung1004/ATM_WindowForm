namespace ATM
{
    partial class Admin
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.heToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_QLDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_QLThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_RutTien = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ChuyenTien = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_NhanTien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // heToolStripMenuItem
            // 
            this.heToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Thoat});
            this.heToolStripMenuItem.Name = "heToolStripMenuItem";
            this.heToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.heToolStripMenuItem.Text = "Hệ Thống";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_QLDangNhap,
            this.menu_QLThongTinTaiKhoan,
            this.quảnLíToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // Menu_Thoat
            // 
            this.Menu_Thoat.Name = "Menu_Thoat";
            this.Menu_Thoat.Size = new System.Drawing.Size(152, 22);
            this.Menu_Thoat.Text = "Thoát";
            this.Menu_Thoat.Click += new System.EventHandler(this.Menu_Thoat_Click);
            // 
            // menu_QLDangNhap
            // 
            this.menu_QLDangNhap.Name = "menu_QLDangNhap";
            this.menu_QLDangNhap.Size = new System.Drawing.Size(237, 22);
            this.menu_QLDangNhap.Text = "Quản lí thông tin đăng nhập";
            this.menu_QLDangNhap.Click += new System.EventHandler(this.menu_QLDangNhap_Click);
            // 
            // menu_QLThongTinTaiKhoan
            // 
            this.menu_QLThongTinTaiKhoan.Name = "menu_QLThongTinTaiKhoan";
            this.menu_QLThongTinTaiKhoan.Size = new System.Drawing.Size(237, 22);
            this.menu_QLThongTinTaiKhoan.Text = "Quản lí thông tin các tài khoản";
            this.menu_QLThongTinTaiKhoan.Click += new System.EventHandler(this.menu_QLThongTinTaiKhoan_Click);
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_RutTien,
            this.menu_ChuyenTien,
            this.menu_NhanTien});
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.quảnLíToolStripMenuItem.Text = "Quản lí giao dịch";
            // 
            // menu_RutTien
            // 
            this.menu_RutTien.Name = "menu_RutTien";
            this.menu_RutTien.Size = new System.Drawing.Size(152, 22);
            this.menu_RutTien.Text = "Rút tiền ";
            this.menu_RutTien.Click += new System.EventHandler(this.menu_RutTien_Click);
            // 
            // menu_ChuyenTien
            // 
            this.menu_ChuyenTien.Name = "menu_ChuyenTien";
            this.menu_ChuyenTien.Size = new System.Drawing.Size(152, 22);
            this.menu_ChuyenTien.Text = "Chuyển tiền";
            this.menu_ChuyenTien.Click += new System.EventHandler(this.menu_ChuyenTien_Click);
            // 
            // menu_NhanTien
            // 
            this.menu_NhanTien.Name = "menu_NhanTien";
            this.menu_NhanTien.Size = new System.Drawing.Size(152, 22);
            this.menu_NhanTien.Text = "Nhận tiền";
            this.menu_NhanTien.Click += new System.EventHandler(this.menu_NhanTien_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem heToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Thoat;
        private System.Windows.Forms.ToolStripMenuItem menu_QLDangNhap;
        private System.Windows.Forms.ToolStripMenuItem menu_QLThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_RutTien;
        private System.Windows.Forms.ToolStripMenuItem menu_ChuyenTien;
        private System.Windows.Forms.ToolStripMenuItem menu_NhanTien;
    }
}



