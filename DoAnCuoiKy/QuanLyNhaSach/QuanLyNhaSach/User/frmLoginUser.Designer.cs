namespace QuanLyNhaSach.User
{
    partial class frmLoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDangNhapUser = new System.Windows.Forms.Label();
            this.lblTenTKUser = new System.Windows.Forms.Label();
            this.lblMatKhauUser = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhapUser = new System.Windows.Forms.Button();
            this.lblTaoTK = new System.Windows.Forms.LinkLabel();
            this.lblLoginAdmin = new System.Windows.Forms.LinkLabel();
            this.ptbHide = new System.Windows.Forms.PictureBox();
            this.ptbUnHide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUnHide)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QuanLyNhaSach.Properties.Resources.store;
            this.pictureBox1.Location = new System.Drawing.Point(49, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 260);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDangNhapUser
            // 
            this.lblDangNhapUser.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lblDangNhapUser.AutoSize = true;
            this.lblDangNhapUser.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDangNhapUser.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDangNhapUser.Location = new System.Drawing.Point(531, 46);
            this.lblDangNhapUser.Name = "lblDangNhapUser";
            this.lblDangNhapUser.Size = new System.Drawing.Size(207, 36);
            this.lblDangNhapUser.TabIndex = 1;
            this.lblDangNhapUser.Text = "ĐĂNG NHẬP";
            // 
            // lblTenTKUser
            // 
            this.lblTenTKUser.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lblTenTKUser.AutoSize = true;
            this.lblTenTKUser.Location = new System.Drawing.Point(373, 116);
            this.lblTenTKUser.Name = "lblTenTKUser";
            this.lblTenTKUser.Size = new System.Drawing.Size(116, 25);
            this.lblTenTKUser.TabIndex = 2;
            this.lblTenTKUser.Text = "Tên tài khoản";
            // 
            // lblMatKhauUser
            // 
            this.lblMatKhauUser.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lblMatKhauUser.AutoSize = true;
            this.lblMatKhauUser.Location = new System.Drawing.Point(373, 172);
            this.lblMatKhauUser.Name = "lblMatKhauUser";
            this.lblMatKhauUser.Size = new System.Drawing.Size(86, 25);
            this.lblMatKhauUser.TabIndex = 3;
            this.lblMatKhauUser.Text = "Mật khẩu";
            // 
            // txtTenTK
            // 
            this.txtTenTK.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.txtTenTK.Location = new System.Drawing.Point(513, 110);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(248, 31);
            this.txtTenTK.TabIndex = 4;
            this.txtTenTK.Leave += new System.EventHandler(this.txtTenTK_Leave);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.txtMatKhau.Location = new System.Drawing.Point(513, 166);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(248, 31);
            this.txtMatKhau.TabIndex = 5;
            // 
            // btnDangNhapUser
            // 
            this.btnDangNhapUser.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnDangNhapUser.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDangNhapUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhapUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDangNhapUser.ForeColor = System.Drawing.Color.White;
            this.btnDangNhapUser.Location = new System.Drawing.Point(571, 217);
            this.btnDangNhapUser.Name = "btnDangNhapUser";
            this.btnDangNhapUser.Size = new System.Drawing.Size(145, 53);
            this.btnDangNhapUser.TabIndex = 6;
            this.btnDangNhapUser.Text = "Đăng nhập";
            this.btnDangNhapUser.UseVisualStyleBackColor = false;
            this.btnDangNhapUser.Click += new System.EventHandler(this.btnDangNhapUser_Click);
            // 
            // lblTaoTK
            // 
            this.lblTaoTK.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lblTaoTK.AutoSize = true;
            this.lblTaoTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTaoTK.Location = new System.Drawing.Point(466, 295);
            this.lblTaoTK.Name = "lblTaoTK";
            this.lblTaoTK.Size = new System.Drawing.Size(337, 25);
            this.lblTaoTK.TabIndex = 8;
            this.lblTaoTK.TabStop = true;
            this.lblTaoTK.Text = "Nhấp vào đây nếu bạn chưa có tài khoản";
            this.lblTaoTK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTaoTK_LinkClicked);
            // 
            // lblLoginAdmin
            // 
            this.lblLoginAdmin.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lblLoginAdmin.AutoSize = true;
            this.lblLoginAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoginAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginAdmin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblLoginAdmin.Location = new System.Drawing.Point(513, 336);
            this.lblLoginAdmin.Name = "lblLoginAdmin";
            this.lblLoginAdmin.Size = new System.Drawing.Size(255, 25);
            this.lblLoginAdmin.TabIndex = 9;
            this.lblLoginAdmin.TabStop = true;
            this.lblLoginAdmin.Text = "Đăng nhập với tư cách Admin";
            this.lblLoginAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLoginAdmin_LinkClicked);
            // 
            // ptbHide
            // 
            this.ptbHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbHide.Image = global::QuanLyNhaSach.Properties.Resources.Hide;
            this.ptbHide.Location = new System.Drawing.Point(776, 166);
            this.ptbHide.Name = "ptbHide";
            this.ptbHide.Size = new System.Drawing.Size(37, 36);
            this.ptbHide.TabIndex = 10;
            this.ptbHide.TabStop = false;
            this.ptbHide.Click += new System.EventHandler(this.ptbHide_Click);
            // 
            // ptbUnHide
            // 
            this.ptbUnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbUnHide.Image = global::QuanLyNhaSach.Properties.Resources.show;
            this.ptbUnHide.Location = new System.Drawing.Point(776, 166);
            this.ptbUnHide.Name = "ptbUnHide";
            this.ptbUnHide.Size = new System.Drawing.Size(37, 36);
            this.ptbUnHide.TabIndex = 11;
            this.ptbUnHide.TabStop = false;
            this.ptbUnHide.Click += new System.EventHandler(this.ptbUnHide_Click);
            // 
            // frmLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(837, 398);
            this.Controls.Add(this.ptbUnHide);
            this.Controls.Add(this.ptbHide);
            this.Controls.Add(this.lblLoginAdmin);
            this.Controls.Add(this.lblTaoTK);
            this.Controls.Add(this.btnDangNhapUser);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.lblMatKhauUser);
            this.Controls.Add(this.lblTenTKUser);
            this.Controls.Add(this.lblDangNhapUser);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoginUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmLoginUser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLoginUser_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUnHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblDangNhapUser;
        private Label lblTenTKUser;
        private Label lblMatKhauUser;
        private TextBox txtTenTK;
        private TextBox txtMatKhau;
        private Button btnDangNhapUser;
        private LinkLabel lblTaoTK;
        private LinkLabel lblLoginAdmin;
        private PictureBox ptbHide;
        private PictureBox ptbUnHide;
    }
}