using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM
{
    public partial class QLDangNhap : Form
    {
        SqlConnection conection;
        SqlCommand Command;
        string st = @"Data Source=PHONG-PC\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public QLDangNhap()
        {
            InitializeComponent();
        }
        void loadData()
        {
            Command = conection.CreateCommand();
            Command.CommandText = "Select * from DangNhap";
            adapter.SelectCommand = Command;
            table.Clear();
            adapter.Fill(table);
            dgvQLDangNhap.DataSource = table;

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            Command = conection.CreateCommand();
            Command.CommandText = "insert into DangNhap values('" + txt_User.Text + "','" + txt_Pass.Text+"', '"+cmb_Type.Text+"')";
            Command.ExecuteNonQuery();
            loadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            Command = conection.CreateCommand();
            Command.CommandText = "delete from DangNhap where CMND ='" + txt_User.Text + "'";
            Command.ExecuteNonQuery();
            loadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Command = conection.CreateCommand();
            Command.CommandText = "update DangNhap set username='" + txt_User.Text +"',password='"+txt_Pass.Text+"',type='"+cmb_Type.Text+"'";
            Command.ExecuteNonQuery();
            loadData();
        }

        private void btn_KhoiTao_Click(object sender, EventArgs e)
        {
            txt_User.Text = "";
            txt_Pass.Text = "";
            cmb_Type.Text = "";
        }
        public void closeForm()
        {
            this.Dispose();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            closeForm();
            QLThongTinTaiKhoan f = new QLThongTinTaiKhoan();
            f.Show();
        }

        private void QLDangNhap_Load(object sender, EventArgs e)
        {
            conection = new SqlConnection(st);
            conection.Open();
            loadData();
        }
    }
}
