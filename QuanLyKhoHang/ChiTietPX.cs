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
    public partial class ChiTietPX : Form
    {
        ChiTietPX_BLL ctpxBLL = new ChiTietPX_BLL();
        int flagLuu = 0, slxuat, slton, slupdate;
        public ChiTietPX()
        {
            InitializeComponent();
            Load_ChiTietPX();
            Load_cboMaHang();
            Load_cboMaPX();
        }
        public void Load_ChiTietPX()
        {
            List<ChiTietPX_DTO> ttctpx = new List<ChiTietPX_DTO>();
            String mapx = cboMaPX.Text;
            dgvChiTietPX.DataSource = ctpxBLL.ChiTietPX(mapx);          
            Binding_ChiTietPX();
            DisEnl(false);
            stt();

        }

        private void cboMaPX_SelectedIndexChanged(object sender, EventArgs e)
        {
            string line = cboMaPX.SelectedItem.ToString();
            string[] arr = line.Split(':');
            string mapx = arr[0];
            List<ChiTietPX_DTO> ttctpx = new List<ChiTietPX_DTO>();
            dgvChiTietPX.DataSource = ctpxBLL.ChiTietPX(mapx);
            stt();
        }

        private void stt()
        {
            int stt = 0;
            for (int i = 0; i < dgvChiTietPX.Rows.Count; i++)
            {
                stt++;
                dgvChiTietPX.Rows[i].Cells[1].Value = stt;
            }
        }
        public void Load_cboMaHang()
        {
            HangHoa_BLL hhBLL = new HangHoa_BLL();
            List<HangHoa_DTO> dshh = new List<HangHoa_DTO>();
            dshh = hhBLL.ThongTinHangHoa();
            foreach (var item in dshh)
            {
                string hienthi = item.MaHang;
                cboMaHangXuat.Items.Add(hienthi);
            }
        }
        public void Load_cboMaPX()
        {
            PhieuXuat_BLL pxBLL = new PhieuXuat_BLL();
            List<PhieuXuat_DTO> dspx = new List<PhieuXuat_DTO>();
            dspx = pxBLL.ThongTinPhieuXuat();
            foreach (var item in dspx)
            {
                string hienthi = item.MaPX;
                cboMaPX.Items.Add(hienthi);
            }
        }
        private void Binding_ChiTietPX()
        {
            cboMaPX.DataBindings.Clear();
            cboMaPX.DataBindings.Add("Text", dgvChiTietPX.DataSource, "MaPX");
            cboMaHangXuat.DataBindings.Clear();
            cboMaHangXuat.DataBindings.Add("Text", dgvChiTietPX.DataSource, "MaHang");
            txtTenHangXuat.DataBindings.Clear();
            txtTenHangXuat.DataBindings.Add("Text", dgvChiTietPX.DataSource, "TenHangXuat");
            txtSLXuat.DataBindings.Clear();
            txtSLXuat.DataBindings.Add("Text", dgvChiTietPX.DataSource, "SLXuat");
            txtDonGiaXuat.DataBindings.Clear();
            txtDonGiaXuat.DataBindings.Add("Text", dgvChiTietPX.DataSource, "DonGiaXuat");
            //txtTongTienNhap.DataBindings.Clear();
            //txtTongTienNhap.DataBindings.Add("Text", dgvChiTietPN.DataSource, "TongTienNhap");

        }
        private void clearData()
        {
            cboMaPX.Text = "";
            cboMaHangXuat.Text = "";
            txtTenHangXuat.Text = "";
            txtSLXuat.Text = "";
            txtDonGiaXuat.Text = "";
            lbTienXuat.Text = "0";
        }
        private void DisEnl(bool e)
        {
            btnThemCTPX.Enabled = !e;
            btnXoaCTPX.Enabled = !e;
            btnSuaCTPX.Enabled = !e;
            btnLuuCTPX.Enabled = e;
            btnHuyCTPX.Enabled = e;
            cboMaHangXuat.Enabled = e;
            txtTenHangXuat.Enabled = e;
            txtSLXuat.Enabled = e;
            txtDonGiaXuat.Enabled = e;
            txtSLTonKho.Enabled = e;
        }

        //Lay du lieu ten hang va don gia tu ma hang tuong ung
        public void auto()
        {
            SqlConnection con = new SqlConnection(globalParameter.connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from HANGHOA where MA_HANG='" + cboMaHangXuat.Text + "'";
            cmd.Connection = con;
            con.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cboMaHangXuat.Text = reader.GetString(0);
                    txtTenHangXuat.Text = reader.GetString(1);
                    txtDonGiaNhap.Text = Convert.ToString(reader.GetInt32(5));
                    txtSLTonKho.Text = Convert.ToString(reader.GetInt32(2));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
            con.Close();
            //txtDonGiaXuat.Focus();
        }      
        private void cboMaHangXuat_SelectedIndexChanged(object sender, EventArgs e)
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
                cmd.CommandText = "select * from HANGHOA where MA_HANG='" + cboMaHangXuat.SelectedValue + "';";
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
        private int SLhangxuat()
        {
            try
            {
                SqlConnection con = new SqlConnection(globalParameter.connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from CHITIET_PX where MA_HANG='" + cboMaHangXuat.SelectedValue + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    slxuat = Convert.ToInt32(reader.GetValue(3).ToString());
                }
                reader.Close();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
            return slxuat;
        }
        private void UpdateSL()
        {
            auto();
            SqlConnection con = new SqlConnection(globalParameter.connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
           
                if (txtSLXuat.Text != "")
                    slupdate = Convert.ToInt32(txtSLTonKho.Text);

                cmd.CommandText = "update HANGHOA set SL ='" + slupdate + "'where MA_HANG='" + cboMaHangXuat.SelectedValue + "';";
                cmd.ExecuteNonQuery();
           
        }

        private void txtSLXuat_TextChanged(object sender, EventArgs e)
        {
            int soluong, dongia;
            long thanhtien;
            try
            {
                if (txtSLXuat.Text != "")
                {
                    soluong = int.Parse(txtSLXuat.Text);
                    dongia = int.Parse(txtDonGiaXuat.Text);
                    thanhtien = dongia * soluong;
                    lbTienXuat.Text = thanhtien.ToString();
                }

                if (Convert.ToInt32(txtSLXuat.Text) > Convert.ToInt32(txtSLTonKho.Text))
                {
                    DialogResult dr = MessageBox.Show("Số lượng xuất vượt quá giới hạn, vui lòng chọn lại", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txtSLXuat.Text = "";
                    }
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng nhập Số lượng xuất!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
               
        }

        
        private bool kiemtra_rong()
        {
            Boolean kt = false;
            if (cboMaHangXuat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hàng.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaHangXuat.Focus();
                kt = true;
            }
            else if (txtTenHangXuat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hàng.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHangXuat.Focus();
                kt = true;
            }
            else if (txtSLXuat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Số lượng.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSLXuat.Focus();
                kt = true;
            }
            return kt;
        }
        private void KtraThemCTPX()
        {

            ChiTietPX_DTO ctpx = new ChiTietPX_DTO();
            ctpx.MaPX = cboMaPX.Text.Trim();
            ctpx.MaHang = cboMaHangXuat.Text.Trim();
            ctpx.TenHangXuat = txtTenHangXuat.Text.Trim();
            ctpx.SLXuat = int.Parse(txtSLXuat.Text.ToString());
            ctpx.DonGiaXuat = int.Parse(txtDonGiaXuat.Text.ToString());
            ctpx.TongTienXuat = int.Parse(lbTienXuat.Text.ToString());
            kiemtra_rong();
            if (ctpxBLL.ThemChiTietPX(ctpx))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Load_ChiTietPX();
        }
        private void KtraSuaCTPX()
        {
            try
            {
                ChiTietPX_DTO ctpx = new ChiTietPX_DTO();
                ctpx.MaPX = cboMaPX.Text.Trim();
                ctpx.MaHang = cboMaHangXuat.Text.Trim();
                ctpx.TenHangXuat = txtTenHangXuat.Text.Trim();
                ctpx.SLXuat = int.Parse(txtSLXuat.Text.ToString());
                ctpx.DonGiaXuat = int.Parse(txtDonGiaXuat.Text.ToString());
                ctpx.TongTienXuat = int.Parse(lbTienXuat.Text.ToString());
                kiemtra_rong();

                if (ctpxBLL.SuaChiTietPX(ctpx))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Load_ChiTietPX();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         private void btnThemCTPX_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
        }

        private void btnSuaCTPX_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(false);
            Load_ChiTietPX();
            btnThemCTPX.Enabled = false;
            btnXoaCTPX.Enabled = false;
            btnSuaCTPX.Enabled = false;
            btnLuuCTPX.Enabled = true;
            btnHuyCTPX.Enabled = true;
            txtSLXuat.Enabled = true;
            cboMaPX.Enabled = false;
        }

        private void btnXoaCTPX_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hàng hóa này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (!kiemtra_rong())
                    {
                        string mahh = cboMaHangXuat.Text;
                        ctpxBLL.XoaChiTietPX(mahh);
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
            Load_ChiTietPX();
            DisEnl(false);
        }

        private void btnLuuCTPX_Click(object sender, EventArgs e)
        {
            try
            {
                if (flagLuu == 0)
                {
                    KtraThemCTPX();
                   

                }
                if (flagLuu == 1)
                {
                    KtraSuaCTPX();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdateSL();
            Load_ChiTietPX();
            DisEnl(false);
        }

        private void btnHuyCTPX_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                clearData();
                Load_ChiTietPX();
                DisEnl(false);
            }
            else
                return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Load_ChiTietPX();
        }

    }
}

