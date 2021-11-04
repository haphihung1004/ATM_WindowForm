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
    public partial class QLNhanTien : Form
    {
        //khai bao ket noi sql
        SqlConnection conection;
        SqlCommand Command;
        string st = Form1.DuongDan_KetNoiSQL.link;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public QLNhanTien()
        {
            InitializeComponent();
        }
        void loadData()//load du lieu sql lên bảng 
        {
            try
            {
                Command = conection.CreateCommand();
                Command.CommandText = "Select * from NhanTien";
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
        private void QLNhanTien_Load(object sender, EventArgs e)
        {
            try
            {
                //bat dau kêt nối sql
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
                //them du lieu bang NhanTien
                Command = conection.CreateCommand();
                Command.CommandText = "insert into NhanTien values('" + txt_date.Text + "','" + txt_TKNhan.Text + "','" + txt_TKChuyen.Text + "','" + txt_SoTienNhan.Text + "')";
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
                // xoa du lieu duoc chon tu banmg
                Command = conection.CreateCommand();
                Command.CommandText = "delete from NhanTien where TimeNhan ='" + txt_date.Text + "'";
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
                //sua du liêu bangNhanTien
                Command = conection.CreateCommand();
                Command.CommandText = "update NhanTien set TimeNhan='" + txt_date.Text + "',username='" + txt_TKNhan.Text + "',userChuyen='" + txt_TKChuyen.Text + "',soTienNhan='" + txt_SoTienNhan.Text + "' where TimeNhan='" + txt_date.Text + "' ";
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
            txt_SoTienNhan.Text = "";
            txt_TKChuyen.Text = "";
            txt_TKNhan.Text = "";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //lay du lieu tu bang
            int i = 0;
            i = dataGridView1.CurrentRow.Index;
            txt_date.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_TKNhan.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_TKChuyen.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_SoTienNhan.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();//dong form
        }
    }
}
