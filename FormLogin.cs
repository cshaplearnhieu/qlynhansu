using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using quanlynhansu.Class;

namespace quanlynhansu
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Thực hiện các công việc khởi tạo khi FormLogin được load
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txbTaiKhoan.Text;
            string password = txbMatKhau.Text;

            try
            {
                // Mở kết nối bằng cách sử dụng class Functions
                Functions.Connect();

                string query = "SELECT * FROM tbltaikhoan WHERE TenTaiKhoan = @Username AND MatKhau = @Password";
                SqlDataAdapter sda = new SqlDataAdapter(query, Functions.Con);
                sda.SelectCommand.Parameters.AddWithValue("@Username", username);
                sda.SelectCommand.Parameters.AddWithValue("@Password", password);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    // Đăng nhập thành công
                    FormMain fm = new FormMain();
                    fm.Logout += Fm_Logout;
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 
        private void Fm_Logout(object sender, EventArgs e)
        {
            FormMain fm = (FormMain)sender;
            fm.isExit = false;
            fm.Close();  // Đóng FormMain khi đăng xuất
            this.Show();  // Hiển thị lại FormLogin khi đăng xuất
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn thoát chương trình ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Functions.Disconnect();
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
        // show mật khẩu
        private void cboxHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxHienThi.Checked)
                txbMatKhau.UseSystemPasswordChar = false;
            if(!cboxHienThi.Checked)
                txbMatKhau.UseSystemPasswordChar = true;
        }

     
    }
}
