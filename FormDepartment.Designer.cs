namespace quanlynhansu
{
    partial class FormDepartment
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
            this.dtgvPhongBan = new System.Windows.Forms.DataGridView();
            this.txbMaPhongBan = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txbTenPhongBan = new System.Windows.Forms.TextBox();
            this.dtimeNgayTao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPhongBan
            // 
            this.dtgvPhongBan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhongBan.Location = new System.Drawing.Point(34, 184);
            this.dtgvPhongBan.Name = "dtgvPhongBan";
            this.dtgvPhongBan.RowHeadersWidth = 51;
            this.dtgvPhongBan.RowTemplate.Height = 24;
            this.dtgvPhongBan.Size = new System.Drawing.Size(587, 264);
            this.dtgvPhongBan.TabIndex = 23;
            this.dtgvPhongBan.Click += new System.EventHandler(this.dtgvPhongBan_Click);
            // 
            // txbMaPhongBan
            // 
            this.txbMaPhongBan.Location = new System.Drawing.Point(335, 37);
            this.txbMaPhongBan.Multiline = true;
            this.txbMaPhongBan.Name = "txbMaPhongBan";
            this.txbMaPhongBan.Size = new System.Drawing.Size(384, 28);
            this.txbMaPhongBan.TabIndex = 22;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(710, 409);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 39);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(51, 135);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 43);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(51, 86);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 43);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(51, 37);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 43);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txbTenPhongBan
            // 
            this.txbTenPhongBan.Location = new System.Drawing.Point(335, 92);
            this.txbTenPhongBan.Multiline = true;
            this.txbTenPhongBan.Name = "txbTenPhongBan";
            this.txbTenPhongBan.Size = new System.Drawing.Size(384, 28);
            this.txbTenPhongBan.TabIndex = 24;
            // 
            // dtimeNgayTao
            // 
            this.dtimeNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeNgayTao.Location = new System.Drawing.Point(335, 147);
            this.dtimeNgayTao.Name = "dtimeNgayTao";
            this.dtimeNgayTao.Size = new System.Drawing.Size(200, 27);
            this.dtimeNgayTao.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã phòng ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tên phòng ban";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ngày tạo";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(644, 239);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(130, 43);
            this.btnTimKiem.TabIndex = 29;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Location = new System.Drawing.Point(644, 184);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(130, 40);
            this.btnXoaTrang.TabIndex = 30;
            this.btnXoaTrang.Text = "Xóa trắng hết";
            this.btnXoaTrang.UseVisualStyleBackColor = true;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(669, 324);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 45);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(627, 409);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 39);
            this.btnHuy.TabIndex = 32;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 467);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtimeNgayTao);
            this.Controls.Add(this.txbTenPhongBan);
            this.Controls.Add(this.dtgvPhongBan);
            this.Controls.Add(this.txbMaPhongBan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDepartment";
            this.Load += new System.EventHandler(this.FormDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPhongBan;
        private System.Windows.Forms.TextBox txbMaPhongBan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txbTenPhongBan;
        private System.Windows.Forms.DateTimePicker dtimeNgayTao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}