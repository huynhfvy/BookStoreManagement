using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System;

namespace QuanLyNhaSach.User
{
    public partial class frmReceipt : Form
    {
        string UserName;
        DataTable dt_Books;
        SqlConnection connection;
        string TotalPayment;
        public frmReceipt(string username, DataTable dt_books, string totalpayment)
        {
            InitializeComponent();
            string s = @"Data Source=" + Program.server_name + ";Initial Catalog = QuanLyNhaSach; Integrated Security = True";
            connection = new SqlConnection(s);
            UserName = username;
            dt_Books = new DataTable();
            dt_Books = dt_books;
            TotalPayment = totalpayment;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            userInformation_Load();
            dgvBook_Load();
            txtTotalPayment.Text = TotalPayment;
        }
        private void userInformation_Load()
        {
            try
            {
                datetime.Format = DateTimePickerFormat.Custom;
                datetime.CustomFormat = "dd'/'MM'/'yyyy";
                datetime.Text = DateTime.Now.ToString();
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string user_select_query = "select TENKH, SDT from DANGNHAP, KHACHHANG"
                    + " where DANGNHAP.MAKH = KHACHHANG.MAKH and DANGNHAP.TENDN = @username";
                SqlCommand command = new SqlCommand(user_select_query, connection);
                command.Parameters.AddWithValue("@username", UserName);
                command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                txtUserName.Text = table.Rows[0]["TENKH"].ToString();
                txtNumberPhone.Text = table.Rows[0]["SDT"].ToString();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Tải thông tin khách hàng thất bại!");
                return;
            }
        }
        private void dgvBook_Load()
        {
            dgvBook.DataSource = null;
            dgvBook.AllowUserToAddRows = false;
            dgvBook.DataSource = dt_Books;
            dgvBook.Columns[0].Visible = false;
            dgvBook.Columns[1].HeaderText = "Tên sách";
            dgvBook.Columns[2].HeaderText = "Tác giả";
            dgvBook.Columns[3].HeaderText = "Đơn giá";
            dgvBook.Columns[4].HeaderText = "Số lượng";
            dgvBook.Columns[5].HeaderText = "Thành tiền";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (int.Parse(TotalPayment) == 0)
            {
                MessageBox.Show("Giỏ hàng đang rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (rbtnChuyenTien.Checked == false && rbtnTienMat.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn hình thức thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult res = MessageBox.Show("Số tiền bạn phải thanh toán là: " + TotalPayment, "Thanh toán.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    string thanhtoan = "";
                    if (rbtnChuyenTien.Checked == true) thanhtoan = rbtnChuyenTien.Text;
                    else if (rbtnTienMat.Checked == true) thanhtoan = rbtnTienMat.Text;
                    // retrieve the customer ID(MAKH) from the database based on the provided username and phone number
                    string str = "select  MAKH\r\nfrom KHACHHANG\r\nwhere TENKH  = @makh and SDT = @sdt ";
                    SqlCommand cmd = new SqlCommand(str, connection);
                    cmd.Parameters.AddWithValue("@makh", txtUserName.Text.Trim());
                    cmd.Parameters.AddWithValue("@sdt", txtNumberPhone.Text.Trim());
                    SqlDataReader reader = cmd.ExecuteReader();
                    int Makh = -1;
                    while (reader.Read())
                    {
                        Makh = reader.GetInt32(0);
                    }
                    reader.Close();
                    // insert a new invoice (HoaDon) record into the database
                    str = "insert into HoaDon(MAKH, HINHTHUCTT, NGAYHD, TongTien, KenhMua) values (@makh, @tt, @ngayhd, @tongtien, @kenhmua)";
                    cmd = new SqlCommand(str, connection);
                    cmd.Parameters.AddWithValue("@makh", Makh);
                    cmd.Parameters.AddWithValue("@tt", thanhtoan);
                    cmd.Parameters.AddWithValue("@ngayhd", datetime.Value.ToString("yyyy'-'MM'-'dd"));
                    cmd.Parameters.AddWithValue("@tongtien", double.Parse(txtTotalPayment.Text));
                    cmd.Parameters.AddWithValue("@kenhmua", "Online");
                    cmd.ExecuteNonQuery();
                    // retrieve the invoice ID (MAHD) after inserting the invoice record
                    str = "select MAHD\r\nfrom HoaDon \r\nwhere MAKH = @makh  and HinhThucTT = @tt and NgayHD = @ngayhd and TongTien = @ttien";
                    cmd = new SqlCommand(str, connection);
                    cmd.Parameters.AddWithValue("@makh", Makh);
                    cmd.Parameters.AddWithValue("@tt", thanhtoan);
                    cmd.Parameters.AddWithValue("@ngayhd", datetime.Value.ToString("yyyy'-'MM'-'dd"));
                    cmd.Parameters.AddWithValue("@ttien", txtTotalPayment.Text);
                    reader = cmd.ExecuteReader();
                    int Mahd = -1;
                    while (reader.Read())
                    {
                        Mahd = reader.GetInt32(0);
                    }
                    reader.Close();

                    List<int> IDSach = new List<int>(); // ma sach
                    List<int> CountSach = new List<int>(); // sl sach
                    List<double> MoneySach = new List<double>(); // gia sach

                    // loop through each book in the cart (dgvBook) and get their details (book ID, quantity, price)
                    foreach (DataGridViewRow item in dgvBook.Rows)
                    {
                        string query = "select MASACH \r\nfrom Sach\r\nwhere TENSACH = @ten and GIASACH = @giasach";
                        SqlCommand cmdd = new SqlCommand(query, connection);
                        cmdd.Parameters.AddWithValue("@ten", item.Cells[1].Value);
                        cmdd.Parameters.AddWithValue("@giasach", item.Cells[3].Value);
                        SqlDataReader rd = cmdd.ExecuteReader();
                        while (rd.Read())
                        {
                            IDSach.Add(rd.GetInt32(0)); // ma sach
                            CountSach.Add(int.Parse(item.Cells[4].Value.ToString())); // sl
                            MoneySach.Add(double.Parse(item.Cells[5].Value.ToString())); // gia sach
                        }
                        rd.Close();
                    }
                    // insert each book's details into the ChiTietHoaDon table
                    for (int i = 0; i < IDSach.Count; i++)
                    {
                        str = "insert into ChiTietHoaDon(MAHD, MASACH, SLSACH, TONGGIASACH) values (@mahd, @masach, @sl, @tonggia)";
                        cmd = new SqlCommand(str, connection);
                        cmd.Parameters.AddWithValue("@mahd", Mahd);
                        cmd.Parameters.AddWithValue("@masach", IDSach[i]);
                        cmd.Parameters.AddWithValue("@sl", CountSach[i]);
                        cmd.Parameters.AddWithValue("@tonggia", CountSach[i] * MoneySach[i]);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thanh toán thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (connection.State == ConnectionState.Open) { connection.Close(); }

                    // clear cart
                    frmHomePageUser.AddedBooks.Clear();
                }
            }
        }
    }
}