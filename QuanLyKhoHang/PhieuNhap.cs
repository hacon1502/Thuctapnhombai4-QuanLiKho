using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BLL;

namespace QuanLyKhoHang
{
    public partial class PhieuNhap : UserControl
    {
        PhieuNhap_BLL pnBLL = new PhieuNhap_BLL();
        
        int flagLuu = 0;
        public PhieuNhap()
        {
            InitializeComponent();
            Load_PhieuNhap();
            
            load_cboMaHang();
        }
        public void Load_PhieuNhap()
        {
            List<PhieuNhap_DTO> ttpn = new List<PhieuNhap_DTO>();
            dgvPhieuNhap.DataSource = pnBLL.ThongTinPhieuNhap();            
            Binding_PhieuNhap();
            DisEnl(false);
           
        }
       
        private void Binding_PhieuNhap()
        {
            txtMaPN.DataBindings.Clear();
            txtMaPN.DataBindings.Add("Text", dgvPhieuNhap.DataSource, "MaPN");
            txtNguonNhap.DataBindings.Clear();
            txtNguonNhap.DataBindings.Add("Text", dgvPhieuNhap.DataSource, "NguonNhap");
            dtpNgayNhap.DataBindings.Clear();
            dtpNgayNhap.DataBindings.Add("Text", dgvPhieuNhap.DataSource, "NgayNhap");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvPhieuNhap.DataSource, "DiaChi");
            txtGhiChuNhap.DataBindings.Clear();
            txtGhiChuNhap.DataBindings.Add("Text", dgvPhieuNhap.DataSource, "GhiChuNhap");
        }
        public void load_cboMaHang()
        {
            HangHoa_BLL hhBLL = new HangHoa_BLL();
            List<HangHoa_DTO> dshh = new List<HangHoa_DTO>();
            dshh = hhBLL.ThongTinHangHoa();
            foreach (var item in dshh)
            {
                string hienthi = item.MaHang;
                //cboMaHangNhap.Items.Add(hienthi);
            }
        }
        private void clearData()
        {
            txtMaPN.Text = "";
            txtNguonNhap.Text = "";
            txtDiaChi.Text = "";
            txtGhiChuNhap.Text = "";
            dtpNgayNhap.Value = DateTime.Now.Date;
        }
        private void DisEnl(bool e)
        {
            btnThemPN.Enabled = !e;
            btnXoaPN.Enabled = !e;
            btnSuaPN.Enabled = !e;
            btnLuuPN.Enabled = e;
            btnHuyPN.Enabled = e;
            txtMaPN.Enabled = e;
            txtNguonNhap.Enabled = e;
            dtpNgayNhap.Enabled = e;
            txtDiaChi.Enabled = e;
            txtGhiChuNhap.Enabled = e;
            
        }
        private bool kiemtra_rong()
        {
            Boolean kt = false;
            if (txtMaPN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã Phiếu.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPN.Focus();
                kt = true;
            }
            return kt;
        }
        private void ktThemPN()
        {
            try
            {
                PhieuNhap_DTO pn = new PhieuNhap_DTO();
                pn.MaPN = txtMaPN.Text.Trim();
                pn.NgayNhap = DateTime.Parse(dtpNgayNhap.Text.ToString());
                pn.NguonNhap = txtNguonNhap.Text.Trim();
                pn.DiaChi = txtDiaChi.Text.Trim();
                pn.GhiChuNhap = txtGhiChuNhap.Text.Trim();
                kiemtra_rong();

                if (pnBLL.ThemPhieuNhap(pn))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Load_PhieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ktSuaPN()
        {
            try
            {
                PhieuNhap_DTO pn = new PhieuNhap_DTO();
                pn.MaPN = txtMaPN.Text.Trim();
                pn.NgayNhap = DateTime.Parse(dtpNgayNhap.Text.ToString());
                pn.NguonNhap = txtNguonNhap.Text.Trim();
                pn.DiaChi = txtDiaChi.Text.Trim();
                pn.GhiChuNhap = txtGhiChuNhap.Text.Trim();

                if (pnBLL.SuaPhieuNhap(pn))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Load_PhieuNhap();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void dienSTT()
        {
            int stt = 1;
            for(int j=0;j<dgvPhieuNhap.Rows.Count;j++)
            {
                dgvPhieuNhap.Rows[j].Cells["STT"].Value = stt;
            }
        }
       
        private void MaTuDongTang()
        {
            SqlConnection conn = new SqlConnection(globalParameter.connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PHIEUNHAP";
            conn.Open();
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

           
            string g = "";
            int count = dgvPhieuNhap.Rows.Count - 1;


            if (dgvPhieuNhap.Rows.Count <= 0)
            {
                g = "PN01";
            }
            else
            {
                for (int x = 0; x < dgvPhieuNhap.Rows.Count - 1; x++)
                {
                    int k;
                    g = "PN";
                    if(txtMaPN.Text!="")
                    {
                        k = Convert.ToInt32(dgvPhieuNhap.Rows[x].Cells["MaPN"].ToString().Substring(2, 2));
                        k = k + 1;
                        if (k < 10)
                            g = g + "0";
                        g = g + k.ToString();
                    }                
                   
                   
                }
                
            }
            txtMaPN.Text = g;
        }
        private void btnThemPN_Click(object sender, EventArgs e)
        {
            clearData();
            flagLuu = 0;
            DisEnl(true);
            //Ma tu tang
            int count = 0;
            count = dgvPhieuNhap.Rows.Count;      //dem tat ca cac dong trong dgv phieu nhap
            if(count>0)
            {
                string chuoi1 = "";
                int chuoi2 = 0;
                chuoi1 = Convert.ToString(dgvPhieuNhap.Rows[count - 1].Cells[0].Value); //vi tri hang cuoi cung
                chuoi2 = Convert.ToInt32((chuoi1.Remove(0, 2)));  //xoa 'PN' trong phieu nhap
                if (chuoi2 + 1 < 10)
                    txtMaPN.Text = "PN0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                {
                    txtMaPN.Text = "PN" + (chuoi2 + 1).ToString();
                }
            }
        }

        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hàng hóa này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (!kiemtra_rong())
                    {
                        string mapn = txtMaPN.Text;
                        pnBLL.XoaPhieuNhap(mapn);
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Load_PhieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyPN_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Load_PhieuNhap();
                DisEnl(false);
            }
            else
                return;
        }

        private void btnLuuPN_Click(object sender, EventArgs e)
        {
            try
            {
                if (flagLuu == 0)
                {
                    ktThemPN();
                }
                if (flagLuu == 1)
                {
                    ktSuaPN();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load_PhieuNhap();
            DisEnl(false);
        }
        private void txtTimKiempn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<PhieuNhap_DTO> ttpn = new List<PhieuNhap_DTO>();
                
                ttpn = pnBLL.TimKiemPN(txtTimKiempn.Text.ToString());
                dgvPhieuNhap.DataSource = ttpn;
                if (txtTimKiempn.Text.ToString() == null)
                {
                    Load_PhieuNhap();
                }
            }
            catch (Exception ex)
            {
                Load_PhieuNhap();
            }
        }

        private void btnChiTietPN_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ChiTietPN ctpn = new ChiTietPN();
            ctpn.ShowDialog();
        }
    }
}
