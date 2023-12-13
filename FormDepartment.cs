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
    public partial class FormDepartment : Form
    {
        DataTable tblphongban;
        public FormDepartment()
        {
            InitializeComponent();
        }
        private void FormDepartment_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            AnText();
            btnLuu.Enabled = false;
            
        }

        //datagridview

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaPhongban, TenphongBan, Ngaytao FROM tblphongban";
            tblphongban = Class.Functions.GetDataToTable(sql);                  //Đọc dữ liệu từ bảng
            dtgvPhongBan.DataSource = tblphongban;                               //Nguồn dữ liệu            
            dtgvPhongBan.Columns[0].HeaderText = "Mã phòng ban";
            dtgvPhongBan.Columns[1].HeaderText = "Tên phòng ban";
            dtgvPhongBan.Columns[2].HeaderText = "Ngày Tạo";
            dtgvPhongBan.Columns[0].Width = 150;
            dtgvPhongBan.Columns[1].Width = 150;
            dtgvPhongBan.Columns[2].Width = 150;

            dtgvPhongBan.AllowUserToAddRows = false;                     //Không cho người dùng thêm dữ liệu trực tiếp

            dtgvPhongBan.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }


        //sự kiện click data trả lên txbox
        private void dtgvPhongBan_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTenPhongBan.Focus();
                txbMaPhongBan.Focus();
                dtimeNgayTao.Focus();

                return;
            }
            if (tblphongban.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txbTenPhongBan.Text = dtgvPhongBan.CurrentRow.Cells["TenPhongBan"].Value.ToString();
            txbMaPhongBan.Text = dtgvPhongBan.CurrentRow.Cells["MaPhongBan"].Value.ToString();            
            dtimeNgayTao.Text = dtgvPhongBan.CurrentRow.Cells["NgayTao"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            AnText();

        }


        //Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;

            HienText();
            ResetValue();

        }

        // Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

            AnText();
        }

        // xóa trắng
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            ResetValue();
        }
        public void ResetValue()
        {
            txbTenPhongBan.Text = "";
            txbMaPhongBan.Text = "";
            dtimeNgayTao.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
