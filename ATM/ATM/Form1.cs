/*
 * Đồ án nhóm : Thịnh - Hùng 
 * Đề tài: Mô phỏng chức năng ATM
 */
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
        //link ket noi sql
        string st = @"Data Source=PHONG-PC\SQLEXPRESS;Initial Catalog=ATM1;Integrated Security=True";
        string type = ""; // kieu admin or user
        public Form1()
        {
            InitializeComponent();
            txtUserName.Focus();
        }
        public class DuongDan_KetNoiSQL {
            static public string link;
        }
        public class TentaiKhoan
        { // truyen ten tai khoan qua form user
            static public string Ten;
        }
        //kiem tra đăng nhập type là admin hay user
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
            DuongDan_KetNoiSQL.link = st; // chuyển dữ liệu đường link kết nối sql qua các form khác
            SqlConnection connect = new SqlConnection(st);//ket noi sql
            string tk = txtUserName.Text;
            string mk = txtPassword.Text;
            try
            {
                if (string.IsNullOrEmpty(txtUserName.Text)) {
                    MessageBox.Show("Ban phải nhập tài khoản trước để tiếp tục ", "Lỗi");
                    txtUserName.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtPassword.Text))
                    {
                        MessageBox.Show("Ban phải nhập đầy đủ tài khoản và mật khẩu để đăng nhập ", "Lỗi");
                        txtUserName.Focus();
                    }
                    else
                    {
                        connect.Open();//mo ket noi sql
                        string query = "select * from DangNhap where (username='" + tk + "' and password='" + mk + "') and type='" + type + "'";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        SqlDataReader read = cmd.ExecuteReader();//đọc dữ liệu sql
                        if (read.Read() == true)//nếu thông tin đăng nhập chính xác
                        {

                            if (type == "admin")//nếu loại đăng nhập là admin thì chuyển qua form Admin
                            {

                                Admin a = new Admin();
                                this.Hide();
                                a.Show();

                            }
                            else if (type == "user")//nếu loại đăng nhập là user thì chuyển qua form User
                            {
                                TentaiKhoan.Ten = txtUserName.Text;
                                User u = new User();
                                this.Hide();
                                u.Show();

                            }
                        }

                        else
                        {
                            MessageBox.Show("Tai khoan hoac mat khau sai hoac type dang nhap khong dung", "Lỗi");

                        }
                        connect.Close();//đóng kết nối sql
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        rdo_admin.Checked = false;
                        rdo_user.Checked = false;
                    }
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !", "Thong bao");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message, "Thong bao");
            }
        
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();//thoat ứng dụng
        }
    }
}
