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
    public partial class fKhachHang : Form
    {
        BindingSource DSKH = new BindingSource();
        public fKhachHang()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            dtgvKhachHang.DataSource = DSKH;
            DSKH.DataSource = KhachHang_DAO.Instance.LayTatcaKH();
            Binding();
        }
        public void Binding()
        {
            txtMaKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "IDKH", true, DataSourceUpdateMode.Never));
            txtTenKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "TenKH", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "SoDT", true, DataSourceUpdateMode.Never));
            txtTenDV.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "TenDV", true, DataSourceUpdateMode.Never));
            txtSoTK.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "SoTK", true, DataSourceUpdateMode.Never));
            txtMaSoThue.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "MaSoThue", true, DataSourceUpdateMode.Never));
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DSKH.DataSource = KhachHang_DAO.Instance.TimKiemKH(txtTimKiem.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaKH.Text == "")
            {
                MessageBox.Show("phải chọn 1 khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var xacnhan = MessageBox.Show("bạn có chắc chắn muốn xóa khách hàng : " + txtTenKH.Text, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(xacnhan == DialogResult.Yes)
            {
                int xoaKH = KhachHang_DAO.Instance.XoaKH(Convert.ToInt32(txtMaKH.Text));
                if (xoaKH > 0) {
                    MessageBox.Show("xóa thành công");
                    DSKH.DataSource = KhachHang_DAO.Instance.LayTatcaKH();
                }
                else
                {
                    MessageBox.Show("Không thể xóa");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtTenDV.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtSoTK.Text = "";
            txtMaSoThue.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenKH.Text == "")
            {
                MessageBox.Show("Tên khách hàng là bắt buộc", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtMaKH.Text != "")
            {
                MessageBox.Show("Khách hàng đã tồn tại, vui lòng chọn cập nhật nếu muốn cập nhật thông tin khách hàng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int themKH = KhachHang_DAO.Instance.ThemKH(txtTenKH.Text, txtTenDV.Text, txtMaSoThue.Text, txtDiaChi.Text, txtSoTK.Text, txtSDT.Text);
            if(themKH > 0)
            {
                MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                DSKH.DataSource = KhachHang_DAO.Instance.LayTatcaKH();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Tên khách hàng là bắt buộc", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int SuaKH = KhachHang_DAO.Instance.SuaKH(Convert.ToInt32(txtMaKH.Text), txtTenKH.Text, txtTenDV.Text, txtMaSoThue.Text, txtDiaChi.Text, txtSoTK.Text, txtSDT.Text);
            if (SuaKH > 0)
            {
                MessageBox.Show("Sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                DSKH.DataSource = KhachHang_DAO.Instance.LayTatcaKH();
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
