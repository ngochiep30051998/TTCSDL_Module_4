﻿using System;
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

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvHD.DataSource = DoiTra_DAO.Instance.TimKiemHD(txtTimKiem.Text);
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
            if (cbIMEI.Text == "")
            {
                MessageBox.Show("Mã IMEI không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ChiTiet_DT.IMEI = cbIMEI.SelectedValue.ToString();
                DanhSachPT.Add(ChiTiet_DT);
                dtgvDSDT.DataSource = DanhSachPT;
            }
            
        }
        private void btnInPT_Click(object sender, EventArgs e)
        {

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
    }
}
