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
    public partial class Nap_Tien_Tai_Khoan : Form
    {
        string time = "";//khai bao bien thoi gian
        //ket noi sql
        SqlConnection connection = new SqlConnection(Form1.DuongDan_KetNoiSQL.link);
        float soTienTaiKhoan = 0;
        string username = Form1.TentaiKhoan.Ten;//lay ten dang nhap tu form 1

        public Nap_Tien_Tai_Khoan()
        {
            InitializeComponent();
            connection.Open();
        }

        void SoTienTK()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM UserN WHERE username ='" + username + "'", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        soTienTaiKhoan = float.Parse(dr["SoTienTaiKhoan"].ToString());
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
        void LichSuNap(string time, string tenTK, float fSoTien)
        {
            try
            {
                SqlCommand Command = connection.CreateCommand();
                Command.CommandText = "Insert NapTien values('" + time + "','" + tenTK + "','" + fSoTien + "')";
                Command.ExecuteNonQuery();
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

        private void btn_50_Click(object sender, EventArgs e)
        {
            try
            {
                SoTienTK();

                DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn nạp thêm tiền không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    SqlCommand Command = connection.CreateCommand();
                    Command.CommandText = "update UserN set SoTienTaiKhoan='" + (soTienTaiKhoan + 50000) + "' where username='" + username + "'";
                    Command.ExecuteNonQuery();
                    time = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                    LichSuNap(time, username, 50000);
                    MessageBox.Show("Bạn đã rút tiền thành công!!", "Thông báo");
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

        private void btn_100_Click(object sender, EventArgs e)
        {
            try
            {
                SoTienTK();

                DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn nạp thêm tiền không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    SqlCommand Command = connection.CreateCommand();
                    Command.CommandText = "update UserN set SoTienTaiKhoan='" + (soTienTaiKhoan + 100000) + "' where username='" + username + "'";
                    Command.ExecuteNonQuery();
                    time = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                    LichSuNap(time, username, 100000);
                    MessageBox.Show("Bạn đã rút tiền thành công!!", "Thông báo");
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

        private void btn_200_Click(object sender, EventArgs e)
        {
            try
            {
                SoTienTK();

                DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn nạp thêm tiền không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    SqlCommand Command = connection.CreateCommand();
                    Command.CommandText = "update UserN set SoTienTaiKhoan='" + (soTienTaiKhoan + 200000) + "' where username='" + username + "'";
                    Command.ExecuteNonQuery();
                    time = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                    LichSuNap(time, username, 200000);
                    MessageBox.Show("Bạn đã rút tiền thành công!!", "Thông báo");
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

        private void btn_500_Click(object sender, EventArgs e)
        {
            try
            {
                SoTienTK();

                DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn nạp thêm tiền không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    SqlCommand Command = connection.CreateCommand();
                    Command.CommandText = "update UserN set SoTienTaiKhoan='" + (soTienTaiKhoan + 500000) + "' where username='" + username + "'";
                    Command.ExecuteNonQuery();
                    time = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                    LichSuNap(time, username, 500000);
                    MessageBox.Show("Bạn đã rút tiền thành công!!", "Thông báo");
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
