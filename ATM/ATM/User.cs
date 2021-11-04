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
        public User()
        {
            InitializeComponent();
            labelTaiKhoan.Text = Form1.TentaiKhoan.Ten;
        }

        private void btn_ThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan th = new ThongTinTaiKhoan();
            th.Show();
            this.Hide();
        }
    }
}
