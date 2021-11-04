namespace ATM
{
    partial class User
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
            this.menu_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ThongTinTK = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_RutTien = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ChuyenTien = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_giaodich = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Doi_MK = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_NapTien = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menu_Logout});
            this.heToolStripMenuItem.Name = "heToolStripMenuItem";
            this.heToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.heToolStripMenuItem.Text = "Hệ Thống";
            // 
            // menu_Logout
            // 
            this.menu_Logout.Name = "menu_Logout";
            this.menu_Logout.Size = new System.Drawing.Size(127, 22);
            this.menu_Logout.Text = "Đăng xuất";
            this.menu_Logout.Click += new System.EventHandler(this.menu_Logout_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ThongTinTK,
            this.menu_RutTien,
            this.menu_ChuyenTien,
            this.menu_giaodich,
            this.menu_Doi_MK,
            this.menu_NapTien});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // menu_ThongTinTK
            // 
            this.menu_ThongTinTK.Name = "menu_ThongTinTK";
            this.menu_ThongTinTK.Size = new System.Drawing.Size(202, 22);
            this.menu_ThongTinTK.Text = "Xem thông tin tài khoản";
            this.menu_ThongTinTK.Click += new System.EventHandler(this.menu_ThongTinTK_Click);
            // 
            // menu_RutTien
            // 
            this.menu_RutTien.Name = "menu_RutTien";
            this.menu_RutTien.Size = new System.Drawing.Size(202, 22);
            this.menu_RutTien.Text = "Rút tiền";
            this.menu_RutTien.Click += new System.EventHandler(this.menu_RutTien_Click);
            // 
            // menu_ChuyenTien
            // 
            this.menu_ChuyenTien.Name = "menu_ChuyenTien";
            this.menu_ChuyenTien.Size = new System.Drawing.Size(202, 22);
            this.menu_ChuyenTien.Text = "Chuyển tiền";
            this.menu_ChuyenTien.Click += new System.EventHandler(this.menu_ChuyenTien_Click);
            // 
            // menu_giaodich
            // 
            this.menu_giaodich.Name = "menu_giaodich";
            this.menu_giaodich.Size = new System.Drawing.Size(202, 22);
            this.menu_giaodich.Text = "Lịch sử giao dich";
            this.menu_giaodich.Click += new System.EventHandler(this.menu_giaodich_Click);
            // 
            // menu_Doi_MK
            // 
            this.menu_Doi_MK.Name = "menu_Doi_MK";
            this.menu_Doi_MK.Size = new System.Drawing.Size(202, 22);
            this.menu_Doi_MK.Text = "Đổi mật khẩu";
            this.menu_Doi_MK.Click += new System.EventHandler(this.menu_Doi_MK_Click);
            // 
            // menu_NapTien
            // 
            this.menu_NapTien.Name = "menu_NapTien";
            this.menu_NapTien.Size = new System.Drawing.Size(202, 22);
            this.menu_NapTien.Text = "Nạp tiền tài khoản";
            this.menu_NapTien.Click += new System.EventHandler(this.menu_NapTien_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "User";
            this.Text = "User";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem heToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_Logout;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_ThongTinTK;
        private System.Windows.Forms.ToolStripMenuItem menu_RutTien;
        private System.Windows.Forms.ToolStripMenuItem menu_ChuyenTien;
        private System.Windows.Forms.ToolStripMenuItem menu_giaodich;
        private System.Windows.Forms.ToolStripMenuItem menu_Doi_MK;
        private System.Windows.Forms.ToolStripMenuItem menu_NapTien;
    }
}



