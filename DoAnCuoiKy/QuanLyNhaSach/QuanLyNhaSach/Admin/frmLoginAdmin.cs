using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.User;
using QuanLyNhaSach.Admin;

namespace QuanLyNhaSach.Admin
{
    public partial class frmLoginAdmin : Form
    {
        public frmLoginAdmin()
        {
            InitializeComponent();
            txtMK.UseSystemPasswordChar = true;
            this.KeyPreview = true;
            this.KeyDown -= frmLoginAdmin_KeyDown;
            this.KeyDown += frmLoginAdmin_KeyDown;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ptbUnHide.Hide();
            txtMK.UseSystemPasswordChar = false;
            ptbHide.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMK.Text == String.Empty || txtTenDangNhap.Text == String.Empty)
            {
                MessageBox.Show("Không được bỏ trống. Bạn đã không nhập Tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtTenDangNhap.Text.Trim() != "Admin" || txtMK.Text.Trim() != "Admin@123")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai rồi!. Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Hide();
                new frmFunction().Show();
            }
        }

        private void ptbHide_Click(object sender, EventArgs e)
        {
            ptbHide.Hide();
            txtMK.UseSystemPasswordChar = true;
            ptbUnHide.Show();
        }

        private void llblUserLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLoginUser frmLoginUser = new frmLoginUser();
            this.Hide();
            frmLoginUser.ShowDialog();
            this.Close();
        }

        private void frmLoginAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
                e.Handled = true;
            }
        }
    }
}
