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
        int tempIDPT = 0;
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
                tempIDPT = IDDoiTra;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvDSPT.DataSource = DoiTra_DAO.Instance.TimKiemPhieuDT(txtTimKiem.Text);
        }

        private void btnXoaPT_Click(object sender, EventArgs e)
        {
            try
            {
                var xacnhan = MessageBox.Show("bạn có chắc chắn muốn xóa phiếu số : " + tempIDPT, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(xacnhan == DialogResult.Yes)
                {
                    int xoa = DoiTra_DAO.Instance.XoaPhieuTra(tempIDPT);
                    if (xoa == 0)
                    {
                        MessageBox.Show("xóa thất bại");

                    }
                    else
                    {
                        MessageBox.Show("Xóa thành công");
                        load();
                        dtgvCTPT.Rows.Clear();
                        dtgvCTPT.Refresh();
                    }
                }
                else
                {
                    return;
                }
 
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
