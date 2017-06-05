namespace QuanLyKhoHang
{
    partial class HangHoa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtHangSX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimKiemhh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuyhh = new System.Windows.Forms.Button();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_HANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_HANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO_LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DON_GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANG_SX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHI_CHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuuhh = new System.Windows.Forms.Button();
            this.btnXoahh = new System.Windows.Forms.Button();
            this.btnThemhh = new System.Windows.Forms.Button();
            this.btnSuahh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(512, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hàng Hóa Tồn Kho";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtHangSX);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(4, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1591, 306);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Hàng Hóa";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(1223, 105);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(295, 35);
            this.txtDonGia.TabIndex = 12;
            // 
            // txtHangSX
            // 
            this.txtHangSX.Location = new System.Drawing.Point(556, 105);
            this.txtHangSX.Margin = new System.Windows.Forms.Padding(4);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.Size = new System.Drawing.Size(367, 35);
            this.txtHangSX.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(1079, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 31);
            this.label8.TabIndex = 10;
            this.label8.Text = "Đơn Giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(360, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hãng SX";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKhoHang.Properties.Resources.muahag6357630614162478202;
            this.pictureBox1.Location = new System.Drawing.Point(23, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(556, 234);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(961, 35);
            this.txtGhiChu.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(1223, 43);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(295, 35);
            this.txtSoLuong.TabIndex = 2;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(556, 167);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(961, 35);
            this.txtTenHang.TabIndex = 1;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(556, 43);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(367, 35);
            this.txtMaHang.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(360, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghi Chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(1079, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(360, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(360, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtTimKiemhh);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnHuyhh);
            this.groupBox2.Controls.Add(this.dgvHangHoa);
            this.groupBox2.Controls.Add(this.btnLuuhh);
            this.groupBox2.Controls.Add(this.btnXoahh);
            this.groupBox2.Controls.Add(this.btnThemhh);
            this.groupBox2.Controls.Add(this.btnSuahh);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(4, 374);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1591, 404);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển Thị";
            // 
            // txtTimKiemhh
            // 
            this.txtTimKiemhh.Location = new System.Drawing.Point(133, 346);
            this.txtTimKiemhh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemhh.Name = "txtTimKiemhh";
            this.txtTimKiemhh.Size = new System.Drawing.Size(408, 35);
            this.txtTimKiemhh.TabIndex = 15;
            this.txtTimKiemhh.TextChanged += new System.EventHandler(this.txtTimKiemhh_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Image = global::QuanLyKhoHang.Properties.Resources.timkiem;
            this.label6.Location = new System.Drawing.Point(69, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 39);
            this.label6.TabIndex = 14;
            this.label6.Text = "    ";
            // 
            // btnHuyhh
            // 
            this.btnHuyhh.BackColor = System.Drawing.Color.White;
            this.btnHuyhh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyhh.ForeColor = System.Drawing.Color.Black;
            this.btnHuyhh.Image = global::QuanLyKhoHang.Properties.Resources.huy;
            this.btnHuyhh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyhh.Location = new System.Drawing.Point(1385, 341);
            this.btnHuyhh.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyhh.Name = "btnHuyhh";
            this.btnHuyhh.Size = new System.Drawing.Size(133, 55);
            this.btnHuyhh.TabIndex = 13;
            this.btnHuyhh.Text = "      Hủy";
            this.btnHuyhh.UseVisualStyleBackColor = false;
            this.btnHuyhh.Click += new System.EventHandler(this.btnHuyhh_Click);
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToOrderColumns = true;
            this.dgvHangHoa.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MA_HANG,
            this.TEN_HANG,
            this.SO_LUONG,
            this.DON_GIA,
            this.HANG_SX,
            this.GHI_CHU});
            this.dgvHangHoa.Location = new System.Drawing.Point(133, 16);
            this.dgvHangHoa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(1385, 299);
            this.dgvHangHoa.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "STT";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // MA_HANG
            // 
            this.MA_HANG.DataPropertyName = "MaHang";
            this.MA_HANG.HeaderText = "Mã Hàng";
            this.MA_HANG.Name = "MA_HANG";
            this.MA_HANG.ReadOnly = true;
            this.MA_HANG.Width = 150;
            // 
            // TEN_HANG
            // 
            this.TEN_HANG.DataPropertyName = "TenHang";
            this.TEN_HANG.HeaderText = "Tên Hàng";
            this.TEN_HANG.Name = "TEN_HANG";
            this.TEN_HANG.ReadOnly = true;
            this.TEN_HANG.Width = 220;
            // 
            // SO_LUONG
            // 
            this.SO_LUONG.DataPropertyName = "SoLuong";
            this.SO_LUONG.HeaderText = "Số Lượng";
            this.SO_LUONG.Name = "SO_LUONG";
            this.SO_LUONG.ReadOnly = true;
            // 
            // DON_GIA
            // 
            this.DON_GIA.DataPropertyName = "DonGia";
            this.DON_GIA.HeaderText = "Đơn Giá";
            this.DON_GIA.Name = "DON_GIA";
            this.DON_GIA.ReadOnly = true;
            this.DON_GIA.Width = 140;
            // 
            // HANG_SX
            // 
            this.HANG_SX.DataPropertyName = "HangSX";
            this.HANG_SX.HeaderText = "Hãng SX";
            this.HANG_SX.Name = "HANG_SX";
            this.HANG_SX.ReadOnly = true;
            this.HANG_SX.Width = 160;
            // 
            // GHI_CHU
            // 
            this.GHI_CHU.DataPropertyName = "GhiChu";
            this.GHI_CHU.HeaderText = "Ghi Chú";
            this.GHI_CHU.Name = "GHI_CHU";
            this.GHI_CHU.ReadOnly = true;
            this.GHI_CHU.Width = 220;
            // 
            // btnLuuhh
            // 
            this.btnLuuhh.BackColor = System.Drawing.Color.White;
            this.btnLuuhh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuhh.ForeColor = System.Drawing.Color.Black;
            this.btnLuuhh.Image = global::QuanLyKhoHang.Properties.Resources.luu;
            this.btnLuuhh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuhh.Location = new System.Drawing.Point(1199, 341);
            this.btnLuuhh.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuhh.Name = "btnLuuhh";
            this.btnLuuhh.Size = new System.Drawing.Size(133, 55);
            this.btnLuuhh.TabIndex = 12;
            this.btnLuuhh.Text = "     Lưu";
            this.btnLuuhh.UseVisualStyleBackColor = false;
            this.btnLuuhh.Click += new System.EventHandler(this.btnLuuhh_Click);
            // 
            // btnXoahh
            // 
            this.btnXoahh.BackColor = System.Drawing.Color.White;
            this.btnXoahh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoahh.ForeColor = System.Drawing.Color.Black;
            this.btnXoahh.Image = global::QuanLyKhoHang.Properties.Resources.xoa;
            this.btnXoahh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoahh.Location = new System.Drawing.Point(1009, 341);
            this.btnXoahh.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoahh.Name = "btnXoahh";
            this.btnXoahh.Size = new System.Drawing.Size(133, 55);
            this.btnXoahh.TabIndex = 11;
            this.btnXoahh.Text = "   Xóa";
            this.btnXoahh.UseVisualStyleBackColor = false;
            this.btnXoahh.Click += new System.EventHandler(this.btnXoahh_Click);
            // 
            // btnThemhh
            // 
            this.btnThemhh.BackColor = System.Drawing.Color.White;
            this.btnThemhh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemhh.ForeColor = System.Drawing.Color.Black;
            this.btnThemhh.Image = global::QuanLyKhoHang.Properties.Resources.them;
            this.btnThemhh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemhh.Location = new System.Drawing.Point(639, 341);
            this.btnThemhh.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemhh.Name = "btnThemhh";
            this.btnThemhh.Size = new System.Drawing.Size(119, 55);
            this.btnThemhh.TabIndex = 9;
            this.btnThemhh.Text = "       Thêm";
            this.btnThemhh.UseVisualStyleBackColor = false;
            this.btnThemhh.Click += new System.EventHandler(this.btnThemhh_Click);
            // 
            // btnSuahh
            // 
            this.btnSuahh.BackColor = System.Drawing.Color.White;
            this.btnSuahh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuahh.ForeColor = System.Drawing.Color.Black;
            this.btnSuahh.Image = global::QuanLyKhoHang.Properties.Resources.sua;
            this.btnSuahh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuahh.Location = new System.Drawing.Point(816, 341);
            this.btnSuahh.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuahh.Name = "btnSuahh";
            this.btnSuahh.Size = new System.Drawing.Size(133, 55);
            this.btnSuahh.TabIndex = 10;
            this.btnSuahh.Text = "      Sửa";
            this.btnSuahh.UseVisualStyleBackColor = false;
            this.btnSuahh.Click += new System.EventHandler(this.btnSuahh_Click);
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HangHoa";
            this.Size = new System.Drawing.Size(1600, 782);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHuyhh;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Button btnLuuhh;
        private System.Windows.Forms.Button btnXoahh;
        private System.Windows.Forms.Button btnThemhh;
        private System.Windows.Forms.Button btnSuahh;
        private System.Windows.Forms.TextBox txtTimKiemhh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtHangSX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_HANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_HANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SO_LUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DON_GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANG_SX;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHI_CHU;
    }
}
