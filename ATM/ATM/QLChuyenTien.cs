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
    public partial class QLChuyenTien : Form
    {
        //khai bao ket noi sql
        SqlConnection conection;
        SqlCommand Command;
        string st = Form1.DuongDan_KetNoiSQL.link;// link ket noi sql
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public QLChuyenTien()
        {
            InitializeComponent();
        }

        void loadData()//load dữ liệu từ sql lên bảng
        {
            try
            {
                Command = conection.CreateCommand();
                Command.CommandText = "Select * from ChuyenTien";
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

        private void QLChuyenTien_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // lấy dữ liệu từ bảng
                int i = 0;
                i = dataGridView1.CurrentRow.Index;
                txt_date.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txt_TKChuyen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txt_TKNhan.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txt_SoTien.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
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
                Command.CommandText = "insert into ChuyenTien values('" + txt_date.Text + "','" + txt_TKChuyen.Text + "','" + txt_TKNhan.Text + "','" + txt_SoTien.Text + "')";
                Command.ExecuteNonQuery();// thêm dữ liệu chuyển tiền
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
                Command.CommandText = "delete from ChuyenTien where TimeChuyen ='" + txt_date.Text + "'";
                Command.ExecuteNonQuery();//xoa dữ liêu jchuyeenr tiền
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
                Command.CommandText = "update ChuyenTien set TimeChuyen='" + txt_date.Text + "',username='" + txt_TKChuyen.Text + "',userNhan='" + txt_TKNhan.Text + "',soTienChuyen='" + txt_SoTien.Text + "' where TimeChuyen='" + txt_date.Text + "' ";
                Command.ExecuteNonQuery();//cập nhật dữ liệu Chuyển Tiền
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
            txt_date.Text = "";
            txt_TKChuyen.Text = "";
            txt_TKNhan.Text = "";
            txt_SoTien.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();//dong form
        }
    }
}
