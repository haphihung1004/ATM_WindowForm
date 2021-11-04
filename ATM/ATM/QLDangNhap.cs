using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace ATM
{
    public partial class QLDangNhap : Form
    {
        public class DanhSach
        { 
            static public ArrayList ds= new ArrayList();
        }
        
        //khai bao ket noi sql
        SqlConnection conection;
        SqlCommand Command;
        string st = Form1.DuongDan_KetNoiSQL.link;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public QLDangNhap()
        {
            InitializeComponent();
        }
        void loadData() // load dữ liệu từ sql lên bảng
        {
            try
            {
                Command = conection.CreateCommand();
                Command.CommandText = "Select * from DangNhap";
                adapter.SelectCommand = Command;
                table.Clear();
                adapter.Fill(table);
                dgvQLDangNhap.DataSource = table;
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
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                //thêm dữ liệu vào table DangNhap
                DanhSach.ds.Add(txt_User.Text) ;
                Command = conection.CreateCommand();
                Command.CommandText = "insert into DangNhap values('" + txt_User.Text + "','" + txt_Pass.Text + "', '" + cmb_Type.Text + "')";
                Command.ExecuteNonQuery();
                loadData();
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                //xoa du lieu duoc chon trong table DangNhap
                Command = conection.CreateCommand();
                Command.CommandText = "delete from DangNhap where username ='" + txt_User.Text + "'";
                Command.ExecuteNonQuery();
                loadData();
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                //cập nhật dữ liệu bảng DangNhap
                Command = conection.CreateCommand();
                Command.CommandText = "update DangNhap set username='" + txt_User.Text + "',password='" + txt_Pass.Text + "',type='" + cmb_Type.Text + "'  where username ='" + txt_User.Text + "'";
                Command.ExecuteNonQuery();
                loadData();
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

        private void btn_KhoiTao_Click(object sender, EventArgs e)
        {
            //reset dữ liệu các TextBox
            txt_User.Text = "";
            txt_Pass.Text = "";
            cmb_Type.Text = "";
        }

        private void QLDangNhap_Load(object sender, EventArgs e)
        {
            // bắt dầu kết nối sql
            try
            {
                conection = new SqlConnection(st);
                conection.Open();
                loadData();
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

        private void dgvQLDangNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy dữ liêu từ bảng
            int i = 0;
            i = dgvQLDangNhap.CurrentRow.Index;
            txt_User.Text = dgvQLDangNhap.Rows[i].Cells[0].Value.ToString();
            txt_Pass.Text = dgvQLDangNhap.Rows[i].Cells[1].Value.ToString();
            cmb_Type.Text = dgvQLDangNhap.Rows[i].Cells[2].Value.ToString();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
