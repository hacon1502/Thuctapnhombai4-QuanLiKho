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
using DTO;
using BLL;

namespace QuanLyKhoHang
{
    public partial class ChiTietPN : Form
    {
        ChiTietPN_BLL ctpnBLL = new ChiTietPN_BLL();
        int flagLuu = 0, slmoi, slton, slupdate;
        public ChiTietPN()
        {
            InitializeComponent();
            Load_ChiTietPN();
            load_cboMaHang();
            load_cboMaPN();        
            
        }
        public void Load_ChiTietPN()
        {
            List<ChiTietPN_DTO> ttctpn = new List<ChiTietPN_DTO>();
            String mapn = cboMaPN.Text;
            dgvChiTietPN.DataSource = ctpnBLL.ChiTietPN(mapn);
             
            Binding_ChiTietPN();
            DisEnl(false);
            stt();

        }
        private void stt()
        {
            int stt = 0;
            for (int i = 0; i < dgvChiTietPN.Rows.Count; i++)
            {
                stt++;
                dgvChiTietPN.Rows[i].Cells[1].Value = stt;
            }
        }
        public void load_cboMaHang()
        {
            HangHoa_BLL hhBLL = new HangHoa_BLL();
            List<HangHoa_DTO> dshh = new List<HangHoa_DTO>();
            dshh = hhBLL.ThongTinHangHoa();
            foreach (var item in dshh)
            {
                string hienthi = item.MaHang;
                cboMaHangNhap.Items.Add(hienthi);
            }
            
        }
        public void load_cboMaPN()
        {
            PhieuNhap_BLL pnBLL = new PhieuNhap_BLL();
            List<PhieuNhap_DTO> dspn = new List<PhieuNhap_DTO>();
            dspn = pnBLL.ThongTinPhieuNhap();
            foreach (var item in dspn)
            {
                string hienthi = item.MaPN;
                cboMaPN.Items.Add(hienthi);
            }
        }
        private void cboMaPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string line = cboMaPN.SelectedItem.ToString();
            string[] arr = line.Split(':');
            string mapn = arr[0];
            List<ChiTietPN_DTO> ttctpn = new List<ChiTietPN_DTO>();           
            dgvChiTietPN.DataSource = ctpnBLL.ChiTietPN(mapn);
            stt();          
             
        }
        private void Binding_ChiTietPN()
        {
            cboMaPN.DataBindings.Clear();
            cboMaPN.DataBindings.Add("Text", dgvChiTietPN.DataSource, "MaPN");
            cboMaHangNhap.DataBindings.Clear();
            cboMaHangNhap.DataBindings.Add("Text", dgvChiTietPN.DataSource, "MaHang");
            txtTenHangNhap.DataBindings.Clear();
            txtTenHangNhap.DataBindings.Add("Text", dgvChiTietPN.DataSource, "TenHang");
            txtSLNhap.DataBindings.Clear();
            txtSLNhap.DataBindings.Add("Text", dgvChiTietPN.DataSource, "SoLuong");
            txtDonGiaNhap.DataBindings.Clear();
            txtDonGiaNhap.DataBindings.Add("Text", dgvChiTietPN.DataSource, "DonGiaNhap");
            //txtTongTienNhap.DataBindings.Clear();
            //txtTongTienNhap.DataBindings.Add("Text", dgvChiTietPN.DataSource, "TongTienNhap");

        }
        private void clearData()
        {
            cboMaPN.Text = "";
            cboMaHangNhap.Text = "";
            txtTenHangNhap.Text = "";
            txtSLNhap.Text = "";
            txtDonGiaNhap.Text = "";
            lbTienNhap.Text = "0";
            
        }
        private void DisEnl(bool e)
        {
            btnThemCTPN.Enabled = !e;
            btnXoaCTPN.Enabled = !e;
            btnSuaCTPN.Enabled = !e;
            btnLuuCTPN.Enabled = e;
            btnHuyCTPN.Enabled = e;
            cboMaHangNhap.Enabled = e;
            txtTenHangNhap.Enabled = e;
            txtSLNhap.Enabled = e;
            txtDonGiaNhap.Enabled = e;
            txtSLUpdate.Enabled = e;      
               
        }
        //Lay du lieu ten hang va don gia tu ma hang tuong ung
        public void auto()
        {
            SqlConnection con = new SqlConnection(globalParameter.connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from HANGHOA where MA_HANG='" + cboMaHangNhap.Text + "'";
            cmd.Connection = con;
            con.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cboMaHangNhap.Text = reader.GetString(0);
                    txtTenHangNhap.Text = reader.GetString(1);
                    txtDonGiaNhap.Text= Convert.ToString(reader.GetInt32(5));
                    
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
            con.Close();
            txtSLNhap.Focus();
        }
        //Auto ten, gia
        private void cboMaHangNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            auto();
            stt();

        }

        private int SLhangton()
        {
            try
            {
                SqlConnection con = new SqlConnection(globalParameter.connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from HANGHOA where MA_HANG='" +cboMaHangNhap.Text + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    slton = Convert.ToInt32(reader.GetValue(2).ToString());
                }
                reader.Close();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
            return slton;
        }
        private void UpdateSL()
        {
            SqlConnection con = new SqlConnection(globalParameter.connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();            
            for (int k = 0; k < dgvChiTietPN.Rows.Count - 1; k++)
            {
                //String maphieunhap = Convert.ToString(dgvChiTietPN.Rows[k].Cells["MaPN"]);
                String mahangnhap = Convert.ToString(dgvChiTietPN.Rows[k].Cells["MaHang"]);
                String tenphieunhap = Convert.ToString(dgvChiTietPN.Rows[k].Cells["TenHang"]);
                String soluongnhap = Convert.ToString(dgvChiTietPN.Rows[k].Cells["SoLuong"]);
                String dongianhap = Convert.ToString(dgvChiTietPN.Rows[k].Cells["DonGiaNhap"]);
                try
                {
                    if(txtSLNhap.Text!="")
                    {
                        if (Convert.ToString(slton) != "" && soluongnhap != "")
                            slupdate = Convert.ToInt32(soluongnhap) + Convert.ToInt32(slton);
                    }               
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cmd.CommandText = "update HANGHOA set SL ='" + slupdate + "'where MA_HANG='" +mahangnhap + "';";
                cmd.ExecuteNonQuery();
            }
            
        }     
    

        // Xu ly su kien KeyPress cua so luong nhap
        private void txtSLNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
          
        }
        private void txtSLNhap_TextChanged(object sender, EventArgs e)
        {
            int soluong, dongia;
            long thanhtien;
            try
            {
                if (txtSLNhap.Text != "")
                {
                    soluong = int.Parse(txtSLNhap.Text);
                    dongia = int.Parse(txtDonGiaNhap.Text);
                    thanhtien = dongia * soluong;
                    lbTienNhap.Text = thanhtien.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateSL();
            
                
        }
        private bool kiemtra_rong()
        {
            Boolean kt = false;
            if (cboMaHangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hàng.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaHangNhap.Focus();
                kt = true;
            }
            else if (txtTenHangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hàng.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHangNhap.Focus();
                kt = true;
            }
            else if (txtSLNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Số lượng.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSLNhap.Focus();
                kt = true;
            }
            return kt;
        }
        private void KtraThemCTPN()
        {
            
                ChiTietPN_DTO ctpn = new ChiTietPN_DTO();
                ctpn.MaPN = cboMaPN.Text.Trim();
                ctpn.MaHang = cboMaHangNhap.Text.Trim();
                ctpn.TenHang = txtTenHangNhap.Text.Trim();
                ctpn.SoLuong = int.Parse(txtSLNhap.Text.ToString());
                ctpn.DonGiaNhap= int.Parse(txtDonGiaNhap.Text.ToString());
                ctpn.TongTienNhap = int.Parse(lbTienNhap.Text.ToString());
                kiemtra_rong();

                if (ctpnBLL.ThemChiTietPN(ctpn))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Load_ChiTietPN();
           
        }
        private void KtraSuaCTPN()
        {
            try
            {
                ChiTietPN_DTO ctpn = new ChiTietPN_DTO();
                ctpn.MaPN = cboMaPN.Text.Trim();
                ctpn.MaHang = cboMaHangNhap.Text.Trim();
                ctpn.TenHang = txtTenHangNhap.Text.Trim();
                ctpn.SoLuong = int.Parse(txtSLNhap.Text.ToString());
                ctpn.DonGiaNhap = int.Parse(txtDonGiaNhap.Text.ToString());
                ctpn.TongTienNhap = int.Parse(lbTienNhap.Text.ToString());
                kiemtra_rong();
              
                if (ctpnBLL.SuaChiTietPN(ctpn))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Load_ChiTietPN();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Load_ChiTietPN();          
        }

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
        }

        private void btnSuaCTPN_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(false);
            Load_ChiTietPN();
            btnThemCTPN.Enabled = false;
            btnXoaCTPN.Enabled = false;
            btnSuaCTPN.Enabled = false;
            btnLuuCTPN.Enabled = true;
            btnHuyCTPN.Enabled = true;
            txtSLNhap.Enabled = true;
            cboMaPN.Enabled = false;

        }

        private void dgvChiTietPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_ChiTietPN();
        }

        private void btnLuuCTPN_Click(object sender, EventArgs e)
        {
            try
            {
                if (flagLuu == 0)
                {
                    KtraThemCTPN();
                    UpdateSL();
                   
                }
                if (flagLuu == 1)
                {
                    KtraSuaCTPN();
                    UpdateSL();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load_ChiTietPN();
            DisEnl(false);
        }
        private void btnXoaCTPN_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hàng hóa này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (!kiemtra_rong())
                    {
                        string mahh = cboMaHangNhap.Text;
                        ctpnBLL.XoaChiTietPN(mahh);
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
            Load_ChiTietPN();
            DisEnl(false);
        }

        private void btnHuyCTPN_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                clearData();
                Load_ChiTietPN();
                DisEnl(false);
            }
            else
                return;
        }

        
    }
}
