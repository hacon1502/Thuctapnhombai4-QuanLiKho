using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            TrangChu tc = new TrangChu();
            panel.Controls.Add(tc);
        }

        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Controls.Clear();
                HangHoa hh = new HangHoa();
                panel.Controls.Add(hh);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void HDNhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Controls.Clear();
                PhieuNhap nhap = new PhieuNhap();
                panel.Controls.Add(nhap);
            }         
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void QLXuatHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Controls.Clear();
                PhieuXuat xuat = new PhieuXuat();
                panel.Controls.Add(xuat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            NguoiDung nd = new NguoiDung();
            panel.Controls.Add(nd);
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan hd = new HuongDan();
            hd.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void BaoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            NguoiDung nd = new NguoiDung();
            panel.Controls.Add(nd);
        }

        private void TroGiupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này đang được nâng cấp. Vui lòng quay lại sau!!","THÔNG BÁO");
        }
    }
}
