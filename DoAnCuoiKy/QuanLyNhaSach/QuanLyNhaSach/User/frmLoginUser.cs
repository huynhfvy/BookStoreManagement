using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using QuanLyNhaSach.User;
using QuanLyNhaSach.Admin;

namespace QuanLyNhaSach.User
{
    public partial class frmLoginUser : Form
    {
        static string UserName;
        public static string _UserName
        {
            get { return UserName; }
            set { UserName = value; }
        }
        SqlConnection connection;
        string s = @"Data Source=" + Program.server_name + ";Initial Catalog = QuanLyNhaSach; Integrated Security = True";
        public frmLoginUser()
        {
            InitializeComponent();
            connection = new SqlConnection(s);
            txtTenTK.Focus();
            txtMatKhau.UseSystemPasswordChar = true;
            this.KeyPreview = true;
            this.KeyDown -= frmLoginUser_KeyDown;
            this.KeyDown += frmLoginUser_KeyDown;
        }
        private bool validUsername()
        {
            return !txtTenTK.Text.Any(ch => !char.IsLetterOrDigit(ch));
        }
        private void txtTenTK_Leave(object sender, EventArgs e)
        {
            if (!validUsername())
            {
                showError("Tên đăng nhập không hợp lệ!");
                txtTenTK.Focus();
            }
        }
        private void ptbUnHide_Click(object sender, EventArgs e)
        {
            ptbUnHide.Hide();
            txtMatKhau.UseSystemPasswordChar = false;
            ptbHide.Show();
        }

        private void ptbHide_Click(object sender, EventArgs e)
        {
            ptbHide.Hide();
            txtMatKhau.UseSystemPasswordChar = true;
            ptbUnHide.Show();
        }
        private void btnDangNhapUser_Click(object sender, EventArgs e)
        {
            if (txtTenTK.Text.Trim().Length == 0)
            {
                showError("Vui lòng điền tên đăng nhập!");
                txtTenTK.Focus(); 
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                showError("Vui lòng điền mật khẩu!");
                txtMatKhau.Focus(); 
                return;
            }
            try
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                }
                catch
                {
                    showError("Lỗi không kết nối SQL được!!!!");

                }


                string query = "select * from DANGNHAP where TENDN = '" + txtTenTK.Text + "'";

                SqlDataReader reader = new SqlCommand(query, connection).ExecuteReader();

                if (!reader.HasRows)
                {
                    showError("Tài khoản không tồn tại!");
                    txtTenTK.Focus();
                    return;
                }
                while (reader.Read())
                {

                    if (txtMatKhau.Text != reader["MATKHAU"].ToString())
                    {
                        showError("Sai mật khẩu!");
                        txtMatKhau.Focus();
                        reader.Close();
                        return;
                    }
                }
                reader.Close();

                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
            catch
            {
                showError("Đăng nhập không thành công!");
                return;
            }
            this.Hide();
            new frmHomePageUser(txtTenTK.Text).ShowDialog();
            this.Show();
            txtTenTK.Focus();
            txtTenTK.Clear();
            txtMatKhau.Clear();
        }

        private void lblLoginAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLoginAdmin frmAdminAccount = new frmLoginAdmin();
            this.Hide();
            frmAdminAccount.ShowDialog();
            this.Close();
        }
        private void showError(string error)
        {
            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void lblTaoTK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateAccountUser accountUser = new frmCreateAccountUser();
            accountUser.ShowDialog();
        }

        private void frmLoginUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhapUser.PerformClick(); 
                e.Handled = true;
            }
        }

        private void frmLoginUser_Load(object sender, EventArgs e)
        {

        }
    }
}
