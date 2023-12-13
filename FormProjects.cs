using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlynhansu;
using System.Data.SqlClient;

namespace quanlynhansu
{
    public partial class FormProjects : Form
    {
        DataTable tblduan;
        public FormProjects()
        {
            InitializeComponent();
        }
        private void FormProjects_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            AnText();
            btnLuu.Enabled = false;
        }

        // datagrirdview
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaDuAn, TenDuAn, NgayTao FROM tblduan ";
            tblduan = Class.Functions.GetDataToTable(sql);         //lấy dữ liệu từ bảng
            dtgvDuAn.DataSource = tblduan;                         // Nguồn dữ liệu
            dtgvDuAn.Columns[0].HeaderText = "Mã dự án";
            dtgvDuAn.Columns[1].HeaderText = "Tên dự án";
            dtgvDuAn.Columns[2].HeaderText = "Ngày Tạo";

            dtgvDuAn.Columns[0].Width = 150;
            dtgvDuAn.Columns[1].Width = 150;
            dtgvDuAn.Columns[2].Width = 150;

            dtgvDuAn.AllowUserToAddRows = false;                // không cho thêm trực tiếp
            dtgvDuAn.EditMode = DataGridViewEditMode.EditProgrammatically;  //ko cho sửa ttiep

        }

        //sự kiện click data trả lên txbox
        private void dtgvDuAn_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTenDuAn.Focus();
                txbMaDuAn.Focus();
                dtimeNgayTao.Focus();

                return;
            }
            if (tblduan.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txbTenDuAn.Text = dtgvDuAn.CurrentRow.Cells["TenDuAn"].Value.ToString();
            txbMaDuAn.Text = dtgvDuAn.CurrentRow.Cells["MaDuAn"].Value.ToString();
            dtimeNgayTao.Text = dtgvDuAn.CurrentRow.Cells["NgayTao"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;

            HienText();
            ResetValue();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            AnText();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }


        // Xóa trắng
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            ResetValue();
        }
        public void ResetValue()
        {
            txbMaDuAn.Text = "";
            txbTenDuAn.Text = "";
            dtimeNgayTao.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txbMaDuAn.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã dự án", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbMaDuAn.Focus();
                return;
            }
            if (txbTenDuAn.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên dự án", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbTenDuAn.Focus();
                return;
            }
            if (dtimeNgayTao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtimeNgayTao.Focus();
                return;
            }
            sql = "SELECT MaDuAN FROM tblduan WHERE MaDuAn=N'" + txbMaDuAn.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã dự án này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbMaDuAn.Focus();
                txbMaDuAn.Text = "";
                return;
            }

            sql = "INSERT INTO tblduan " +
                  "VALUES" +
                  "(N'" + txbMaDuAn.Text + "',N'" + txbTenDuAn.Text + "',N'" + dtimeNgayTao.Text + "')";



            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = false;
            txbMaDuAn.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblduan.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txbMaDuAn.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txbTenDuAn.Text.Trim().Length == 0) //nếu chưa nhập tên nhân sự
            {
                MessageBox.Show("Bạn chưa nhập tên dự án", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            sql = "UPDATE tblduan SET  TenDuAn=N'" + txbTenDuAn.Text.Trim().ToString() +
                    "',MaDuAn='" + txbMaDuAn.Text.Trim().ToString() +
                    "' WHERE MaDuAn=N'" + txbMaDuAn.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnHuy.Enabled = true;
            txbMaDuAn.Enabled = false;
        }
    }
}
