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
            txbMaPhongBan.Enabled = false;
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

              txbMaPhongBan.Enabled = false;

        }


        //Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnTimKiem.Enabled = false;

            txbMaPhongBan.Enabled = true;
            ResetValue();

        }

        // Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnTimKiem.Enabled = true;

            txbMaPhongBan.Enabled = false;
            ResetValue() ;
            LoadDataGridView();
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


        // lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txbTenPhongBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbTenPhongBan.Focus();
                return;
            }
            if (txbMaPhongBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbMaPhongBan.Focus();
                return;
            }
            if (dtimeNgayTao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtimeNgayTao.Focus();
                return;
            }
            sql = "SELECT MaPhongBan FROM tblphongban WHERE MaPhongBan=N'" + txbMaPhongBan.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã phòng ban này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbMaPhongBan.Focus();
                txbMaPhongBan.Text = "";
                return;
            }

            sql = "INSERT INTO tblphongban " +
                  "VALUES" +
                  "(N'" + txbMaPhongBan.Text + "',N'" + txbTenPhongBan.Text + "',N'" + dtimeNgayTao.Text + "')";



            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txbMaPhongBan.Enabled = false;
        }


        // sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblphongban.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txbMaPhongBan.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txbTenPhongBan.Text.Trim().Length == 0) //nếu chưa nhập tên nhân sự
            {
                MessageBox.Show("Bạn chưa nhập tên dự án", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sql = "UPDATE tblphongban SET  TenPhongBan=N'" + txbTenPhongBan.Text.Trim().ToString() +
                    "',MaPhongBan='" + txbMaPhongBan.Text.Trim().ToString() +
                    "' WHERE MaPhongBan=N'" + txbMaPhongBan.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnHuy.Enabled = true;
            txbMaPhongBan.Enabled = false;
        }


        // Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblphongban.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txbMaPhongBan.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblphongban WHERE MaPhongBan=N'" + txbMaPhongBan.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        // Tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txbMaPhongBan.Text == "") && (txbTenPhongBan.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from tblphongban WHERE 1=1";
            if (txbMaPhongBan.Text != "")
                sql += " AND MaPhongBan LIKE N'%" + txbMaPhongBan.Text + "%'";
            if (txbTenPhongBan.Text != "")
                sql += " AND TenPhongBan LIKE N'%" + txbTenPhongBan.Text + "%'";
            tblphongban = Functions.GetDataToTable(sql);
            if (tblphongban.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblphongban.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtgvPhongBan.DataSource = tblphongban;
            ResetValue();
        }

        
    }
}
