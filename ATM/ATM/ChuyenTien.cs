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
    public partial class ChuyenTien : Form
    {
        //kết nối sql
        SqlConnection connection = new SqlConnection(Form1.DuongDan_KetNoiSQL.link);
        float soTienTaiKhoan = 0;// khai báo số tiền tài khoản
        string username = Form1.TentaiKhoan.Ten;//lấy dữ liệu từ Form1
        string time = "";//khai bao biến thời gian để sử dụng
        int check_User = 0; // kiem tra tai khoan ton tai khong -> chuyen tien
        public ChuyenTien()
        {
            InitializeComponent();
            connection.Open();
            txtTKNhan.Focus();
        }
        //----------------kiem tra tai khoan ton tai khong------------------------
         void UserNhan(string userNguoiNhan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM UserN WHERE username ='" + userNguoiNhan + "'", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        check_User = int.Parse(dr["SoTienTaiKhoan"].ToString());
                        //neu so tien check_user !=0 tai khoan ton tai
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
        //----------So tien tai khoan ------------------
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
                        //lay so tien tai khoan
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

        //-----------------luu lich su chuyen tien-----------------------
        void LichSuChuyen(string time, string TaiKhoanChuyen, string TaiKhoanNhan, float fSoTien)
        {
            try
            {
                SqlCommand Command = connection.CreateCommand();
                Command.CommandText = "Insert Chuyentien values('" + time + "','" + TaiKhoanChuyen + "','" + TaiKhoanNhan + "','" + fSoTien + "')";
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

        //------------------luu lich su nhan tien---------------------------
        void LichSuNhan(string time, string TaiKhoanNhan, string TaiKhoanChuyen, float fSoTien)
        {
            try
            {
                SqlCommand Command = connection.CreateCommand();
                Command.CommandText = "Insert Nhantien values('" + time + "','" + TaiKhoanNhan + "','" + TaiKhoanChuyen + "','" + fSoTien + "')";
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

        //---------------------cap nhan lai tai khoan nhan tien---------------
        void TienTaiKhoanNhan(string TaiKhoanNhan, float soTienNhan)
        {
            try
            {
                SqlCommand Command = connection.CreateCommand();
                Command.CommandText = "update UserN set SoTienTaiKhoan='" + (soTienTaiKhoan + soTienNhan) + "' where username='" + TaiKhoanNhan + "'";
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
       
        //time = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"); 
        private void btn_OK_Click(object sender, EventArgs e)
        {
            SoTienTK(); // so tien tai khoan
            if (string.IsNullOrEmpty(txtTKNhan.Text))
            {
                MessageBox.Show("Bạn vui lòng kiểm tra lại xem đã nhập tài khoản chuyển để thực hiện thao tác này!!", "Lỗi");
                txtTKNhan.Focus();
            }
            else
            {
                if (txtTKNhan.Text != username)
                {
                    UserNhan(txtTKNhan.Text);
                     if ( check_User==0)
                    {
                        MessageBox.Show("Tài khoản nhận tiền không tồn tại ","Thông báo");
                        txtTKNhan.Focus();
                     }
                    else
                     {
                        try
                        {
                            //kiem tra so tien nhap vao
                            if (string.IsNullOrEmpty(txt_SoTienChuyen.Text))
                            {
                                
                                    MessageBox.Show("Bạn vui lòng kiểm tra lại xem đã nhập số tiền chuyển chưa !!", "Lỗi");
                                    txt_SoTienChuyen.Focus();
                            }
                            else{
                                if (float.Parse(txt_SoTienChuyen.Text) < (soTienTaiKhoan - 50000))
                                {
                                    if (float.Parse(txt_SoTienChuyen.Text) > 50000 && (float.Parse(txt_SoTienChuyen.Text) % 2 == 0))
                                    {
                                        DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn chuyển không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (re == DialogResult.Yes)
                                        {
                                            SqlCommand Command = connection.CreateCommand();
                                            Command.CommandText = "update UserN set SoTienTaiKhoan='" + (soTienTaiKhoan - float.Parse(txt_SoTienChuyen.Text)) + "' where username='" + username + "'";
                                            Command.ExecuteNonQuery();

                                            time = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                                            LichSuChuyen(time, username, txtTKNhan.Text, float.Parse(txt_SoTienChuyen.Text));
                                            LichSuNhan(time, txtTKNhan.Text, username, float.Parse(txt_SoTienChuyen.Text));

                                            TienTaiKhoanNhan(txtTKNhan.Text, float.Parse(txt_SoTienChuyen.Text));
                                            txtTKNhan.Text = "";
                                            txt_SoTienChuyen.Text = "";
                                            MessageBox.Show("Bạn đã chuyển tiền thành công!!", "Thông báo");
                                            txtTKNhan.Text = "";
                                            txt_SoTienChuyen.Text = "";

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Số tiền cần chuyển phải lớn hơn 50000 và là bội của 50000!!", "Thông báo");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show(" Số dư Tài khoản không đủ để thực hiện giao dịch  !!", "Thông báo");
                                    txt_SoTienChuyen.Focus();
                                }
                            }
                            
                           
                        }
                        catch (FormatException fx)
                        {
                              MessageBox.Show("Lỗi nhập sai ,chỉ được nhập số ! "+ fx.Message, "Thông báo");
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
                    }
                else
                {
                    MessageBox.Show("Tài khoản nhận tiền không thể trùng với tài khoản của bạn !!", "Lỗi");
                    txtTKNhan.Focus();
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}