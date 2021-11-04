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
        SqlConnection conection;
        SqlCommand Command;
        string st = @"Data Source=PHONG-PC\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public QLChuyenTien()
        {
            InitializeComponent();
        }

        void loadData()
        {
            Command = conection.CreateCommand();
            Command.CommandText = "Select * from ChuyenTien";
            adapter.SelectCommand = Command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void QLChuyenTien_Load(object sender, EventArgs e)
        {
            conection = new SqlConnection(st);
            conection.Open();
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            i = dataGridView1.CurrentRow.Index;
            date_TimeChuyen.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_TKChuyen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_TKNhan.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_SoTien.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Command = conection.CreateCommand();
            Command.CommandText = "insert into ChuyenTien values('" + date_TimeChuyen.Text + "','" + txt_TKChuyen.Text + "','" + txt_TKNhan.Text + "','" + txt_SoTien.Text+ "')";
            Command.ExecuteNonQuery();
            loadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            Command = conection.CreateCommand();
            Command.CommandText = "delete from ChuyenTien where TimeChuyen ='" + date_TimeChuyen.Text + "'";
            Command.ExecuteNonQuery();
            loadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Command = conection.CreateCommand();
            Command.CommandText = "update ChuyenTien set TimeChuyen='" + date_TimeChuyen.Text + "',username='" + txt_TKChuyen.Text + "',userNhan='" + txt_TKNhan.Text + "',soTienChuyen='" + txt_SoTien.Text + "' where TimeChuyen='" + date_TimeChuyen.Text + "' ";
            Command.ExecuteNonQuery();
            loadData();
        }

        private void btn_KhoiTao_Click(object sender, EventArgs e)
        {
            date_TimeChuyen.Text = "1/1/2000";
            txt_TKChuyen.Text = "";
            txt_TKNhan.Text = "";
            txt_SoTien.Text = "";
        }
    }
}
