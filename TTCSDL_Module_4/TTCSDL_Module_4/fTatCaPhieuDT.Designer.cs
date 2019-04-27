namespace TTCSDL_Module_4
{
    partial class fTatCaPhieuDT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvDSPT = new System.Windows.Forms.DataGridView();
            this.dtgvCTPT = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemPhieu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoaPT = new System.Windows.Forms.Button();
            this.CT_IDDoiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_IDHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_IMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.IDDoiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTPT)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDSPT
            // 
            this.dtgvDSPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSPT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvDSPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDoiTra,
            this.TenKH,
            this.NgayDoi,
            this.IDKH,
            this.IDNV,
            this.TenNV});
            this.dtgvDSPT.Location = new System.Drawing.Point(12, 65);
            this.dtgvDSPT.Name = "dtgvDSPT";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDSPT.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDSPT.Size = new System.Drawing.Size(689, 375);
            this.dtgvDSPT.TabIndex = 0;
            this.dtgvDSPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSPT_CellClick);
            // 
            // dtgvCTPT
            // 
            this.dtgvCTPT.AllowUserToResizeColumns = false;
            this.dtgvCTPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCTPT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvCTPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CT_IDDoiTra,
            this.IDSP,
            this.TenSP,
            this.CT_IDHoaDon,
            this.CT_SoLuong,
            this.CT_LyDo,
            this.CT_IMEI});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCTPT.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvCTPT.Location = new System.Drawing.Point(721, 65);
            this.dtgvCTPT.Name = "dtgvCTPT";
            this.dtgvCTPT.Size = new System.Drawing.Size(585, 375);
            this.dtgvCTPT.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(12, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(257, 20);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(284, 6);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(74, 30);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "DANH SÁCH PHIẾU TRẢ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(718, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "DANH SÁCH SẢN PHẨM TRẢ";
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.Location = new System.Drawing.Point(626, 6);
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(75, 56);
            this.btnThemPhieu.TabIndex = 6;
            this.btnThemPhieu.Text = "Thêm phiếu";
            this.btnThemPhieu.UseVisualStyleBackColor = true;
            this.btnThemPhieu.Click += new System.EventHandler(this.btnThemPhieu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1231, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "In phiếu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnXoaPT
            // 
            this.btnXoaPT.Location = new System.Drawing.Point(545, 6);
            this.btnXoaPT.Name = "btnXoaPT";
            this.btnXoaPT.Size = new System.Drawing.Size(75, 56);
            this.btnXoaPT.TabIndex = 8;
            this.btnXoaPT.Text = "Xóa phiếu trả";
            this.btnXoaPT.UseVisualStyleBackColor = true;
            this.btnXoaPT.Click += new System.EventHandler(this.btnXoaPT_Click);
            // 
            // CT_IDDoiTra
            // 
            this.CT_IDDoiTra.DataPropertyName = "IDDoiTra";
            this.CT_IDDoiTra.HeaderText = "Mã phiếu trả";
            this.CT_IDDoiTra.Name = "CT_IDDoiTra";
            this.CT_IDDoiTra.Visible = false;
            // 
            // IDSP
            // 
            this.IDSP.DataPropertyName = "IDSP";
            this.IDSP.HeaderText = "Mã sản phẩm";
            this.IDSP.Name = "IDSP";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // CT_IDHoaDon
            // 
            this.CT_IDHoaDon.DataPropertyName = "IDHoaDon";
            this.CT_IDHoaDon.HeaderText = "Mã hóa đơn mua";
            this.CT_IDHoaDon.Name = "CT_IDHoaDon";
            this.CT_IDHoaDon.Visible = false;
            // 
            // CT_SoLuong
            // 
            this.CT_SoLuong.DataPropertyName = "SoLuong";
            this.CT_SoLuong.HeaderText = "Số lượng";
            this.CT_SoLuong.Name = "CT_SoLuong";
            // 
            // CT_LyDo
            // 
            this.CT_LyDo.DataPropertyName = "LyDo";
            this.CT_LyDo.HeaderText = "Lý do";
            this.CT_LyDo.Name = "CT_LyDo";
            // 
            // CT_IMEI
            // 
            this.CT_IMEI.DataPropertyName = "IMEI";
            this.CT_IMEI.HeaderText = "IMEI";
            this.CT_IMEI.Name = "CT_IMEI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "THÔNG TIN PHIẾU TRẢ";
            // 
            // IDDoiTra
            // 
            this.IDDoiTra.DataPropertyName = "IDDoiTra";
            this.IDDoiTra.HeaderText = "Mã phiếu trả";
            this.IDDoiTra.Name = "IDDoiTra";
            this.IDDoiTra.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Khách hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // NgayDoi
            // 
            this.NgayDoi.DataPropertyName = "NgayDoi";
            this.NgayDoi.HeaderText = "Ngày đổi";
            this.NgayDoi.Name = "NgayDoi";
            this.NgayDoi.ReadOnly = true;
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
            this.IDNV.Visible = false;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Nhân viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 462);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã phiếu trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày trả";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(316, 462);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tên khách hàng";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 505);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(410, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 544);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nhân viên";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 541);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(410, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // fTatCaPhieuDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 632);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXoaPT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThemPhieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dtgvCTPT);
            this.Controls.Add(this.dtgvDSPT);
            this.Name = "fTatCaPhieuDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách phiếu đổi";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDSPT;
        private System.Windows.Forms.DataGridView dtgvCTPT;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemPhieu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXoaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_IDDoiTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_IDHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_IMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDoiTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}