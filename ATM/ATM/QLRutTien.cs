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
    public partial class QLRutTien : Form
    {
        //khai bao ket noi sql
        SqlConnection conection;
        SqlCommand Command;
        string st = Form1.DuongDan_KetNoiSQL.link;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public QLRutTien()
        {
            InitializeComponent();
        }

        void loadData()//load dữ liệu sql lên bảng
        {
            try
            {
                Command = conection.CreateCommand();
                Command.CommandText = "Select * from RutTien";
                adapter.SelectCommand = Command;
                table.Clear();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
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

        private void QLRutTien_Load(object sender, EventArgs e)
        {
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                Command = conection.CreateCommand();
                Command.CommandText = "insert into RutTien values('" + txt_date.Text + "','" + txt_TKRut.Text + "','" + txt_SoTienRut.Text + "')";
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
                Command = conection.CreateCommand();
                Command.CommandText = "delete from RutTien where TimeRut ='" + txt_date.Text + "'";
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
                Command = conection.CreateCommand();
                Command.CommandText = "update RutTien set TimeRut='" + txt_date.Text + "',username='" + txt_TKRut.Text + "',soTienRut='" + txt_SoTienRut.Text + "' where TimeRut='" + txt_date.Text + "' ";
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
            //reset TextBox 
            txt_date.Text = "";
            txt_TKRut.Text = "";
            txt_SoTienRut.Text = "";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //Lay du lieu lên bang
            int i = 0;
            i = dataGridView1.CurrentRow.Index;
            txt_date.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_TKRut.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_SoTienRut.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();//dong form
        }

     
    }
}
