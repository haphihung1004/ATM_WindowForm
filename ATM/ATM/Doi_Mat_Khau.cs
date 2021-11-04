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
    public partial class Doi_Mat_Khau : Form
    {
        //ket noi sql
        SqlConnection connection = new SqlConnection(Form1.DuongDan_KetNoiSQL.link);
        string username = Form1.TentaiKhoan.Ten;
        public Doi_Mat_Khau()
        {
            InitializeComponent();
            connection.Open();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                //kiem tra mật khẩu nhập vào với xác nhận mật khẩu
                if (string.IsNullOrEmpty(txt_MK_new.Text)==false && string.IsNullOrEmpty(txt_MK_new_comfirm.Text)==false)
                {
                    if (txt_MK_new.Text == txt_MK_new_comfirm.Text)
                    {
                        //cập nhật lại mật khẩu
                        SqlCommand Command = connection.CreateCommand();
                        Command.CommandText = "update DangNhap set password='" + txt_MK_new.Text + "' where username='" + username + "'";
                        Command.ExecuteNonQuery();
                        MessageBox.Show("Bạn đã đổi mật khẩu thành công!!", "Thông báo");
                        txt_MK_new.Text = "";
                        txt_MK_new_comfirm.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu xác nhận phải trùng với mật khẩu mới. Kiểm tra lại !!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải nhập mật khẩu mới và xác nhận MK để thực hiện thao tác này !!", "Thông báo");
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
