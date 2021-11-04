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
        SqlConnection conection;
        SqlCommand Command;
        string st = @"Data Source=PHONG-PC\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public QLRutTien()
        {
            InitializeComponent();
        }

        void loadData()
        {
            Command = conection.CreateCommand();
            Command.CommandText = "Select * from RutTien";
            adapter.SelectCommand = Command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void QLRutTien_Load(object sender, EventArgs e)
        {
            conection = new SqlConnection(st);
            conection.Open();
            loadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Command = conection.CreateCommand();
            Command.CommandText = "insert into RutTien values('" + date_RutTien.Text + "','" + txt_TKRut.Text + "','" + txt_SoTienRut.Text + "')";
            Command.ExecuteNonQuery();
            loadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            Command = conection.CreateCommand();
            Command.CommandText = "delete from RutTien where TimeRut ='" + date_RutTien.Text + "'";
            Command.ExecuteNonQuery();
            loadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Command = conection.CreateCommand();
            Command.CommandText = "update RutTien set TimeRut='" + date_RutTien.Text + "',username='" + txt_TKRut.Text + "',soTienRut='" + txt_SoTienRut.Text +  "' where TimeRut='" + date_RutTien.Text + "' ";
            Command.ExecuteNonQuery();
            loadData();
        }

        private void btn_KhoiTao_Click(object sender, EventArgs e)
        {
            date_RutTien.Text = "1/1/2000";
            txt_TKRut.Text = "";
            txt_SoTienRut.Text = "";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = dataGridView1.CurrentRow.Index;
            date_RutTien.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_TKRut.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_SoTienRut.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }
    }
}
