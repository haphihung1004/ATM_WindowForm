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
        public int a = 0;
        //khai bao ket noi sql
        SqlConnection conection;
        SqlCommand Command;
        string st = Form1.DuongDan_KetNoiSQL.link;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public QLThongTinTaiKhoan()
        {
            InitializeComponent();
            if (QLDangNhap.DanhSach.ds.Count != 0)
            {
                txtSoTaiKhoan.DataSource = QLDangNhap.DanhSach.ds;
                txtSoTaiKhoan.Text = "";
                
                    dateNgaySinh.Enabled = false;
                    txtCMND.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtGioiTinh.Enabled = false;
                    txtHoTen.Enabled = false;
                    txtNoiSinh.Enabled = false;
                    txtSoTienTaiKhoan.Enabled = false;
                    

                  DialogResult r;
                r = MessageBox.Show("Ban co muon nhap thong tin cho tai khoan moi khong", "Thong Bao",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    a = 1;
                    txtCMND.Enabled = true;
                    txtDiaChi.Enabled = true;
                    txtGioiTinh.Enabled = true;
                    txtHoTen.Enabled = true;
                    txtNoiSinh.Enabled = true;
                    txtSoTienTaiKhoan.Enabled = true;
                    dateNgaySinh.Enabled = true;
                }
            }
        }
        void loadData()//load du lieu len bang
        {
            try
            {
                Command = conection.CreateCommand();
                Command.CommandText = "Select * from UserN";
                adapter.SelectCommand = Command;
                table.Clear();
                adapter.Fill(table);
                dgvUserN.DataSource = table;
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
                if (a == 0)
                {
                    txtCMND.Enabled = true;
                    txtDiaChi.Enabled = true;
                    txtGioiTinh.Enabled = true;
                    txtHoTen.Enabled = true;
                    txtNoiSinh.Enabled = true;
                    txtSoTienTaiKhoan.Enabled = true;
                    dateNgaySinh.Enabled = true;
                }
                if (string.IsNullOrEmpty(txtCMND.Text))
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ để thêm", "Thông báo");
                    txtCMND.Focus();
                }
                else
                {

                    Command = conection.CreateCommand();
                    Command.CommandText = "insert into UserN values('" + txtCMND.Text + "','" + txtHoTen.Text + "','" + txtGioiTinh.Text + "','" + dateNgaySinh.Text + "','" + txtNoiSinh.Text + "','" + txtDiaChi.Text + "','" + txtSoTaiKhoan.Text + "','" + txtSoTienTaiKhoan.Text + "')";
                    QLDangNhap.DanhSach.ds.Remove(txtSoTaiKhoan.Text);
                    Command.ExecuteNonQuery();
                    loadData();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Command = conection.CreateCommand();
                Command.CommandText = "delete from UserN where CMND ='" + txtCMND.Text + "'";
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Command = conection.CreateCommand();
                Command.CommandText = "update UserN set CMND='" + txtCMND.Text + "',HoTen=N'" + txtHoTen.Text + "',GioiTinh=N'" + txtGioiTinh.Text + "',NgaySinh='" + dateNgaySinh.Text + "',NoiSinh='" + txtNoiSinh.Text + "',DiaChi='" + txtDiaChi.Text + "',username='" + txtSoTaiKhoan.Text + "',SoTienTaiKhoan='" + txtSoTienTaiKhoan.Text + "' where CMND='" + txtCMND.Text + "' ";
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
            //khoi tao du lieu
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

        private void dgvUserN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lay du lieu bang len form
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
       

        private void btnQLDN_Click(object sender, EventArgs e)
        {
            QLDangNhap ql = new QLDangNhap();
            ql.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //dong form
            this.Close();
        }
    }
}
