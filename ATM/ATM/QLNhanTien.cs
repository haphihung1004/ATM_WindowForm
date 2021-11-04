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
        SqlConnection conection;
        SqlCommand Command;
        string st = @"Data Source=PHONG-PC\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public QLNhanTien()
        {
            InitializeComponent();
        }
        void loadData()
        {
            Command = conection.CreateCommand();
            Command.CommandText = "Select * from NhanTien";
            adapter.SelectCommand = Command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        private void QLNhanTien_Load(object sender, EventArgs e)
        {
            conection = new SqlConnection(st);
            conection.Open();
            loadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Command = conection.CreateCommand();
            Command.CommandText = "insert into NhanTien values('" + date_NhanTien.Text + "','" + txt_TKNhan.Text + "','" + txt_TKChuyen.Text + "','" + txt_SoTienNhan.Text + "')";
            Command.ExecuteNonQuery();
            loadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            Command = conection.CreateCommand();
            Command.CommandText = "delete from NhanTien where TimeNhan ='" + date_NhanTien.Text + "'";
            Command.ExecuteNonQuery();
            loadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Command = conection.CreateCommand();
            Command.CommandText = "update NhanTien set TimeNhan='" + date_NhanTien.Text + "',username='" + txt_TKNhan.Text + "',userChuyen='" + txt_TKChuyen.Text + "',soTienNhan='" + txt_SoTienNhan.Text + "' where TimeNhan='" + date_NhanTien.Text + "' ";
            Command.ExecuteNonQuery();
            loadData();
        }

        private void btn_KhoiTao_Click(object sender, EventArgs e)
        {
            date_NhanTien.Text = "1/1/2000";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = dataGridView1.CurrentRow.Index;
            date_NhanTien.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_TKNhan.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_TKChuyen.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_SoTienNhan.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }
    }
}
