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
        //ket nối sql
        SqlConnection connection = new SqlConnection(Form1.DuongDan_KetNoiSQL.link);
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM UserN WHERE username ='" + Form1.TentaiKhoan.Ten + "'", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        //lay du lieu len label 
                        lbl_CMND.Text = "Số CMND : " + dr["CMND"].ToString();
                        lbl_HoTen.Text = "Họ va Tên : " + dr["HoTen"].ToString();
                        lbl_GioiTinh.Text = "Giới Tính : " + dr["GioiTinh"].ToString();
                        lbl_NgaySinh.Text = "Ngày Sinh : " + dr["NgaySinh"].ToString();
                        lbl_NoiSinh.Text = "Nơi Sinh : " + dr["NoiSinh"].ToString();
                        lbl_DiaChi.Text = "Địa Chỉ : " + dr["DiaChi"].ToString();
                        lbl_TenTaiKhoan.Text = "Số Tài Khoản : " + dr["username"].ToString();
                        lbl_SoTienTaiKhoan.Text = "Số Tiền TK : " + dr["SoTienTaiKhoan"].ToString() + " VND";
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();//dong form
        }
    }
}
