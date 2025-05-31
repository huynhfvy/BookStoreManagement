namespace QuanLyNhaSach.Admin
{
    partial class frmDetailedInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailedInvoice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbThanhToan = new System.Windows.Forms.PictureBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.gbThemSach = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.dgvAddBook = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namebook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvHoadon = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbOrderDetail = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDonHang = new System.Windows.Forms.Label();
            this.txtSumCost = new System.Windows.Forms.TextBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.txtCodeOrder = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbThemSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).BeginInit();
            this.gbOrderDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.pbThanhToan);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.gbThemSach);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.dgvHoadon);
            this.panel1.Controls.Add(this.gbOrderDetail);
            this.panel1.Location = new System.Drawing.Point(-4, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1404, 723);
            this.panel1.TabIndex = 0;
            // 
            // pbThanhToan
            // 
            this.pbThanhToan.BackColor = System.Drawing.Color.Bisque;
            this.pbThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("pbThanhToan.Image")));
            this.pbThanhToan.Location = new System.Drawing.Point(957, 668);
            this.pbThanhToan.Name = "pbThanhToan";
            this.pbThanhToan.Size = new System.Drawing.Size(30, 31);
            this.pbThanhToan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbThanhToan.TabIndex = 11;
            this.pbThanhToan.TabStop = false;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Bisque;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPay.Location = new System.Drawing.Point(943, 654);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(230, 57);
            this.btnPay.TabIndex = 13;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Bisque;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1214, 664);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyNhaSach.Properties.Resources.bookshop;
            this.pictureBox1.Location = new System.Drawing.Point(65, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Bisque;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.Location = new System.Drawing.Point(1199, 654);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(171, 57);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // gbThemSach
            // 
            this.gbThemSach.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbThemSach.Controls.Add(this.label7);
            this.gbThemSach.Controls.Add(this.btnAddBook);
            this.gbThemSach.Controls.Add(this.dgvAddBook);
            this.gbThemSach.Location = new System.Drawing.Point(329, 252);
            this.gbThemSach.Name = "gbThemSach";
            this.gbThemSach.Size = new System.Drawing.Size(1061, 396);
            this.gbThemSach.TabIndex = 6;
            this.gbThemSach.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(21, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Thêm sách";
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.Location = new System.Drawing.Point(895, 342);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(146, 45);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Thêm";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // dgvAddBook
            // 
            this.dgvAddBook.AllowDrop = true;
            this.dgvAddBook.AllowUserToAddRows = false;
            this.dgvAddBook.AllowUserToDeleteRows = false;
            this.dgvAddBook.AllowUserToOrderColumns = true;
            this.dgvAddBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAddBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvAddBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Namebook,
            this.SL,
            this.Gia});
            this.dgvAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAddBook.Location = new System.Drawing.Point(13, 41);
            this.dgvAddBook.Name = "dgvAddBook";
            this.dgvAddBook.RowHeadersWidth = 62;
            this.dgvAddBook.RowTemplate.Height = 33;
            this.dgvAddBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddBook.Size = new System.Drawing.Size(1042, 295);
            this.dgvAddBook.TabIndex = 0;
            // 
            // Code
            // 
            this.Code.HeaderText = "Mã sách";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.Width = 113;
            // 
            // Namebook
            // 
            this.Namebook.HeaderText = "Tên sách";
            this.Namebook.MinimumWidth = 6;
            this.Namebook.Name = "Namebook";
            this.Namebook.Width = 114;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.Width = 121;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá thành";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 123;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(1236, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 47);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvHoadon
            // 
            this.dgvHoadon.AllowUserToAddRows = false;
            this.dgvHoadon.AllowUserToDeleteRows = false;
            this.dgvHoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHoadon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.MaSach,
            this.BookName,
            this.Count,
            this.Dongia,
            this.Thanhtien,
            this.Chon});
            this.dgvHoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvHoadon.Location = new System.Drawing.Point(342, 19);
            this.dgvHoadon.Name = "dgvHoadon";
            this.dgvHoadon.RowHeadersWidth = 62;
            this.dgvHoadon.RowTemplate.Height = 33;
            this.dgvHoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoadon.Size = new System.Drawing.Size(1042, 173);
            this.dgvHoadon.TabIndex = 4;
            // 
            // No
            // 
            this.No.Frozen = true;
            this.No.HeaderText = "STT";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Width = 76;
            // 
            // MaSach
            // 
            this.MaSach.Frozen = true;
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 8;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 113;
            // 
            // BookName
            // 
            this.BookName.Frozen = true;
            this.BookName.HeaderText = "Tên sách";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.Width = 114;
            // 
            // Count
            // 
            this.Count.HeaderText = "Số lượng";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.Width = 121;
            // 
            // Dongia
            // 
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.MinimumWidth = 6;
            this.Dongia.Name = "Dongia";
            this.Dongia.Width = 111;
            // 
            // Thanhtien
            // 
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.MinimumWidth = 6;
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.Width = 130;
            // 
            // Chon
            // 
            this.Chon.HeaderText = "Chọn";
            this.Chon.MinimumWidth = 6;
            this.Chon.Name = "Chon";
            this.Chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Chon.Width = 90;
            // 
            // gbOrderDetail
            // 
            this.gbOrderDetail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbOrderDetail.Controls.Add(this.label6);
            this.gbOrderDetail.Controls.Add(this.label5);
            this.gbOrderDetail.Controls.Add(this.label4);
            this.gbOrderDetail.Controls.Add(this.label3);
            this.gbOrderDetail.Controls.Add(this.label2);
            this.gbOrderDetail.Controls.Add(this.lblDonHang);
            this.gbOrderDetail.Controls.Add(this.txtSumCost);
            this.gbOrderDetail.Controls.Add(this.datetime);
            this.gbOrderDetail.Controls.Add(this.txtPaymentMethod);
            this.gbOrderDetail.Controls.Add(this.txtNameCustomer);
            this.gbOrderDetail.Controls.Add(this.txtCodeOrder);
            this.gbOrderDetail.Location = new System.Drawing.Point(16, 209);
            this.gbOrderDetail.Name = "gbOrderDetail";
            this.gbOrderDetail.Size = new System.Drawing.Size(307, 490);
            this.gbOrderDetail.TabIndex = 0;
            this.gbOrderDetail.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tổng tiền thanh toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hình thức thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đơn hàng";
            // 
            // lblDonHang
            // 
            this.lblDonHang.AutoSize = true;
            this.lblDonHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDonHang.Location = new System.Drawing.Point(6, 0);
            this.lblDonHang.Name = "lblDonHang";
            this.lblDonHang.Size = new System.Drawing.Size(111, 26);
            this.lblDonHang.TabIndex = 4;
            this.lblDonHang.Text = "Đơn hàng";
            // 
            // txtSumCost
            // 
            this.txtSumCost.Location = new System.Drawing.Point(25, 419);
            this.txtSumCost.Multiline = true;
            this.txtSumCost.Name = "txtSumCost";
            this.txtSumCost.ReadOnly = true;
            this.txtSumCost.Size = new System.Drawing.Size(246, 42);
            this.txtSumCost.TabIndex = 1;
            // 
            // datetime
            // 
            this.datetime.Enabled = false;
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime.Location = new System.Drawing.Point(25, 331);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(246, 31);
            this.datetime.TabIndex = 3;
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Location = new System.Drawing.Point(25, 243);
            this.txtPaymentMethod.Multiline = true;
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.ReadOnly = true;
            this.txtPaymentMethod.Size = new System.Drawing.Size(246, 42);
            this.txtPaymentMethod.TabIndex = 2;
            this.txtPaymentMethod.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(25, 150);
            this.txtNameCustomer.Multiline = true;
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.ReadOnly = true;
            this.txtNameCustomer.Size = new System.Drawing.Size(246, 42);
            this.txtNameCustomer.TabIndex = 1;
            // 
            // txtCodeOrder
            // 
            this.txtCodeOrder.Location = new System.Drawing.Point(25, 69);
            this.txtCodeOrder.Multiline = true;
            this.txtCodeOrder.Name = "txtCodeOrder";
            this.txtCodeOrder.ReadOnly = true;
            this.txtCodeOrder.Size = new System.Drawing.Size(246, 42);
            this.txtCodeOrder.TabIndex = 0;
            // 
            // frmDetailedInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 712);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetailedInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn chi tiết";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDetailedInvoice_FormClosing);
            this.Load += new System.EventHandler(this.frmDetailedInvoice_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbThemSach.ResumeLayout(false);
            this.gbThemSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).EndInit();
            this.gbOrderDetail.ResumeLayout(false);
            this.gbOrderDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnQuit;
        private GroupBox gbThemSach;
        private Button btnAddBook;
        private DataGridView dgvAddBook;
        private Button btnDelete;
        private DataGridView dgvHoadon;
        private GroupBox gbOrderDetail;
        private Label lblDonHang;
        private TextBox txtSumCost;
        private DateTimePicker datetime;
        private TextBox txtPaymentMethod;
        private TextBox txtNameCustomer;
        private TextBox txtCodeOrder;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label7;
        private PictureBox pictureBox4;
        private PictureBox pbThanhToan;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Namebook;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewCheckBoxColumn select;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn Dongia;
        private DataGridViewTextBoxColumn Thanhtien;
        private DataGridViewCheckBoxColumn Chon;
        private Button btnPay;
    }
}