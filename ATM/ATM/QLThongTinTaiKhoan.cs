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
    public partial class QLThongTinTaiKhoan : Form
    {
        SqlConnection conection;
        SqlCommand Command;
        string st = @"Data Source=PHONG-PC\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public QLThongTinTaiKhoan()
        {
            InitializeComponent();
        }
        void loadData()
        {
            Command = conection.CreateCommand();
            Command.CommandText = "Select * from UserN";
            adapter.SelectCommand = Command;
            table.Clear();
            adapter.Fill(table);
            dgvUserN.DataSource = table;

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            Command = conection.CreateCommand();
            Command.CommandText = "insert into UserN values('" + txtCMND.Text + "','" + txtHoTen.Text + "','" + txtGioiTinh.Text + "','" + dateNgaySinh.Text + "','" + txtNoiSinh.Text + "','" + txtDiaChi.Text + "','" + txtSoTaiKhoan.Text + "','" + txtSoTienTaiKhoan.Text + "')";
            Command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Command = conection.CreateCommand();
            Command.CommandText = "delete from UserN where CMND ='" + txtCMND.Text + "'";
            Command.ExecuteNonQuery();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Command = conection.CreateCommand();
            Command.CommandText = "update UserN set CMND='" + txtCMND.Text + "',HoTen='" + txtHoTen.Text + "',GioiTinh='" + txtGioiTinh.Text + "',NgaySinh='" + dateNgaySinh.Text + "',NoiSinh='" + txtNoiSinh.Text + "',DiaChi='" + txtDiaChi.Text + "',username='"+txtSoTaiKhoan.Text+"',SoTienTaiKhoan='" + txtSoTienTaiKhoan.Text + "' where CMND='" + txtCMND.Text + "' ";
            Command.ExecuteNonQuery();
            loadData();
        }

        private void btn_KhoiTao_Click(object sender, EventArgs e)
        {
            txtCMND.Text = "";
            txtHoTen.Text = "";
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "";
            dateNgaySinh.Text = "10/10/2020";
            txtSoTaiKhoan.Text = "";
            txtSoTienTaiKhoan.Text = "";
            txtNoiSinh.Text = "";
            txtCMND.Focus();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            conection = new SqlConnection(st);
            conection.Open();
            loadData();
        }

        private void dgvUserN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            i = dgvUserN.CurrentRow.Index;
            txtCMND.Text = dgvUserN.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgvUserN.Rows[i].Cells[1].Value.ToString();
            txtGioiTinh.Text = dgvUserN.Rows[i].Cells[2].Value.ToString();
            dateNgaySinh.Text = dgvUserN.Rows[i].Cells[3].Value.ToString();
            txtNoiSinh.Text = dgvUserN.Rows[i].Cells[4].Value.ToString();
            txtDiaChi.Text = dgvUserN.Rows[i].Cells[5].Value.ToString();
            txtSoTaiKhoan.Text = dgvUserN.Rows[i].Cells[6].Value.ToString();
            txtSoTienTaiKhoan.Text = dgvUserN.Rows[i].Cells[7].Value.ToString();
        }
        public void closeForm()
        {
            this.Dispose();
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            closeForm();
            Form1 f = new Form1();
            f.Show();
        }

        private void btnQLDN_Click(object sender, EventArgs e)
        {
            QLDangNhap ql = new QLDangNhap();
            ql.Show();
            this.Hide();
        }
    }
}
