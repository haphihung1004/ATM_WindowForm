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
    public partial class LichSuGiaoDich : Form
    {
        SqlConnection connection = new SqlConnection(Form1.DuongDan_KetNoiSQL.link);
        string username = Form1.TentaiKhoan.Ten;
        public LichSuGiaoDich()
        {
            InitializeComponent();
            try
            {
                string txt = "";
                //-------------------rut tien-----------------
                SqlCommand cmd = new SqlCommand("SELECT * FROM RutTien WHERE username ='" + username + "'", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {

                        txt += (dr["TimeRut"].ToString() + "     bạn rút từ tài khoản: " + dr["username"].ToString() + ", So tien: " + dr["SoTienRut"].ToString() + " VND ") + "\n";
                    }
                }
                //-------------------nap tien-----------------
                SqlCommand cmd3 = new SqlCommand("SELECT * FROM NapTien WHERE username ='" + username + "'", connection);
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                da.Fill(dt3);
                if (dt3 != null)
                {
                    foreach (DataRow dr in dt3.Rows)
                    {

                        txt += (dr["TimeNap"].ToString() + "     bạn nạp vào tài khoản: " + dr["username"].ToString() + ", So tien: " + dr["SoTienNap"].ToString() + " VND ") + "\n";
                    }
                }
                //--------------------chuyen tien ----------------------
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM ChuyenTien WHERE username ='" + username + "'", connection);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1 != null)
                {
                    foreach (DataRow dr in dt1.Rows)
                    {

                        txt += (dr["TimeChuyen"].ToString() + "      bạn đã chuyển tới tài khoản: " + dr["userNhan"].ToString() + ", So tien: " + dr["soTienChuyen"].ToString() + " VND ") + "\n";
                    }
                }
                //---------------------nhan tien ----------------------
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM NhanTien WHERE username ='" + username + "'", connection);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                if (dt2 != null)
                {
                    foreach (DataRow dr in dt2.Rows)
                    {

                        txt += (dr["TimeNhan"].ToString() + "  bạn đã nhận được từ tài khoản: " + dr["userChuyen"].ToString() + ", So tien: " + dr["soTienNhan"].ToString() + " VND ") + "\n";
                    }
                }
                richText_LichSu.Text = txt;
            }catch(Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !", "Thong bao");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();//dong form
        }

       
    }
}
