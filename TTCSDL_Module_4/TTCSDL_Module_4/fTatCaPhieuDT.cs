using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTCSDL_Module_4.DAO;

namespace TTCSDL_Module_4
{
    public partial class fTatCaPhieuDT : Form
    {
        BindingSource DanhSachSP = new BindingSource();
        public fTatCaPhieuDT()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            dtgvDSPT.DataSource = DoiTra_DAO.Instance.TimKiemPhieuDT("");
            dtgvCTPT.DataSource = DanhSachSP;
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            fDoiTra f = new fDoiTra();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void dtgvDSPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dtgvDSPT.Rows[index];
                int IDDoiTra = Convert.ToInt32(dr.Cells["IDDoiTra"].Value);
                DanhSachSP.DataSource = DoiTra_DAO.Instance.LayChiTietPT(IDDoiTra);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
