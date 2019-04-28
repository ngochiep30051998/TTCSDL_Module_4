using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TTCSDL_Module_4.DAO;

namespace TTCSDL_Module_4
{
    public partial class fBaoCao : Form
    {
        int IDPhieuDoi;
        string TenKH;
        string NgayDoi;
        string SoDT;
        string TongTien;
        string LyDoDoiTra;
        string TenNV;
        public fBaoCao(int id,string LyDo)
        {
            InitializeComponent();
            IDPhieuDoi = id;
            TenKH = MauBieu_DAO.Instance.LayTenKhachHang(id);
            NgayDoi = MauBieu_DAO.Instance.LayNgayDoi(id);
            SoDT = MauBieu_DAO.Instance.LaySDTKH(id);
            TongTien = MauBieu_DAO.Instance.LayTongTien(id);
            TenNV = MauBieu_DAO.Instance.LayTenNV(id);
            LyDoDoiTra = LyDo;
        }

        private void fBaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetDoiTra.DoiTra_LayPhieuDoiTra' table. You can move, or remove it, as needed.
            ReportParameterCollection reportParam = new ReportParameterCollection();
            reportParam.Add(new ReportParameter("TenKH", TenKH));
            reportParam.Add(new ReportParameter("IDDonHang", "1"));
            reportParam.Add(new ReportParameter("NgayNhanHang", NgayDoi));
            reportParam.Add(new ReportParameter("SDT", SoDT));
            reportParam.Add(new ReportParameter("TongTien", TongTien));
            decimal VAT = Convert.ToDecimal(TongTien)/10 ;
            decimal TongThanhToan = Convert.ToDecimal(TongTien) - VAT;
            reportParam.Add(new ReportParameter("VAT", VAT.ToString()));
            reportParam.Add(new ReportParameter("TongThanhToan", TongThanhToan.ToString()));
            reportParam.Add(new ReportParameter("LyDo", LyDoDoiTra));
            reportParam.Add(new ReportParameter("TenNV", TenNV));
            reportParam.Add(new ReportParameter("TGNhanPhieu", DateTime.Now.ToString()));
            this.rpDoiTra.LocalReport.SetParameters(reportParam);
            this.DoiTra_LayPhieuDoiTraTableAdapter.Fill(this.DataSetDoiTra.DoiTra_LayPhieuDoiTra, IDPhieuDoi);
            this.rpDoiTra.RefreshReport();

        }
    }
}
