using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QuanLyKhoHang
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private void xulyDangNhap()
        {
            SqlConnection conn = new SqlConnection(globalParameter.connectionString);
            string sqlSelect = "Select * from TaiKhoan where tendangnhap='" + txtUsername.Text + "'and matkhau='" + txtPassword.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                if (reader.Read() == true)
                {
                    this.Hide();
                    frmMain main = new frmMain();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Username hoặc Password không đúng. Vui lòng đăng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            xulyDangNhap();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //this.Close();
            //frmMain main = new frmMain();
            //main.Close();     
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                errorPro_Login.SetError(txtUsername, "Username không được rỗng!");

            }
            else if (txtUsername.Text.Length < 4)
            {
                errorPro_Login.SetError(txtUsername, "Username quá ngắn, tối thiểu 5 kí tự!");
            }
            else if (!Regex.IsMatch(txtUsername.Text, "[a-zA-Z0-9]+$"))
            {
                errorPro_Login.SetError(txtUsername, "Username chứa ký tự không hợp lệ!");
            }
            else
            {
                errorPro_Login.Clear();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                errorPro_Login.SetError(txtPassword, "Password không được trống!");
            }
            
            else
            {
                errorPro_Login.Clear();
            }
        }

    
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)

                xulyDangNhap();
        }
    }
}
