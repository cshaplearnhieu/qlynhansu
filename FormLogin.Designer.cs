namespace quanlynhansu
{
    partial class FormLogin
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.txbTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.cboxHienThi = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(301, 213);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 50);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(219, 91);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(231, 27);
            this.txbMatKhau.TabIndex = 19;
            this.txbMatKhau.Text = "123456";
            this.txbMatKhau.UseSystemPasswordChar = true;
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Location = new System.Drawing.Point(219, 39);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Size = new System.Drawing.Size(231, 27);
            this.txbTaiKhoan.TabIndex = 18;
            this.txbTaiKhoan.Text = "DucHieu";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(150, 213);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(116, 50);
            this.btnDangNhap.TabIndex = 17;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // cboxHienThi
            // 
            this.cboxHienThi.AutoSize = true;
            this.cboxHienThi.Location = new System.Drawing.Point(150, 147);
            this.cboxHienThi.Name = "cboxHienThi";
            this.cboxHienThi.Size = new System.Drawing.Size(162, 24);
            this.cboxHienThi.TabIndex = 16;
            this.cboxHienThi.Text = "Hiển thị mật khẩu";
            this.cboxHienThi.UseVisualStyleBackColor = true;
            this.cboxHienThi.CheckedChanged += new System.EventHandler(this.cboxHienThi_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tài khoản";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 302);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTaiKhoan);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.cboxHienThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.TextBox txbTaiKhoan;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.CheckBox cboxHienThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

