namespace TTCSDL_Module_4
{
    partial class fBaoCao
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DoiTra_LayPhieuDoiTraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetDoiTra = new TTCSDL_Module_4.DataSetDoiTra();
            this.rpDoiTra = new Microsoft.Reporting.WinForms.ReportViewer();
            this.doiTra_LayPhieuDoiTraTableAdapter1 = new TTCSDL_Module_4.DataSetDoiTraTableAdapters.DoiTra_LayPhieuDoiTraTableAdapter();
            this.DoiTra_LayPhieuDoiTraTableAdapter = new TTCSDL_Module_4.DataSetDoiTraTableAdapters.DoiTra_LayPhieuDoiTraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DoiTra_LayPhieuDoiTraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDoiTra)).BeginInit();
            this.SuspendLayout();
            // 
            // DoiTra_LayPhieuDoiTraBindingSource
            // 
            this.DoiTra_LayPhieuDoiTraBindingSource.DataMember = "DoiTra_LayPhieuDoiTra";
            this.DoiTra_LayPhieuDoiTraBindingSource.DataSource = this.DataSetDoiTra;
            // 
            // DataSetDoiTra
            // 
            this.DataSetDoiTra.DataSetName = "DataSetDoiTra";
            this.DataSetDoiTra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpDoiTra
            // 
            this.rpDoiTra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DoiTra_LayPhieuDoiTraBindingSource;
            this.rpDoiTra.LocalReport.DataSources.Add(reportDataSource1);
            this.rpDoiTra.LocalReport.ReportEmbeddedResource = "TTCSDL_Module_4.ReportDoiTra.rdlc";
            this.rpDoiTra.Location = new System.Drawing.Point(3, 4);
            this.rpDoiTra.Name = "rpDoiTra";
            this.rpDoiTra.ServerReport.BearerToken = null;
            this.rpDoiTra.Size = new System.Drawing.Size(1028, 631);
            this.rpDoiTra.TabIndex = 0;
            // 
            // doiTra_LayPhieuDoiTraTableAdapter1
            // 
            this.doiTra_LayPhieuDoiTraTableAdapter1.ClearBeforeFill = true;
            // 
            // DoiTra_LayPhieuDoiTraTableAdapter
            // 
            this.DoiTra_LayPhieuDoiTraTableAdapter.ClearBeforeFill = true;
            // 
            // fBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 636);
            this.Controls.Add(this.rpDoiTra);
            this.Name = "fBaoCao";
            this.Text = "Phiếu đổi trả";
            this.Load += new System.EventHandler(this.fBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoiTra_LayPhieuDoiTraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDoiTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpDoiTra;
        private DataSetDoiTraTableAdapters.DoiTra_LayPhieuDoiTraTableAdapter doiTra_LayPhieuDoiTraTableAdapter1;
        private System.Windows.Forms.BindingSource DoiTra_LayPhieuDoiTraBindingSource;
        private DataSetDoiTra DataSetDoiTra;
        private DataSetDoiTraTableAdapters.DoiTra_LayPhieuDoiTraTableAdapter DoiTra_LayPhieuDoiTraTableAdapter;
    }
}