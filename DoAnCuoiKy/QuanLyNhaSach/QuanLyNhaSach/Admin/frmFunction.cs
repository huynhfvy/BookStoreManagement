using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.Admin
{
    public partial class frmFunction : Form
    {
        public frmFunction()
        {
            InitializeComponent();
            btnTrangChu.BackColor = Color.CadetBlue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmOrderManagement().Show();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmBookManagement().Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCustomerAccount().Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất khỏi ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                this.Close();
            }
        }

        private void frmFunction_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
