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
    public partial class User : Form
    {

        public User()//form nguoi dung
        {
            InitializeComponent();
        }

        private void menu_Logout_Click(object sender, EventArgs e)
        {
            //log out
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void menu_ThongTinTK_Click(object sender, EventArgs e)
        {
            // thong tin tai khoan
            ThongTinTaiKhoan tk = new ThongTinTaiKhoan();
            tk.MdiParent = this;
            tk.Show();
        }

        private void menu_RutTien_Click(object sender, EventArgs e)
        {
            //rut tien
            RutTien rt = new RutTien();
            rt.MdiParent = this;
            rt.Show();
        }

        private void menu_ChuyenTien_Click(object sender, EventArgs e)
        {
            //chuyen tien
            ChuyenTien ct = new ChuyenTien();
            ct.MdiParent = this;
            ct.Show();
        }

        private void menu_giaodich_Click(object sender, EventArgs e)
        {
            //lich su giao dich
            LichSuGiaoDich ls = new LichSuGiaoDich();
            ls.MdiParent = this;
            ls.Show();
        }

       

        private void menu_Doi_MK_Click(object sender, EventArgs e)
        {
            // doi mat khau
            Doi_Mat_Khau dmk = new Doi_Mat_Khau();
            dmk.MdiParent = this;
            dmk.Show();
        }

        private void menu_NapTien_Click(object sender, EventArgs e)
        {
            //nap tien tai khoan
            Nap_Tien_Tai_Khoan nap = new Nap_Tien_Tai_Khoan();
            nap.MdiParent = this;
            nap.Show();
        }
    }
}
