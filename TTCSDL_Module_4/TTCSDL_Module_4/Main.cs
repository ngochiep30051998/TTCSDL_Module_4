using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCSDL_Module_4
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            fKhachHang f = new fKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThemPT_Click(object sender, EventArgs e)
        {
            fDoiTra f = new fDoiTra();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnQLDT_Click(object sender, EventArgs e)
        {
            fTatCaPhieuDT f = new fTatCaPhieuDT();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
