using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace QuanLyKhoHang
{
    
    public partial class HangHoa : UserControl
    {
        HangHoa_BLL hhBLL = new BLL.HangHoa_BLL();
        int flagLuu = 0;
        public HangHoa()
        {
            InitializeComponent();
            Load_HangHoa();
        }         
        public void Load_HangHoa()
        {
            List<HangHoa_DTO> tthh = new List<HangHoa_DTO>();
            tthh = hhBLL.ThongTinHangHoa();
            dgvHangHoa.DataSource = tthh;
            Binding_HangHoa();
            DisEnl(false);
            stt();
            
        }
        private void stt()
        {
            int stt = 0;
            for (int i = 0; i < dgvHangHoa.Rows.Count; i++)
            {
                stt++;
                dgvHangHoa.Rows[i].Cells[0].Value = stt;
            }
        }
        private void Binding_HangHoa()
        {
            txtMaHang.DataBindings.Clear();
            txtMaHang.DataBindings.Add("Text", dgvHangHoa.DataSource, "MaHang");
            txtTenHang.DataBindings.Clear();
            txtTenHang.DataBindings.Add("Text", dgvHangHoa.DataSource, "TenHang");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvHangHoa.DataSource, "SoLuong");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvHangHoa.DataSource, "GhiChu");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvHangHoa.DataSource, "DonGia");
            txtHangSX.DataBindings.Clear();
            txtHangSX.DataBindings.Add("Text", dgvHangHoa.DataSource, "HangSX");
        }
        private void clearData()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtGhiChu.Text = "";
            txtDonGia.Text = "";
            txtHangSX.Text = "";
        }
        private void DisEnl(bool e)
        {
            btnThemhh.Enabled = !e;
            btnXoahh.Enabled = !e;
            btnSuahh.Enabled = !e;
            btnLuuhh.Enabled = e;
            btnHuyhh.Enabled = e;
            txtMaHang.Enabled = e;
            txtTenHang.Enabled = e;
            txtGhiChu.Enabled = e;
            txtSoLuong.Enabled = e;
            txtDonGia.Enabled = e;
            txtHangSX.Enabled = e;       
        }
        private bool kiemtra_rong()
        {
            Boolean kt = false;
            if(txtMaHang.Text=="")
            {
                MessageBox.Show("Vui lòng nhập mã hàng.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHang.Focus();
                kt = true;
            }
            if(txtTenHang.Text=="")
            {
                MessageBox.Show("Vui lòng nhập tên hàng.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHang.Focus();
                kt = true;
            }
            return kt;
        }
        private void ktThemhh()
        {
            try
            {
                HangHoa_DTO hh=new HangHoa_DTO();
                hh.MaHang = txtMaHang.Text.Trim();
                hh.TenHang = txtTenHang.Text.Trim();
                hh.SoLuong = int.Parse(txtSoLuong.Text.ToString());
                hh.GhiChu = txtGhiChu.Text.Trim();
                hh.DonGia = int.Parse(txtDonGia.Text.Trim().ToString());
                hh.HangSX = txtHangSX.Text.Trim();
                kiemtra_rong();              
                if (hhBLL.ThemHangHoa(hh))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Load_HangHoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ktSuahh()
        {
            try
            {
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.MaHang = txtMaHang.Text.Trim();
                hh.TenHang = txtTenHang.Text.Trim();
                hh.SoLuong = int.Parse(txtSoLuong.Text.ToString());
                hh.GhiChu = txtGhiChu.Text.Trim();
                hh.DonGia = int.Parse(txtDonGia.Text.Trim().ToString());
                hh.HangSX = txtHangSX.Text.Trim();
                if (hhBLL.SuaHangHoa(hh))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Load_HangHoa();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThemhh_Click(object sender, EventArgs e)
        {
            clearData();
            DisEnl(true);
            flagLuu = 0;
        }
        private void btnSuahh_Click(object sender, EventArgs e)
        {
            DisEnl(true);
            flagLuu = 1;
            txtMaHang.Enabled = false;
        }

        private void btnXoahh_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hàng hóa này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (!kiemtra_rong())
                    {
                        string mahh = txtMaHang.Text;
                        hhBLL.XoaHangHoa(mahh);
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load_HangHoa();
            DisEnl(false);          
        }
        private void btnHuyhh_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Load_HangHoa();
                DisEnl(false);
            }
            else
                return;
        }
        private void btnLuuhh_Click(object sender, EventArgs e)
        {
            if(flagLuu==0)
            {
                ktThemhh();
                string mahh = txtMaHang.Text;
                hhBLL.KiemtraKey(mahh);
            }
            if(flagLuu==1)
            {            
                ktSuahh();
            }
            Load_HangHoa();
            DisEnl(false);
        }
        private void txtTimKiemhh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<DTO.HangHoa_DTO> tthh = new List<DTO.HangHoa_DTO>();
                string mahang = txtMaHang.SelectedText.ToString();
                tthh = hhBLL.TimKiemHangHoa(txtTimKiemhh.Text.ToString());
                dgvHangHoa.DataSource = tthh;
                if (txtTimKiemhh.Text.ToString()==null)
                {
                    Load_HangHoa();
                    
                }
            }
            catch (Exception ex)
            {
               
                Load_HangHoa();
                
            }
        }
    }
}
