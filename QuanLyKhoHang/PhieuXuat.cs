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
    public partial class PhieuXuat : UserControl
    {
        PhieuXuat_BLL pxBLL = new PhieuXuat_BLL();

        int flagLuu = 0;
        public PhieuXuat()
        {
            InitializeComponent();
            Load_PhieuXuat();

            
        }
        public void Load_PhieuXuat()
        {
            List<PhieuXuat_DTO> ttpn = new List<PhieuXuat_DTO>();
            dgvPhieuXuat.DataSource = pxBLL.ThongTinPhieuXuat();
            Binding_PhieuXuat();
            DisEnl(false);
            //int stt = 0;
            //for (int i = 0; i < dgvPhieuNhap.Rows.Count; i++)
            //{
            //    stt++;
            //    dgvPhieuNhap.Rows[i].Cells[0].Value = stt;
            //}
        }
       
        private void Binding_PhieuXuat()
        {
            txtMaPX.DataBindings.Clear();
            txtMaPX.DataBindings.Add("Text", dgvPhieuXuat.DataSource, "MaPX");
            txtNguoiNhan.DataBindings.Clear();
            txtNguoiNhan.DataBindings.Add("Text", dgvPhieuXuat.DataSource, "NguoiNhan");
            dtpNgayXuat.DataBindings.Clear();
            dtpNgayXuat.DataBindings.Add("Text", dgvPhieuXuat.DataSource, "NgayXuat");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvPhieuXuat.DataSource, "DiaChi");
            txtGhiChuXuat.DataBindings.Clear();
            txtGhiChuXuat.DataBindings.Add("Text", dgvPhieuXuat.DataSource, "GhiChuXuat");
        }
       
        private void clearData()
        {
            txtMaPX.Text = "";
            txtNguoiNhan.Text = "";
            txtDiaChi.Text = "";
            txtGhiChuXuat.Text = "";
            dtpNgayXuat.Value = DateTime.Now.Date;
        }
        private void DisEnl(bool e)
        {
            btnThemPX.Enabled = !e;
            btnXoaPX.Enabled = !e;
            btnSuaPX.Enabled = !e;
            btnLuuPX.Enabled = e;
            btnHuyPX.Enabled = e;
            txtMaPX.Enabled = e;
            txtNguoiNhan.Enabled = e;
            dtpNgayXuat.Enabled = e;
            txtDiaChi.Enabled = e;
            txtGhiChuXuat.Enabled = e;

        }
        private void dienSTT()
        {
            int stt = 1;
            for (int j = 0; j < dgvPhieuXuat.Rows.Count; j++)
            {
                dgvPhieuXuat.Rows[j].Cells["STT"].Value = stt;
            }
        }
        private void MaTuDongTang()
        {
            SqlConnection conn = new SqlConnection(globalParameter.connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PHIEUXUAT";
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int k;
            string g = "";

            if (dt.Rows.Count <= 0)
            {
                g = "PX01";
            }
            else
            {

                g = "PN";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 2));

                k = k + 1;
                if (k < 10)
                    g = g + "0";
                g = g + k.ToString();
            }
            txtMaPX.Text = g;
        }

        private bool kiemtra_rong()
        {
            Boolean kt = false;
            if (txtMaPX.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã Phiếu.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPX.Focus();
                kt = true;
            }
            return kt;
        }
        private void ktThemPX()
        {
            try
            {
                PhieuXuat_DTO px = new PhieuXuat_DTO();
                px.MaPX= txtMaPX.Text.Trim();
                px.NgayXuat= DateTime.Parse(dtpNgayXuat.Text.ToString());
                px.NguoiNhan = txtNguoiNhan.Text.Trim();
                px.DiaChi = txtDiaChi.Text.Trim();
                px.GhiChuXuat = txtGhiChuXuat.Text.Trim();
                kiemtra_rong();

                if (pxBLL.ThemPhieuXuat(px))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Load_PhieuXuat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ktSuaPX()
        {
            try
            {
                PhieuXuat_DTO px = new PhieuXuat_DTO();
                px.MaPX = txtMaPX.Text.Trim();
                px.NgayXuat = DateTime.Parse(dtpNgayXuat.Text.ToString());
                px.NguoiNhan = txtNguoiNhan.Text.Trim();
                px.DiaChi = txtDiaChi.Text.Trim();
                px.GhiChuXuat = txtGhiChuXuat.Text.Trim();
                kiemtra_rong();

                if (pxBLL.SuaPhieuXuat(px))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Load_PhieuXuat();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        
        private void btnThemPX_Click(object sender, EventArgs e)
        {
            clearData();
            flagLuu = 0;
            DisEnl(true);
            // MaTuDongTang
           
            int count = 0;
            count = dgvPhieuXuat.Rows.Count;      //dem tat ca cac dong trong dgv phieu nhap
            if(count>0)
            {
                string chuoi1 = "";
                int chuoi2 = 0;
                chuoi1 = Convert.ToString(dgvPhieuXuat.Rows[count - 1].Cells[0].Value); //vi tri hang cuoi cung
                chuoi2 = Convert.ToInt32((chuoi1.Remove(0, 2)));  //xoa 'PN' trong phieu nhap
                if (chuoi2 + 1 < 10)
                    txtMaPX.Text = "PX0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                {
                    txtMaPX.Text = "PX" + (chuoi2 + 1).ToString();
                }
            }
        }

        private void btnSuaPX_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
        }

        private void btnXoaPX_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hàng hóa này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (!kiemtra_rong())
                    {
                        string mapx = txtMaPX.Text;
                        pxBLL.XoaPhieuXuat(mapx);
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Load_PhieuXuat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuPX_Click(object sender, EventArgs e)
        {
            try
            {
                if (flagLuu == 0)
                {
                    ktThemPX();
                }
                if (flagLuu == 1)
                {
                    ktSuaPX();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load_PhieuXuat();
            DisEnl(false);
        }

        private void btnHuyPX_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Load_PhieuXuat();
                DisEnl(false);
            }
            else
                return;
        }

        private void btnChiTietPX_Click(object sender, EventArgs e)
        {
            ChiTietPX ctpx = new ChiTietPX();
            ctpx.ShowDialog();
        }
    }
}
