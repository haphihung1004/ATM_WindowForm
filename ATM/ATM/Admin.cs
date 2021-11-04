using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATM
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Menu_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void menu_QLDangNhap_Click(object sender, EventArgs e)
        {
            QLDangNhap qldn = new QLDangNhap();
            qldn.MdiParent = this;
            qldn.Show();
        }

        private void menu_QLThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            QLThongTinTaiKhoan qltk = new QLThongTinTaiKhoan();
            qltk.MdiParent = this;
            qltk.Show();
        }

        private void menu_RutTien_Click(object sender, EventArgs e)
        {
            QLRutTien rt = new QLRutTien();
            rt.MdiParent = this;
            rt.Show();
        }

        private void menu_ChuyenTien_Click(object sender, EventArgs e)
        {
            QLChuyenTien ct = new QLChuyenTien();
            ct.MdiParent = this;
            ct.Show();
        }

        private void menu_NhanTien_Click(object sender, EventArgs e)
        {
            QLNhanTien nt = new QLNhanTien();
            nt.MdiParent = this;
            nt.Show();
        }
    }
}
