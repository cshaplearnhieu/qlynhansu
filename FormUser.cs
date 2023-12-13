using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlynhansu.Class;
using System.Data.SqlClient;

namespace quanlynhansu
{
    public partial class FormUser : Form
    {
        DataTable tbltaikhoan;
        public FormUser()
        {
            InitializeComponent();
        }
         public void AnText()
        {
            txbUserName.Enabled = false;
            txbPassWord.Enabled = false;
            cboStaff.Enabled = false;
        }
        public void HienText()
        {
            txbUserName.Enabled = true;
            txbPassWord.Enabled = true;
            cboStaff.Enabled = true;
        }
        private void FormUser_Load(object sender, EventArgs e)
        {
            AnText();
            LoadDataGridView();
            btnLuu.Enabled = false;
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT TenTaiKhoan, MatKhau FROM tbltaikhoan";
            tbltaikhoan = Class.Functions.GetDataToTable(sql);                  //Đọc dữ liệu từ bảng
            dtgvUser.DataSource = tbltaikhoan;                               //Nguồn dữ liệu            
            dtgvUser.Columns[0].HeaderText = "Tên Tài Khoản";
            dtgvUser.Columns[1].HeaderText = "Mật Khẩu";
            dtgvUser.Columns[0].Width = 150;
            dtgvUser.Columns[1].Width = 150;
            dtgvUser.AllowUserToAddRows = false;                     //Không cho người dùng thêm dữ liệu trực tiếp

            dtgvUser.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        } 

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //sự kiện click data trả lên txbox
        private void dtgvUser_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbUserName.Focus();
                txbPassWord.Focus();
                

                return;
            }
            if (tbltaikhoan.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txbUserName.Text = dtgvUser.CurrentRow.Cells["TenTaiKhoan"].Value.ToString();
            txbPassWord.Text = dtgvUser.CurrentRow.Cells["MatKhau"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HienText();
            btnAdd.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;

            ResetValue();
        }

        // xóa trắng
        public void ResetValue()
        {
            txbUserName.Text = "";
            txbPassWord.Text = "";
            cboStaff.Text = "";
          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        // hủy

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnAdd.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
    }
}
