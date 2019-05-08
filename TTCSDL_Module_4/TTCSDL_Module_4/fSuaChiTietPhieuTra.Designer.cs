namespace TTCSDL_Module_4
{
    partial class fSuaChiTietPhieuTra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDSSP = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtIMEI = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSP_MaSP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nmDonGia = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSP_LyDo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.cbIMEI = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSP_TenSP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIDHD = new System.Windows.Forms.TextBox();
            this.dtgvSP = new System.Windows.Forms.DataGridView();
            this.btnLayThongTinHD = new System.Windows.Forms.Button();
            this.dtgvHD = new System.Windows.Forms.DataGridView();
            this.IDHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThucTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD_ThueGTGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.SP_IDSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SP_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SP_DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SP_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SP_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SP_IMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SP_IDHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.IDHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDoiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaPT
            // 
            this.txtMaPT.Enabled = false;
            this.txtMaPT.Location = new System.Drawing.Point(84, 12);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.ReadOnly = true;
            this.txtMaPT.Size = new System.Drawing.Size(124, 20);
            this.txtMaPT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu trả";
            // 
            // dtgvDSSP
            // 
            this.dtgvDSSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSSP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDHoaDon,
            this.IDSP,
            this.IDDoiTra,
            this.IMEI,
            this.TenSP,
            this.LyDo,
            this.Gia,
            this.SoLuong});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDSSP.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDSSP.Location = new System.Drawing.Point(15, 38);
            this.dtgvDSSP.Name = "dtgvDSSP";
            this.dtgvDSSP.ReadOnly = true;
            this.dtgvDSSP.Size = new System.Drawing.Size(746, 421);
            this.dtgvDSSP.TabIndex = 2;
            this.dtgvDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSSP_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã sản phẩm : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số IMEI : ";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(104, 476);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(124, 20);
            this.txtMaSP.TabIndex = 7;
            // 
            // txtIMEI
            // 
            this.txtIMEI.Enabled = false;
            this.txtIMEI.Location = new System.Drawing.Point(315, 476);
            this.txtIMEI.Name = "txtIMEI";
            this.txtIMEI.ReadOnly = true;
            this.txtIMEI.Size = new System.Drawing.Size(124, 20);
            this.txtIMEI.TabIndex = 8;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Enabled = false;
            this.txtTenSP.Location = new System.Drawing.Point(104, 512);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(335, 20);
            this.txtTenSP.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên sản phẩm : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lý do : ";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(104, 550);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(335, 59);
            this.txtLyDo.TabIndex = 12;
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Location = new System.Drawing.Point(460, 473);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(75, 59);
            this.btnSuaSP.TabIndex = 13;
            this.btnSuaSP.Text = "Sửa sản phẩm";
            this.btnSuaSP.UseVisualStyleBackColor = true;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(460, 550);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(75, 59);
            this.btnXoaSP.TabIndex = 14;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(249, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Danh sách sản phẩm";
            // 
            // txtSP_MaSP
            // 
            this.txtSP_MaSP.Enabled = false;
            this.txtSP_MaSP.Location = new System.Drawing.Point(906, 574);
            this.txtSP_MaSP.Name = "txtSP_MaSP";
            this.txtSP_MaSP.ReadOnly = true;
            this.txtSP_MaSP.Size = new System.Drawing.Size(113, 20);
            this.txtSP_MaSP.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(803, 577);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Mã sản phẩm";
            // 
            // nmDonGia
            // 
            this.nmDonGia.Enabled = false;
            this.nmDonGia.Location = new System.Drawing.Point(1121, 635);
            this.nmDonGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmDonGia.Name = "nmDonGia";
            this.nmDonGia.ReadOnly = true;
            this.nmDonGia.Size = new System.Drawing.Size(118, 20);
            this.nmDonGia.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1071, 640);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Đơn giá";
            // 
            // txtSP_LyDo
            // 
            this.txtSP_LyDo.Location = new System.Drawing.Point(906, 666);
            this.txtSP_LyDo.Multiline = true;
            this.txtSP_LyDo.Name = "txtSP_LyDo";
            this.txtSP_LyDo.Size = new System.Drawing.Size(333, 43);
            this.txtSP_LyDo.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(803, 666);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Lý do";
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(1262, 643);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(76, 66);
            this.btnThemSP.TabIndex = 44;
            this.btnThemSP.Text = "Thêm vào danh sách trả";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // cbIMEI
            // 
            this.cbIMEI.FormattingEnabled = true;
            this.cbIMEI.Location = new System.Drawing.Point(906, 637);
            this.cbIMEI.Name = "cbIMEI";
            this.cbIMEI.Size = new System.Drawing.Size(113, 21);
            this.cbIMEI.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(803, 637);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "IMEI";
            // 
            // txtSP_TenSP
            // 
            this.txtSP_TenSP.Enabled = false;
            this.txtSP_TenSP.Location = new System.Drawing.Point(906, 601);
            this.txtSP_TenSP.Name = "txtSP_TenSP";
            this.txtSP_TenSP.ReadOnly = true;
            this.txtSP_TenSP.Size = new System.Drawing.Size(333, 20);
            this.txtSP_TenSP.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(803, 608);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Tên sản phẩm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(797, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Mã hóa đơn";
            // 
            // txtIDHD
            // 
            this.txtIDHD.Location = new System.Drawing.Point(868, 272);
            this.txtIDHD.Name = "txtIDHD";
            this.txtIDHD.Size = new System.Drawing.Size(100, 20);
            this.txtIDHD.TabIndex = 38;
            // 
            // dtgvSP
            // 
            this.dtgvSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SP_IDSP,
            this.SP_TenSP,
            this.SP_DVT,
            this.SP_SoLuong,
            this.SP_Gia,
            this.SP_IMEI,
            this.SP_IDHD});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvSP.Location = new System.Drawing.Point(797, 299);
            this.dtgvSP.Name = "dtgvSP";
            this.dtgvSP.ReadOnly = true;
            this.dtgvSP.Size = new System.Drawing.Size(541, 262);
            this.dtgvSP.TabIndex = 37;
            this.dtgvSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSP_CellClick);
            // 
            // btnLayThongTinHD
            // 
            this.btnLayThongTinHD.Location = new System.Drawing.Point(985, 270);
            this.btnLayThongTinHD.Name = "btnLayThongTinHD";
            this.btnLayThongTinHD.Size = new System.Drawing.Size(139, 23);
            this.btnLayThongTinHD.TabIndex = 36;
            this.btnLayThongTinHD.Text = "Lấy thông tin hóa đơn";
            this.btnLayThongTinHD.UseVisualStyleBackColor = true;
            this.btnLayThongTinHD.Click += new System.EventHandler(this.btnLayThongTinHD_Click);
            // 
            // dtgvHD
            // 
            this.dtgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDHD,
            this.TenKH,
            this.NgayLapHD,
            this.TenNV,
            this.IDKH,
            this.IDNV,
            this.HinhThucTT,
            this.HD_ThueGTGT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvHD.Location = new System.Drawing.Point(797, 35);
            this.dtgvHD.Name = "dtgvHD";
            this.dtgvHD.ReadOnly = true;
            this.dtgvHD.Size = new System.Drawing.Size(541, 229);
            this.dtgvHD.TabIndex = 35;
            // 
            // IDHD
            // 
            this.IDHD.DataPropertyName = "IDHD";
            this.IDHD.HeaderText = "Mã hóa đơn";
            this.IDHD.Name = "IDHD";
            this.IDHD.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Khách hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.DataPropertyName = "NgayLapHD";
            this.NgayLapHD.HeaderText = "Ngày mua";
            this.NgayLapHD.Name = "NgayLapHD";
            this.NgayLapHD.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Nhân viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // IDKH
            // 
            this.IDKH.DataPropertyName = "IDKH";
            this.IDKH.HeaderText = "IDKH";
            this.IDKH.Name = "IDKH";
            this.IDKH.ReadOnly = true;
            this.IDKH.Visible = false;
            // 
            // IDNV
            // 
            this.IDNV.DataPropertyName = "IDNV";
            this.IDNV.HeaderText = "IDNV";
            this.IDNV.Name = "IDNV";
            this.IDNV.ReadOnly = true;
            this.IDNV.Visible = false;
            // 
            // HinhThucTT
            // 
            this.HinhThucTT.DataPropertyName = "HinhThucTT";
            this.HinhThucTT.HeaderText = "HinhThucTT";
            this.HinhThucTT.Name = "HinhThucTT";
            this.HinhThucTT.ReadOnly = true;
            this.HinhThucTT.Visible = false;
            // 
            // HD_ThueGTGT
            // 
            this.HD_ThueGTGT.DataPropertyName = "ThueGTGT";
            this.HD_ThueGTGT.HeaderText = "Column1";
            this.HD_ThueGTGT.Name = "HD_ThueGTGT";
            this.HD_ThueGTGT.ReadOnly = true;
            this.HD_ThueGTGT.Visible = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(1121, 6);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(106, 23);
            this.btnTimKiem.TabIndex = 34;
            this.btnTimKiem.Text = "Tìm kiếm hóa đơn";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(797, 8);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(318, 20);
            this.txtTimKiem.TabIndex = 33;
            // 
            // SP_IDSP
            // 
            this.SP_IDSP.DataPropertyName = "IDSP";
            this.SP_IDSP.HeaderText = "Mã sản phẩm";
            this.SP_IDSP.Name = "SP_IDSP";
            this.SP_IDSP.ReadOnly = true;
            // 
            // SP_TenSP
            // 
            this.SP_TenSP.DataPropertyName = "TenSP";
            this.SP_TenSP.HeaderText = "Tên sản phẩm";
            this.SP_TenSP.Name = "SP_TenSP";
            this.SP_TenSP.ReadOnly = true;
            // 
            // SP_DVT
            // 
            this.SP_DVT.DataPropertyName = "DVT";
            this.SP_DVT.HeaderText = "ĐVT";
            this.SP_DVT.Name = "SP_DVT";
            this.SP_DVT.ReadOnly = true;
            // 
            // SP_SoLuong
            // 
            this.SP_SoLuong.DataPropertyName = "SoLuong";
            this.SP_SoLuong.HeaderText = "Số lượng";
            this.SP_SoLuong.Name = "SP_SoLuong";
            this.SP_SoLuong.ReadOnly = true;
            // 
            // SP_Gia
            // 
            this.SP_Gia.DataPropertyName = "Gia";
            this.SP_Gia.HeaderText = "Đơn giá";
            this.SP_Gia.Name = "SP_Gia";
            this.SP_Gia.ReadOnly = true;
            // 
            // SP_IMEI
            // 
            this.SP_IMEI.DataPropertyName = "IMEI";
            this.SP_IMEI.HeaderText = "IMEI";
            this.SP_IMEI.Name = "SP_IMEI";
            this.SP_IMEI.ReadOnly = true;
            this.SP_IMEI.Visible = false;
            // 
            // SP_IDHD
            // 
            this.SP_IDHD.DataPropertyName = "IDHD";
            this.SP_IDHD.HeaderText = "IDHD";
            this.SP_IDHD.Name = "SP_IDHD";
            this.SP_IDHD.ReadOnly = true;
            this.SP_IDHD.Visible = false;
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Location = new System.Drawing.Point(104, 650);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(246, 59);
            this.btnHoanThanh.TabIndex = 51;
            this.btnHoanThanh.Text = "Cập nhật thông tin phiếu trả";
            this.btnHoanThanh.UseVisualStyleBackColor = true;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // IDHoaDon
            // 
            this.IDHoaDon.DataPropertyName = "IDHoaDon";
            this.IDHoaDon.HeaderText = "Mã hóa đơn";
            this.IDHoaDon.Name = "IDHoaDon";
            this.IDHoaDon.ReadOnly = true;
            // 
            // IDSP
            // 
            this.IDSP.DataPropertyName = "IDSP";
            this.IDSP.HeaderText = "Mã sản phẩm";
            this.IDSP.Name = "IDSP";
            this.IDSP.ReadOnly = true;
            // 
            // IDDoiTra
            // 
            this.IDDoiTra.DataPropertyName = "IDDoiTra";
            this.IDDoiTra.HeaderText = "IDDoiTra";
            this.IDDoiTra.Name = "IDDoiTra";
            this.IDDoiTra.ReadOnly = true;
            this.IDDoiTra.Visible = false;
            // 
            // IMEI
            // 
            this.IMEI.DataPropertyName = "IMEI";
            this.IMEI.HeaderText = "Số IMEI";
            this.IMEI.Name = "IMEI";
            this.IMEI.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.Name = "LyDo";
            this.LyDo.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Column1";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Visible = false;
            // 
            // fSuaChiTietPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 727);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.txtSP_MaSP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nmDonGia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSP_LyDo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.cbIMEI);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSP_TenSP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtIDHD);
            this.Controls.Add(this.dtgvSP);
            this.Controls.Add(this.btnLayThongTinHD);
            this.Controls.Add(this.dtgvHD);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnSuaSP);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIMEI);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvDSSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaPT);
            this.Name = "fSuaChiTietPhieuTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa chi tiết phiếu trả";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDSSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtIMEI;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSP_MaSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmDonGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSP_LyDo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.ComboBox cbIMEI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSP_TenSP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIDHD;
        private System.Windows.Forms.DataGridView dtgvSP;
        private System.Windows.Forms.Button btnLayThongTinHD;
        private System.Windows.Forms.DataGridView dtgvHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThucTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD_ThueGTGT;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn SP_IDSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SP_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SP_DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SP_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SP_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SP_IMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SP_IDHD;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDoiTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}