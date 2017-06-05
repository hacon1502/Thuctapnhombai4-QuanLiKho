using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DTO;
using BLL;

namespace QuanLyKhoHang
{
    public partial class NguoiDung : UserControl
    {
        NguoiDung_BLL ndBLL = new NguoiDung_BLL();
        int flagLuu = 0;
        public NguoiDung()
        {
            InitializeComponent();
            Load_NguoiDung();
        }
        public void Load_NguoiDung()
        {
            List<NguoiDung_DTO> ttnd = new List<NguoiDung_DTO>();
            dgvNguoiDung.DataSource = ndBLL.ThongTinNguoiDung();
          
            Binding_NguoiDung();
            
        }
        private void Binding_NguoiDung()
        {
            txtTenDN.DataBindings.Clear();
            txtTenDN.DataBindings.Add("Text", dgvNguoiDung.DataSource, "TenDangNhap");
            txtMatkhau.DataBindings.Clear();
            txtMatkhau.DataBindings.Add("Text", dgvNguoiDung.DataSource, "MatKhau");
            txtTenND.DataBindings.Clear();
            txtTenND.DataBindings.Add("Text", dgvNguoiDung.DataSource, "TenNguoiDung");
            cboPhanQuyen.DataBindings.Clear();
            cboPhanQuyen.DataBindings.Add("Text", dgvNguoiDung.DataSource, "PhanQuyen");
            
        }
        private void clearData()
        {
            txtTenDN.Text = "";
            txtMatkhau.Text = "";
            txtTenND.Text = "";
            cboPhanQuyen.Text = "User";
        }
        private void DisEnl(bool e)
        {
            btnThemND.Enabled = !e;
            btnXoaND.Enabled = !e;
            btnSuaND.Enabled = !e;          
            txtTenDN.Enabled = e;
            txtMatkhau.Enabled = e;
            txtTenDN.Enabled = e;
            cboPhanQuyen.Enabled = e;          
        }
        private bool kiemtra_rong()
        {
            Boolean kt = false;
            if (txtTenDN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Focus();
                kt = true;
            }
            if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatkhau.Focus();
                kt = true;
            }
            return kt;
        }
        private bool kiemtra_dk()
        {
            Boolean dk = false;
            if (txtTenDN.Text.Length<5)
            {
                MessageBox.Show("Tên đăng nhập quá ngắn, tối thiểu 5 ký tự!.", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Focus();
                dk = true;
            }
            if(txtTenDN.Text=="")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống!.", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!Regex.IsMatch(txtTenDN.Text, "[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Tên đăng nhập chứa ký tự đặc biệt!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dk = true;
            }
            if (txtMatkhau.Text == ""|| txtMatkhau.Text.Length<5)
            {
                MessageBox.Show("Mật khẩu không được bỏ trống, tối thiểu 5 ký tự!.", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dk;
        }
        private void ktThemND()
        {
            try
            {
                NguoiDung_DTO nd = new NguoiDung_DTO();
                nd.TenDangNhap = txtTenDN.Text.Trim();
                nd.MatKhau = txtMatkhau.Text.Trim();
                nd.TenNguoiDung = txtTenND.Text.Trim();
                nd.PhanQuyen = cboPhanQuyen.Text.Trim();
                
                kiemtra_rong();
                if (ndBLL.ThemNguoiDung(nd))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Load_NguoiDung();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ktSuaND()
        {
            try
            {
                NguoiDung_DTO nd = new NguoiDung_DTO();
                nd.TenDangNhap = txtTenDN.Text.Trim();
                nd.MatKhau = txtMatkhau.Text.Trim();
                nd.TenNguoiDung = txtTenND.Text.Trim();
                nd.PhanQuyen = cboPhanQuyen.Text.Trim();
                if (ndBLL.SuaNguoiDung(nd))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Load_NguoiDung();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemND_Click(object sender, EventArgs e)
        {
            clearData();
            DisEnl(true);
            flagLuu = 0;
        }

        private void btnSuaND_Click(object sender, EventArgs e)
        {
            DisEnl(true);          
            txtTenDN.Enabled = false;
            flagLuu = 1;
        }

        private void btnXoaND_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hàng hóa này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (!kiemtra_rong())
                    {
                        string tendn = txtTenDN.Text;
                        ndBLL.XoaNguoiDung(tendn);
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load_NguoiDung();
            DisEnl(false);
        }

        private void btnLuuND_Click(object sender, EventArgs e)
        {
            if (flagLuu == 0)
            {
                ktThemND();
              
            }
            if (flagLuu == 1)
            {
                ktSuaND();
            }
            Load_NguoiDung();
            DisEnl(false);
        }

        private void btnHuyCTPX_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Load_NguoiDung();
                DisEnl(false);
            }
            else
                return;
        }
    }
}
