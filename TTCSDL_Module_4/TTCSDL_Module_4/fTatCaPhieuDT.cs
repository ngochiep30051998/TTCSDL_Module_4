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
        int tempIDKH = 0;
        public fTatCaPhieuDT()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            dtgvDSPT.DataSource = DoiTra_DAO.Instance.TimKiemPhieuDT("");
            dtgvCTPT.DataSource = DanhSachSP;
            loadCBNhanVien(cbNhanVien);
        }
        void loadCBNhanVien(ComboBox cb)
        {
            cb.DataSource = DoiTra_DAO.Instance.LayTatCaNV();
            cb.DisplayMember = "TenNV";
            cb.ValueMember = "IDNV";
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
                txtMaPT.Text = dr.Cells["IDDoiTra"].Value.ToString();
                txtTenKH.Text = dr.Cells["TenKH"].Value.ToString();
                tempIDKH = Convert.ToInt32(dr.Cells["IDKH"].Value);
                dtpkNgayDoi.Value = Convert.ToDateTime(dr.Cells["NgayDoi"].Value);
                cbNhanVien.SelectedValue = dr.Cells["IDNV"].Value;
                DanhSachSP.DataSource = DoiTra_DAO.Instance.LayChiTietPT(IDDoiTra);
            } catch(Exception ex)
            {
                return;
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
                var xacnhan = MessageBox.Show("bạn có chắc chắn muốn xóa phiếu số : " + txtMaPT.Text, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(xacnhan == DialogResult.Yes)
                {
                    int xoa = DoiTra_DAO.Instance.XoaPhieuTra(Convert.ToInt32(txtMaPT.Text));
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

        private void btnCapNhatPhieuTra_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTenKH.Text == "" || txtMaPT.Text == "")
                {
                    MessageBox.Show("Phải điền đủ thông tin");
                    return;
                }
                int CapNhat = DoiTra_DAO.Instance.CapNhatPhieuTra(Convert.ToInt32(txtMaPT.Text), dtpkNgayDoi.Value, tempIDKH, txtTenKH.Text, Convert.ToInt32(cbNhanVien.SelectedValue));
                if(CapNhat == 0)
                {
                    MessageBox.Show("không thể cập nhật");
                    return;
                }
                else
                {
                    MessageBox.Show("cập nhật thành công");
                    load();
                    dtgvCTPT.Rows.Clear();
                    dtgvCTPT.Refresh();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            if(txtMaPT.Text == "")
            {
                MessageBox.Show("phải chọn ít nhất 1 phiếu để in!");
                return;
            }
            string LyDo = "";
            foreach(DataGridViewRow row in dtgvCTPT.Rows)
            {
                if(row.Cells["CT_IMEI"].Value != null)
                {
                    LyDo = LyDo + "Sản phẩm: " + row.Cells["TenSP"].Value + " - Mã IMEI:  " + row.Cells["CT_IMEI"].Value + " - Lý do:  " + row.Cells["CT_LyDo"].Value + Environment.NewLine;
                }
            }
            fBaoCao f = new fBaoCao(Convert.ToInt32(txtMaPT.Text),LyDo);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSuaChiTiet_Click(object sender, EventArgs e)
        {
            if(txtMaPT.Text == "")
            {
                MessageBox.Show("phải chọn ít nhất 1 phiếu trả!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fSuaChiTietPhieuTra f = new fSuaChiTietPhieuTra(Convert.ToInt32(txtMaPT.Text));
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
