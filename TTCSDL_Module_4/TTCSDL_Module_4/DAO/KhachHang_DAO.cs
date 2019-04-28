using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTCSDL_Module_4.DTO;

namespace TTCSDL_Module_4.DAO
{
    public class KhachHang_DAO
    {
        private static KhachHang_DAO instance;
        public static KhachHang_DAO Instance
        {
            get { if (instance == null) instance = new KhachHang_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<KhachHang_DTO> LayTatcaKH()
        {
            List<KhachHang_DTO> DSKH = new List<KhachHang_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from khachhang");
            foreach(DataRow item in data.Rows)
            {
                KhachHang_DTO kh = new KhachHang_DTO(item);
                DSKH.Add(kh);
            }
            return DSKH;
        }
        public List<KhachHang_DTO> TimKiemKH(string param)
        {
            List<KhachHang_DTO> DSKH = new List<KhachHang_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("TimKiemKH @param", new object[] { param });
            foreach (DataRow item in data.Rows)
            {
                KhachHang_DTO kh = new KhachHang_DTO(item);
                DSKH.Add(kh);
            }
            return DSKH;
        }
        public int XoaKH(int id)
        {
            int xoa = DataProvider.Instance.ExecuteNonQuery("delete from KHACHHANG where IDKH = " + id);
            if (xoa > 0)
            {
                return xoa;
            }
            return 0;
        }
        public int ThemKH(string tenKH,string tenDV,string MaSoThue,string DiaChi,string SoTK,string soDT)
        {
            try
            {
                string query = string.Format("insert into KHACHHANG ( TenKH, TenDV, MaSoThue, DiaChi, SoTK,SoDT ) values(N'{0}','{1}','{2}',N'{3}','{4}','{5}')",tenKH,tenDV,MaSoThue,DiaChi,SoTK,soDT);
                int Them = DataProvider.Instance.ExecuteNonQuery(query);
                return 1;
            } catch(Exception ex)
            {
                return 0;
            }
        }
        public int SuaKH(int IDKH,string tenKH, string tenDV, string MaSoThue, string DiaChi, string SoTK, string soDT)
        {
            try
            {
                string query = string.Format("update KHACHHANG set TenKH = N'{0}', TenDV = N'{1}',MaSoThue = '{2}', DiaChi = N'{3}',SoTK = '{4}',SoDT = N'{5}' where IDKH = "+IDKH, tenKH, tenDV, MaSoThue, DiaChi, SoTK, soDT);
                int SuaKH = DataProvider.Instance.ExecuteNonQuery(query);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
