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
    public partial class Form1 : Form
    {
        string type = ""; // kieu admin or user
        public Form1()
        {
            InitializeComponent();
            txtUserName.Focus();
        }
        public class TentaiKhoan
        { // truyen ten tai khoan qua form user
            static public string Ten;
        }
        private void rdo_admin_CheckedChanged(object sender, EventArgs e)
        {
            type = "admin";
        }

        private void rdo_user_CheckedChanged(object sender, EventArgs e)
        {
            type = "user";
        }
        private void btn_logon_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=PHONG-PC\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True");
            string tk = txtUserName.Text;
            string mk = txtPassword.Text;
            try
            {
                connect.Open();
                string query = "select * from DangNhap where (username='" + tk + "' and password='" + mk + "') and type='" + type + "'";
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read() == true)
                {

                    if (type == "admin")
                    {
                        Admin a = new Admin();
                        this.Hide();
                        a.Show();

                    }
                    else if (type == "user")
                    {
                        TentaiKhoan.Ten = txtUserName.Text;
                        User u = new User();
                        this.Hide();
                        u.Show();

                    }
                }

                else
                {
                    MessageBox.Show("Tai khoan hoac mat khau sai");

                }
                txtUserName.Text = "";
                txtPassword.Text = "";
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message, "Thong bao");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
