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
    public partial class fDoiTra : Form
    {
        BindingSource DanhSachHD = new BindingSource();
        BindingSource DanhSachPT = new BindingSource();
        //public List<CTDoiTra_DTO> DanhSachPT = new List<CTDoiTra_DTO>();
        public string tempIMEI;
        int tempIndex;
        List<CTDoiTra_DTO> listDT = new List<CTDoiTra_DTO>();
        public fDoiTra()
        {
            InitializeComponent();
            loadAll();
            txtIDHD.DataBindings.Add(new Binding("Text", dtgvHD.DataSource, "IDHD", true, DataSourceUpdateMode.Never));
        }
        void loadAll()
        {
            dtgvHD.DataSource = DanhSachHD;
            //dtgvDSDT.DataSource = typeof(List<CTDoiTra_DTO>);
            dtgvDSDT.DataSource = DanhSachPT;
            DanhSachHD.DataSource = DoiTra_DAO.Instance.TimKiemHD("");
            loadCBNhanVien(cbNhanVien);

        }
        void loadCBNhanVien(ComboBox cb)
        {
            cb.DataSource = DoiTra_DAO.Instance.LayTatCaNV();
            cb.DisplayMember = "TenNV";
            cb.ValueMember = "IDNV";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DanhSachHD.DataSource = DoiTra_DAO.Instance.TimKiemHD(txtTimKiem.Text);
        }

        private void btnLayThongTinHD_Click(object sender, EventArgs e)
        {
            if(txtIDHD.Text == "")
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
                txtTenSP.Text = dr.Cells["TenSP"].Value.ToString();
                txtMaSP.Text = dr.Cells["SP_IDSP"].Value.ToString();
                nmDonGia.Value = Convert.ToDecimal(dr.Cells["Gia"].Value);
                string[] arrIMEI = dr.Cells["IMEI"].Value.ToString().Split(' ');
                Array.Reverse(arrIMEI);
                cbIMEI.DataSource = arrIMEI;
            } catch(Exception ex)
            {
                return;
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if(txtLyDo.Text == "")
            {
                MessageBox.Show("Đổi trả thì phải có lí do chứ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbIMEI.Text == "")
            {
                MessageBox.Show("Mã IMEI không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                
                foreach (DataGridViewRow row in dtgvDSDT.Rows)
                {
                    if (dtgvDSDT.Rows.Count> 1 && cbIMEI.SelectedValue.ToString().Equals(row.Cells["PDT_IMEI"].Value))
                    {
                        //var a = row.Cells["PT_IMEI"].Value;
                        MessageBox.Show("Mã IMEI đã có trong danh sách đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                CTDoiTra_DTO ChiTiet_DT = new CTDoiTra_DTO();
                ChiTiet_DT.IDHoaDon = Convert.ToInt32(txtIDHD.Text);
                ChiTiet_DT.IDSP = Convert.ToInt32(txtMaSP.Text);
                ChiTiet_DT.TenSP = txtTenSP.Text;
                ChiTiet_DT.Gia = nmDonGia.Value;
                ChiTiet_DT.LyDo = txtLyDo.Text;
                ChiTiet_DT.SoLuong = 1;
                ChiTiet_DT.IMEI = cbIMEI.SelectedValue.ToString();
                DanhSachPT.Add(ChiTiet_DT);
                listDT.Add(ChiTiet_DT);
                dtgvDSDT.DataSource = DanhSachPT;
            }
            
        }
        private void dtgvDSDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dtgvDSDT.Rows[index];
                tempIMEI = dr.Cells["PDT_IMEI"].Value.ToString();
                tempIndex = index;
            } catch(Exception ex)
            {
                tempIMEI = null;
                return;
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (tempIMEI == null)
                {
                    MessageBox.Show("Chọn ít nhất 1 sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm có mã IMEI là: " + tempIMEI, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        DanhSachPT.RemoveAt(tempIndex);
                        listDT.RemoveAt(tempIndex);
                        tempIndex = 0;
                        tempIMEI = null;
                        dtgvDSDT.DataSource = DanhSachPT;
                    }
                    else
                    {
                        return;
                    }
                }
            } catch(Exception ex)
            {
                return; 
            }

        }

        private void btnThemPT_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTenKH.Text == "" || txtSDT.Text == "")
                {
                    MessageBox.Show("nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string ThemPhieuDT = DoiTra_DAO.Instance.HoanThanh(listDT, dtpkNgayDoi.Value, txtTenKH.Text, Convert.ToInt32(cbNhanVien.SelectedValue), txtSDT.Text);
                MessageBox.Show("thêm thành công 1 phiếu đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                var XuatPhieu = MessageBox.Show("Bạn có muốn in phiếu vừa tạo ?", "In phiếu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(XuatPhieu == DialogResult.No)
                {
                    return;
                }
                else
                {
                    int idPhieuTra = MauBieu_DAO.Instance.LayIDPhieuDoiMoi();
                    string LyDo = "";
                    foreach (DataGridViewRow row in dtgvDSDT.Rows)
                    {
                        if (row.Cells["PDT_IMEI"].Value != null)
                        {
                            LyDo = LyDo + "Sản phẩm: " + row.Cells["PDT_TenSP"].Value + " - Mã IMEI:  " + row.Cells["PDT_IMEI"].Value + " - Lý do:  " + row.Cells["PDT_LyDo"].Value + Environment.NewLine;
                        }
                    }
                    fBaoCao f = new fBaoCao(idPhieuTra, LyDo);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = "";
            loadCBNhanVien(cbNhanVien);
            txtSDT.Text = "";
            dtpkNgayDoi.Value = DateTime.Now;
        }
    }
}
