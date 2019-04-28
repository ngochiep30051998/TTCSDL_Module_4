using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL_Module_4.DAO
{
    public class MauBieu_DAO
    {
        private static MauBieu_DAO instance;
        public static MauBieu_DAO Instance
        {
            get { if (instance == null) instance = new MauBieu_DAO(); return instance; }
            private set { instance = value; }
        }
        public string LayTenKhachHang(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select TenKH from DOITRA,KHACHHANG where DOITRA.IDKH = KHACHHANG.IDKH and IDDoiTra = " + id);
            string TenKH = data.Rows[0]["TenKH"].ToString();
            return TenKH;
        }
        public string LayNgayDoi(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select NgayDoi from DOITRA where IDDoiTra = " + id);
            DateTime DataTime = Convert.ToDateTime(data.Rows[0]["NgayDoi"]);
            string NgayDoi = DataTime.ToShortDateString();
            return NgayDoi;
        }
        public string LaySDTKH(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select SoDT from DOITRA,KHACHHANG where DOITRA.IDKH = KHACHHANG.IDKH and IDDoiTra = " + id);
            string SoDT = data.Rows[0]["SoDT"].ToString();
            return SoDT;
        }
        public string LayTongTien(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select sum(CHITIETDOITRA.SoLuong*CHITIETHOADON.Gia) as TongTien from CHITIETDOITRA join CHITIETHOADON on CHITIETDOITRA.IDHoaDon = CHITIETHOADON.IDHD and CHITIETHOADON.IDSP = CHITIETDOITRA.IDSP where IDDoiTra = " + id);
            string TongTien = data.Rows[0]["TongTien"].ToString();
            return TongTien;
        }
        public string LayTenNV(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select TenNV from DOITRA,NHANVIEN where DOITRA.IDNV = NHANVIEN.IDNV and IDDoiTra =" + id);
            string TenNV = data.Rows[0]["TenNV"].ToString();
            return TenNV;
        }
        public int LayIDPhieuDoiMoi()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select max(IDDoiTra) as IDDoiTra from DOITRA");
            int id = Convert.ToInt32(data.Rows[0]["IDDoiTra"]);
            return id;
        }
    }
}
