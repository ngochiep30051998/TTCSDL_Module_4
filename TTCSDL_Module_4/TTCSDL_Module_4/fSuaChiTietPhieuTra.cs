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
using TTCSDL_Module_4.DTO;

namespace TTCSDL_Module_4
{
    public partial class fSuaChiTietPhieuTra : Form
    {
        int IDPT;
        string LyDoCu;
        List<CTDoiTra_DTO> DSSP = new List<CTDoiTra_DTO>();
        BindingSource listSP = new BindingSource();
        BindingSource DanhSachHD = new BindingSource();
        public fSuaChiTietPhieuTra(int MaPhieuTra)
        {
            this.IDPT = MaPhieuTra;
            InitializeComponent();
            LayChiTietPhieuTra();
        }

        void LayChiTietPhieuTra()
        {
            DSSP = DoiTra_DAO.Instance.LayChiTietPT(this.IDPT);
            dtgvDSSP.DataSource = listSP;
            listSP.DataSource = DoiTra_DAO.Instance.LayChiTietPT(this.IDPT);
            dtgvHD.DataSource = DanhSachHD;
            DanhSachHD.DataSource = DoiTra_DAO.Instance.TimKiemHD("");
            txtMaPT.Text = this.IDPT.ToString();
            binđingSP();
            txtIDHD.DataBindings.Add(new Binding("Text", dtgvHD.DataSource, "IDHD", true, DataSourceUpdateMode.Never));
        }
        void binđingSP()
        {
            txtIMEI.DataBindings.Add(new Binding("Text", dtgvDSSP.DataSource, "IMEI", true, DataSourceUpdateMode.Never));
            txtMaSP.DataBindings.Add(new Binding("Text", dtgvDSSP.DataSource, "IDSP", true, DataSourceUpdateMode.Never));
            txtTenSP.DataBindings.Add(new Binding("Text", dtgvDSSP.DataSource, "TenSP", true, DataSourceUpdateMode.Never));
            txtLyDo.DataBindings.Add(new Binding("Text", dtgvDSSP.DataSource, "LyDo", true, DataSourceUpdateMode.Never));
        }
        private void dtgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dtgvDSSP.Rows[index];
                //txtMaSP.Text = dr.Cells["IDSP"].Value.ToString();
                //txtIMEI.Text = dr.Cells["IMEI"].Value.ToString();
                //txtTenSP.Text = dr.Cells["TenSP"].Value.ToString();
                //txtLyDo.Text = dr.Cells["LyDo"].Value.ToString();
                this.LyDoCu = dr.Cells["LyDo"].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            CTDoiTra_DTO ct = DSSP.Single(x => x.IMEI == txtIMEI.Text);
            ct.LyDo = txtLyDo.Text;
            listSP.DataSource = typeof(List<CTDoiTra_DTO>);
            listSP.DataSource = DSSP;
            dtgvDSSP.DataSource = listSP;
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
           var xacnhanh =  MessageBox.Show("bạn có chắc chắn muốn xóa sản phẩm có mã IMEI là: " + txtIMEI.Text,"Thông báo!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(xacnhanh == DialogResult.Yes)
            {
                if(DSSP.Count > 0)
                {
                    CTDoiTra_DTO ct = DSSP.Single(x => x.IMEI == txtIMEI.Text);
                    DSSP.Remove(ct);
                    listSP.DataSource = typeof(List<CTDoiTra_DTO>);
                    listSP.DataSource = DSSP;
                    dtgvDSSP.DataSource = listSP;
                }
            } 

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DanhSachHD.DataSource = DoiTra_DAO.Instance.TimKiemHD(txtTimKiem.Text);
        }

        private void btnLayThongTinHD_Click(object sender, EventArgs e)
        {
            if (txtIDHD.Text == "")
            {
                MessageBox.Show("Phải nhập mã hóa đơn để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dtgvSP.DataSource = DoiTra_DAO.Instance.LaySanPhamTheoHD(Convert.ToInt32(txtIDHD.Text));
        }

        private void dtgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dtgvSP.Rows[index];
                txtSP_TenSP.Text = dr.Cells["SP_TenSP"].Value.ToString();
                txtSP_MaSP.Text = dr.Cells["SP_IDSP"].Value.ToString();
                nmDonGia.Value = Convert.ToDecimal(dr.Cells["SP_Gia"].Value);
                string[] arrIMEI = dr.Cells["SP_IMEI"].Value.ToString().Split(' ');
                Array.Reverse(arrIMEI);
                cbIMEI.DataSource = arrIMEI;
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (txtSP_LyDo.Text == "")
            {
                MessageBox.Show("Bạn phải nhập lý do đổi trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbIMEI.Text == "")
            {
                MessageBox.Show("Mã IMEI không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                foreach (DataGridViewRow row in dtgvDSSP.Rows)
                {
                    if (dtgvDSSP.Rows.Count > 1 && cbIMEI.SelectedValue.ToString().Equals(row.Cells["IMEI"].Value))
                    {
                        //var a = row.Cells["PT_IMEI"].Value;
                        MessageBox.Show("Mã IMEI đã có trong danh sách đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                CTDoiTra_DTO ChiTiet_DT = new CTDoiTra_DTO();
                ChiTiet_DT.IDHoaDon = Convert.ToInt32(txtIDHD.Text);
                ChiTiet_DT.IDSP = Convert.ToInt32(txtSP_MaSP.Text);
                ChiTiet_DT.TenSP = txtSP_TenSP.Text;
                ChiTiet_DT.Gia = nmDonGia.Value;
                ChiTiet_DT.LyDo = txtSP_LyDo.Text;
                ChiTiet_DT.SoLuong = 1;
                ChiTiet_DT.IMEI = cbIMEI.SelectedValue.ToString();
                listSP.DataSource = typeof(List<CTDoiTra_DTO>);
                DSSP.Add(ChiTiet_DT);
                listSP.Add(ChiTiet_DT);
                dtgvDSSP.DataSource = DSSP;
                dtgvDSSP.Refresh();
            }

        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            try
            {
                int capnhap = DoiTra_DAO.Instance.SuaPhieuTra(DSSP, Convert.ToInt32(txtMaPT.Text));
                if(capnhap == 1)
                {
                    MessageBox.Show("cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                } else
                {
                    MessageBox.Show("cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
