using System;
using System.Windows.Forms;
using quanlynhansu.Class;
using System.Data.SqlClient;
using System.Data;

namespace quanlynhansu
{
    public partial class FormMain : Form
    {
        DataTable tblnhansu;
        public bool isExit = true;
        public event EventHandler Logout;

        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            Functions.Connect();  // kết nối db
            LoadDataGridView();
            txbMaNhanSu.Enabled = false;
            btnLuu.Enabled = false;
        }

        //DataGridView
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaNhanSu, TenNhanSu, NgaySinh, MucLuong, MaPhongBan, MaDuAn, NgayTao FROM tblnhansu";
            tblnhansu = Class.Functions.GetDataToTable(sql);                  //Đọc dữ liệu từ bảng
            dtgvNhanSu.DataSource = tblnhansu;                               //Nguồn dữ liệu            
            dtgvNhanSu.Columns[0].HeaderText = "Mã nhân sự";
            dtgvNhanSu.Columns[1].HeaderText = "Tên nhân sự";
            dtgvNhanSu.Columns[2].HeaderText = "Ngày Sinh";
            dtgvNhanSu.Columns[3].HeaderText = "Mức lương";
            dtgvNhanSu.Columns[4].HeaderText = "Mã phòng ban";
            dtgvNhanSu.Columns[5].HeaderText = "Mã dự án";
            dtgvNhanSu.Columns[6].HeaderText = "Ngày tạo";
            dtgvNhanSu.Columns[0].Width = 150;
            dtgvNhanSu.Columns[1].Width = 150;
            dtgvNhanSu.Columns[2].Width = 150;
            dtgvNhanSu.Columns[3].Width = 150;
            dtgvNhanSu.Columns[4].Width = 150;
            dtgvNhanSu.Columns[5].Width = 150;
            dtgvNhanSu.Columns[6].Width = 150;
            dtgvNhanSu.AllowUserToAddRows = false;                     //Không cho người dùng thêm dữ liệu trực tiếp

            dtgvNhanSu.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
           
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Functions.Disconnect();
                Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnLogout();
        }

        private void OnLogout()
        {
            Logout?.Invoke(this, EventArgs.Empty);
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser frU = new FormUser();
            frU.ShowDialog();
        }

        private void phònBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepartment frD = new FormDepartment();
            frD.ShowDialog();
        }

        private void dựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProjects frP = new FormProjects();
            frP.ShowDialog();
        }


        // sự kiện click data trả lên txbox
        private void dtgvNhanSu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbHoTen.Focus();
                txbLuong.Focus();
                txbMaDuAn.Focus();
                txbMaNhanSu.Focus();
                txbMaPhongBan.Focus();
                dtimeNgayTao.Focus();
                dtimeNgaySinh.Focus();

                return;
            }
            if (tblnhansu.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txbMaNhanSu.Text = dtgvNhanSu.CurrentRow.Cells["MaNhanSu"].Value.ToString();
            txbHoTen.Text = dtgvNhanSu.CurrentRow.Cells["TenNhanSu"].Value.ToString();
            dtimeNgaySinh.Text = dtgvNhanSu.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txbLuong.Text = dtgvNhanSu.CurrentRow.Cells["MucLuong"].Value.ToString();
            txbMaPhongBan.Text = dtgvNhanSu.CurrentRow.Cells["MaPhongBan"].Value.ToString();
            txbMaDuAn.Text = dtgvNhanSu.CurrentRow.Cells["MaDuAn"].Value.ToString();
            dtimeNgayTao.Text = dtgvNhanSu.CurrentRow.Cells["NgayTao"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnClear.Enabled = true;

            txbMaNhanSu.Enabled = false;

        }


        // Thêm 
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnClear.Enabled = true;
            btnHuy.Enabled = true;

            txbMaNhanSu.Enabled = true;
            ResetValue();

        }

        public void ResetValue()
        {
            txbHoTen.Text = "";
            txbLuong.Text = "";
            txbMaDuAn.Text = "";
            txbMaNhanSu.Text = "";
            txbMaPhongBan.Text = "";
            dtimeNgaySinh.Text = "";
            dtimeNgayTao.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetValue();
        }


        // hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnClear.Enabled = true;

            txbMaNhanSu.Enabled = false;
            ResetValue();
            LoadDataGridView();
        }


        // Lưu vào database
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txbMaNhanSu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân sự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbMaNhanSu.Focus();
                return;
            }
            if (txbHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân sự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbHoTen.Focus();
                return;
            }
            if (dtimeNgaySinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtimeNgaySinh.Focus();
                return;
            }
            if (txbLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lương nhân sự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbHoTen.Focus();
                return;
            }
            if (txbMaPhongBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phòng ban nhân sự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbMaPhongBan.Focus();
                return;
            }
            if (txbMaDuAn.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã dự án nhân sự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbHoTen.Focus();
                return;
            }
            if (dtimeNgayTao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtimeNgayTao.Focus();
                return;
            }
            sql = "SELECT MaNhanSu FROM tblnhansu WHERE MaNhanSu=N'" + txbMaNhanSu.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân sự này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbMaNhanSu.Focus();
                txbMaNhanSu.Text = "";
                return;
            }

            sql = "INSERT INTO tblnhansu " +
                  "VALUES" +
                  "(N'" + txbMaNhanSu.Text + "',N'" + txbHoTen.Text + "', N'" + dtimeNgaySinh.Text + "',N'" + txbLuong.Text + "', N'" + txbMaPhongBan.Text + "', N'" + txbMaDuAn.Text + "',N'" + dtimeNgayTao.Text + "')";



            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txbMaNhanSu.Enabled = false;
        }


        //sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblnhansu.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txbMaNhanSu.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txbHoTen.Text.Trim().Length == 0) //nếu chưa nhập tên nhân sự
            {
                MessageBox.Show("Bạn chưa nhập tên nhân sự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txbLuong.Text.Trim().Length == 0) //nếu chưa nhập lương 
            {
                MessageBox.Show("Bạn chưa nhập lương nhân sự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txbMaPhongBan.Text.Trim().Length == 0) //nếu chưa nhập mã phòng ban 
            {
                MessageBox.Show("Bạn chưa nhập mã phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txbMaDuAn.Text.Trim().Length == 0) //nếu chưa nhập mã dự án 
            {
                MessageBox.Show("Bạn chưa nhập mã dự án", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblnhansu SET  TenNhanSu=N'" + txbHoTen.Text.Trim().ToString() +
                    "',NgaySinh= '" + dtimeNgaySinh.Text.Trim().ToString() +
                    "',MucLuong=N'" + txbLuong.Text.Trim().ToString() +
                    "',MaPhongBan='" + txbMaPhongBan.Text.Trim().ToString() +
                    "',MaDuAn='" + txbMaDuAn.Text.Trim().ToString() +
                    "' WHERE MaNhanSu=N'" + txbMaNhanSu.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnHuy.Enabled = true;
            txbMaNhanSu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblnhansu.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txbMaNhanSu.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblnhansu WHERE MaNhanSu=N'" + txbMaNhanSu.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();

            }
        }

        //Tìm Kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txbMaNhanSu.Text == "") && (txbHoTen.Text == "") && (txbMaPhongBan.Text == "") && (txbMaDuAn.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from tblnhansu WHERE 1=1";
            if (txbMaNhanSu.Text != "")
                sql += " AND MaNhanSu LIKE N'%" + txbMaNhanSu.Text + "%'";
            if (txbHoTen.Text != "")
                sql += " AND TenNhanSu LIKE N'%" + txbHoTen.Text + "%'";
            if (txbMaPhongBan.Text != "")
                sql += " AND MaPhongBan LIKE N'%" + txbMaPhongBan.Text + "%'";
            if (txbMaDuAn.Text != "")
                sql += " AND MaDuAn LIKE N'%" + txbMaDuAn.Text + "%'";
            tblnhansu = Functions.GetDataToTable(sql);
            if (tblnhansu.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblnhansu.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtgvNhanSu.DataSource = tblnhansu;
            ResetValue();
        }
    }
}
