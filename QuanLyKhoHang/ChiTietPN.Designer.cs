namespace QuanLyKhoHang
{
    partial class ChiTietPN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaPN = new System.Windows.Forms.ComboBox();
            this.dgvChiTietPN = new System.Windows.Forms.DataGridView();
            this.btnHuyCTPN = new System.Windows.Forms.Button();
            this.btnLuuCTPN = new System.Windows.Forms.Button();
            this.btnXoaCTPN = new System.Windows.Forms.Button();
            this.btnThemCTPN = new System.Windows.Forms.Button();
            this.btnSuaCTPN = new System.Windows.Forms.Button();
            this.cboMaHangNhap = new System.Windows.Forms.ComboBox();
            this.txtSLNhap = new System.Windows.Forms.TextBox();
            this.txtTenHangNhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTienNhap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSLUpdate = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONG_TIEN_NHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(258, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu";
            // 
            // cboMaPN
            // 
            this.cboMaPN.FormattingEnabled = true;
            this.cboMaPN.Location = new System.Drawing.Point(388, 25);
            this.cboMaPN.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaPN.Name = "cboMaPN";
            this.cboMaPN.Size = new System.Drawing.Size(209, 28);
            this.cboMaPN.TabIndex = 4;
            this.cboMaPN.SelectedIndexChanged += new System.EventHandler(this.cboMaPN_SelectedIndexChanged);
            // 
            // dgvChiTietPN
            // 
            this.dgvChiTietPN.AllowUserToOrderColumns = true;
            this.dgvChiTietPN.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvChiTietPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MAPN,
            this.MaHang,
            this.TenHang,
            this.SoLuong,
            this.DonGiaNhap,
            this.TONG_TIEN_NHAP});
            this.dgvChiTietPN.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvChiTietPN.Location = new System.Drawing.Point(78, 256);
            this.dgvChiTietPN.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiTietPN.Name = "dgvChiTietPN";
            this.dgvChiTietPN.Size = new System.Drawing.Size(960, 228);
            this.dgvChiTietPN.TabIndex = 8;
            this.dgvChiTietPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPN_CellClick);
            // 
            // btnHuyCTPN
            // 
            this.btnHuyCTPN.BackColor = System.Drawing.Color.White;
            this.btnHuyCTPN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyCTPN.ForeColor = System.Drawing.Color.Black;
            this.btnHuyCTPN.Image = global::QuanLyKhoHang.Properties.Resources.huy;
            this.btnHuyCTPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyCTPN.Location = new System.Drawing.Point(753, 531);
            this.btnHuyCTPN.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyCTPN.Name = "btnHuyCTPN";
            this.btnHuyCTPN.Size = new System.Drawing.Size(110, 45);
            this.btnHuyCTPN.TabIndex = 23;
            this.btnHuyCTPN.Text = "      Hủy";
            this.btnHuyCTPN.UseVisualStyleBackColor = false;
            this.btnHuyCTPN.Click += new System.EventHandler(this.btnHuyCTPN_Click);
            // 
            // btnLuuCTPN
            // 
            this.btnLuuCTPN.BackColor = System.Drawing.Color.White;
            this.btnLuuCTPN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuCTPN.ForeColor = System.Drawing.Color.Black;
            this.btnLuuCTPN.Image = global::QuanLyKhoHang.Properties.Resources.luu;
            this.btnLuuCTPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCTPN.Location = new System.Drawing.Point(581, 531);
            this.btnLuuCTPN.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuCTPN.Name = "btnLuuCTPN";
            this.btnLuuCTPN.Size = new System.Drawing.Size(110, 45);
            this.btnLuuCTPN.TabIndex = 22;
            this.btnLuuCTPN.Text = "     Lưu";
            this.btnLuuCTPN.UseVisualStyleBackColor = false;
            this.btnLuuCTPN.Click += new System.EventHandler(this.btnLuuCTPN_Click);
            // 
            // btnXoaCTPN
            // 
            this.btnXoaCTPN.BackColor = System.Drawing.Color.White;
            this.btnXoaCTPN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaCTPN.ForeColor = System.Drawing.Color.Black;
            this.btnXoaCTPN.Image = global::QuanLyKhoHang.Properties.Resources.xoa;
            this.btnXoaCTPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCTPN.Location = new System.Drawing.Point(411, 531);
            this.btnXoaCTPN.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaCTPN.Name = "btnXoaCTPN";
            this.btnXoaCTPN.Size = new System.Drawing.Size(110, 45);
            this.btnXoaCTPN.TabIndex = 21;
            this.btnXoaCTPN.Text = "   Xóa";
            this.btnXoaCTPN.UseVisualStyleBackColor = false;
            this.btnXoaCTPN.Click += new System.EventHandler(this.btnXoaCTPN_Click);
            // 
            // btnThemCTPN
            // 
            this.btnThemCTPN.BackColor = System.Drawing.Color.White;
            this.btnThemCTPN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemCTPN.ForeColor = System.Drawing.Color.Black;
            this.btnThemCTPN.Image = global::QuanLyKhoHang.Properties.Resources.them;
            this.btnThemCTPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCTPN.Location = new System.Drawing.Point(74, 531);
            this.btnThemCTPN.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemCTPN.Name = "btnThemCTPN";
            this.btnThemCTPN.Size = new System.Drawing.Size(110, 45);
            this.btnThemCTPN.TabIndex = 19;
            this.btnThemCTPN.Text = "     Thêm";
            this.btnThemCTPN.UseVisualStyleBackColor = false;
            this.btnThemCTPN.Click += new System.EventHandler(this.btnThemCTPN_Click);
            // 
            // btnSuaCTPN
            // 
            this.btnSuaCTPN.BackColor = System.Drawing.Color.White;
            this.btnSuaCTPN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaCTPN.ForeColor = System.Drawing.Color.Black;
            this.btnSuaCTPN.Image = global::QuanLyKhoHang.Properties.Resources.sua;
            this.btnSuaCTPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaCTPN.Location = new System.Drawing.Point(240, 531);
            this.btnSuaCTPN.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaCTPN.Name = "btnSuaCTPN";
            this.btnSuaCTPN.Size = new System.Drawing.Size(110, 45);
            this.btnSuaCTPN.TabIndex = 20;
            this.btnSuaCTPN.Text = "      Sửa";
            this.btnSuaCTPN.UseVisualStyleBackColor = false;
            this.btnSuaCTPN.Click += new System.EventHandler(this.btnSuaCTPN_Click);
            // 
            // cboMaHangNhap
            // 
            this.cboMaHangNhap.FormattingEnabled = true;
            this.cboMaHangNhap.Location = new System.Drawing.Point(388, 82);
            this.cboMaHangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaHangNhap.Name = "cboMaHangNhap";
            this.cboMaHangNhap.Size = new System.Drawing.Size(209, 28);
            this.cboMaHangNhap.TabIndex = 29;
            this.cboMaHangNhap.SelectedIndexChanged += new System.EventHandler(this.cboMaHangNhap_SelectedIndexChanged);
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.Location = new System.Drawing.Point(388, 143);
            this.txtSLNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.Size = new System.Drawing.Size(209, 26);
            this.txtSLNhap.TabIndex = 28;
            this.txtSLNhap.TextChanged += new System.EventHandler(this.txtSLNhap_TextChanged);
            this.txtSLNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLNhap_KeyPress);
            // 
            // txtTenHangNhap
            // 
            this.txtTenHangNhap.Location = new System.Drawing.Point(833, 25);
            this.txtTenHangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHangNhap.Name = "txtTenHangNhap";
            this.txtTenHangNhap.Size = new System.Drawing.Size(211, 26);
            this.txtTenHangNhap.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(263, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 26);
            this.label7.TabIndex = 26;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(675, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 26);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tên hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(258, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mã hàng";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = global::QuanLyKhoHang.Properties.Resources.huy;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(928, 531);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 45);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "    Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(675, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Đơn giá";
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(833, 86);
            this.txtDonGiaNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(211, 26);
            this.txtDonGiaNhap.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(262, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tổng tiền";
            // 
            // lbTienNhap
            // 
            this.lbTienNhap.AutoSize = true;
            this.lbTienNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTienNhap.Location = new System.Drawing.Point(399, 198);
            this.lbTienNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTienNhap.Name = "lbTienNhap";
            this.lbTienNhap.Size = new System.Drawing.Size(0, 26);
            this.lbTienNhap.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(675, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "Cập nhật SL";
            // 
            // txtSLUpdate
            // 
            this.txtSLUpdate.Location = new System.Drawing.Point(833, 143);
            this.txtSLUpdate.Name = "txtSLUpdate";
            this.txtSLUpdate.Size = new System.Drawing.Size(110, 26);
            this.txtSLUpdate.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKhoHang.Properties.Resources.muahag635763061416247820;
            this.pictureBox1.Location = new System.Drawing.Point(20, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "STT";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // MAPN
            // 
            this.MAPN.DataPropertyName = "MaPN";
            this.MAPN.HeaderText = "Mã phiếu";
            this.MAPN.Name = "MAPN";
            this.MAPN.ReadOnly = true;
            this.MAPN.Width = 120;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            this.MaHang.Width = 120;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            this.TenHang.Width = 210;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 110;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.HeaderText = "Đơn giá";
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.ReadOnly = true;
            this.DonGiaNhap.Width = 130;
            // 
            // TONG_TIEN_NHAP
            // 
            this.TONG_TIEN_NHAP.DataPropertyName = "TongTIenNhap";
            this.TONG_TIEN_NHAP.HeaderText = "Thành tiền";
            this.TONG_TIEN_NHAP.Name = "TONG_TIEN_NHAP";
            this.TONG_TIEN_NHAP.ReadOnly = true;
            this.TONG_TIEN_NHAP.Width = 150;
            // 
            // ChiTietPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 596);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSLUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTienNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDonGiaNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cboMaHangNhap);
            this.Controls.Add(this.txtSLNhap);
            this.Controls.Add(this.txtTenHangNhap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHuyCTPN);
            this.Controls.Add(this.btnLuuCTPN);
            this.Controls.Add(this.btnXoaCTPN);
            this.Controls.Add(this.btnThemCTPN);
            this.Controls.Add(this.btnSuaCTPN);
            this.Controls.Add(this.dgvChiTietPN);
            this.Controls.Add(this.cboMaPN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChiTietPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietPN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaPN;
        private System.Windows.Forms.DataGridView dgvChiTietPN;
        private System.Windows.Forms.Button btnHuyCTPN;
        private System.Windows.Forms.Button btnLuuCTPN;
        private System.Windows.Forms.Button btnXoaCTPN;
        private System.Windows.Forms.Button btnThemCTPN;
        private System.Windows.Forms.Button btnSuaCTPN;
        private System.Windows.Forms.ComboBox cboMaHangNhap;
        private System.Windows.Forms.TextBox txtSLNhap;
        private System.Windows.Forms.TextBox txtTenHangNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTienNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSLUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONG_TIEN_NHAP;
    }
}