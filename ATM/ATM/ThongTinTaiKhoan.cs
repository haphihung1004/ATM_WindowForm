using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ATM
{
    public partial class ThongTinTaiKhoan : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=PHONG-PC\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True");
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserN WHERE username ='" + Form1.TentaiKhoan.Ten + "'", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lbl_CMND.Text = "So CMND: " + dr["CMND"].ToString();
                    lbl_HoTen.Text = "Ho va Ten :" + dr["HoTen"].ToString() ;
                    lbl_GioiTinh.Text = "GioiTinh" + dr["GioiTinh"].ToString();
                    lbl_NgaySinh.Text = "NgaySinh" + dr["NgaySinh"].ToString();
                    lbl_NoiSinh.Text = "Noi Sinh:" + dr["NoiSinh"].ToString();
                    lbl_DiaChi.Text = "Dia Chi :" + dr["DiaChi"].ToString();
                    lbl_TenTaiKhoan.Text = "So Tai Khoan:" + dr["username"].ToString();
                    lbl_SoTienTaiKhoan.Text = "So Tien TK:" + dr["SoTienTaiKhoan"].ToString();
                }
            }
        }
        public void closeForm()
        {
            this.Dispose();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            closeForm();
            User f = new User();
            f.Show();
        }
    }
}
