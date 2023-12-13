namespace quanlynhansu
{
    partial class FormProjects
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txbMaDuAn = new System.Windows.Forms.TextBox();
            this.txbTenDuAn = new System.Windows.Forms.TextBox();
            this.dtimeNgayTao = new System.Windows.Forms.DateTimePicker();
            this.dtgvDuAn = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDuAn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dự án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên dự án";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày tạo";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 229);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 46);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(247, 229);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 46);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(133, 229);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 46);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(797, 342);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 38);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txbMaDuAn
            // 
            this.txbMaDuAn.Location = new System.Drawing.Point(133, 33);
            this.txbMaDuAn.Name = "txbMaDuAn";
            this.txbMaDuAn.Size = new System.Drawing.Size(199, 30);
            this.txbMaDuAn.TabIndex = 7;
            // 
            // txbTenDuAn
            // 
            this.txbTenDuAn.Location = new System.Drawing.Point(133, 88);
            this.txbTenDuAn.Name = "txbTenDuAn";
            this.txbTenDuAn.Size = new System.Drawing.Size(199, 30);
            this.txbTenDuAn.TabIndex = 8;
            // 
            // dtimeNgayTao
            // 
            this.dtimeNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeNgayTao.Location = new System.Drawing.Point(133, 143);
            this.dtimeNgayTao.Name = "dtimeNgayTao";
            this.dtimeNgayTao.Size = new System.Drawing.Size(142, 30);
            this.dtimeNgayTao.TabIndex = 9;
            // 
            // dtgvDuAn
            // 
            this.dtgvDuAn.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDuAn.Location = new System.Drawing.Point(338, 33);
            this.dtgvDuAn.Name = "dtgvDuAn";
            this.dtgvDuAn.RowHeadersWidth = 51;
            this.dtgvDuAn.RowTemplate.Height = 24;
            this.dtgvDuAn.Size = new System.Drawing.Size(534, 286);
            this.dtgvDuAn.TabIndex = 10;
            this.dtgvDuAn.Click += new System.EventHandler(this.dtgvDuAn_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(12, 281);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 98);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Location = new System.Drawing.Point(133, 282);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(75, 97);
            this.btnXoaTrang.TabIndex = 12;
            this.btnXoaTrang.Text = "Xóa trắng";
            this.btnXoaTrang.UseVisualStyleBackColor = true;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(567, 342);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 37);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(247, 342);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 37);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 392);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dtgvDuAn);
            this.Controls.Add(this.dtimeNgayTao);
            this.Controls.Add(this.txbTenDuAn);
            this.Controls.Add(this.txbMaDuAn);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProjects";
            this.Load += new System.EventHandler(this.FormProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDuAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txbMaDuAn;
        private System.Windows.Forms.TextBox txbTenDuAn;
        private System.Windows.Forms.DateTimePicker dtimeNgayTao;
        private System.Windows.Forms.DataGridView dtgvDuAn;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}