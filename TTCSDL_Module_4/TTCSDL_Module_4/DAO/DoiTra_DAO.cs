using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTCSDL_Module_4.DTO;

namespace TTCSDL_Module_4.DAO
{
    public class DoiTra_DAO
    {
        private static DoiTra_DAO instance;
        public static DoiTra_DAO Instance
        {
            get { if (instance == null) instance = new DoiTra_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<HoaDon_DTO> TimKiemHD(string TenKH)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("TimKiemHD @TenKH",new object[] { TenKH });
            List<HoaDon_DTO> dsHoaDon = new List<HoaDon_DTO>();
            foreach(DataRow item in data.Rows)
            {
                HoaDon_DTO hd = new HoaDon_DTO(item);
                dsHoaDon.Add(hd);
            }
            return dsHoaDon;
        }
        public List<SanPham_DTO> LaySanPhamTheoHD(int IDHD)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SPTheoHD @IDHD",new object[] { IDHD });
            List<SanPham_DTO> SPTheoHD = new List<SanPham_DTO>();
            foreach(DataRow item in data.Rows)
            {
                SanPham_DTO sp = new SanPham_DTO(item);
                //string[] arrIMEI = sp.IMEI.Split(' ');
                //if (arrIMEI.Length > 1)
                //{
                //    foreach(string tempIEMI in arrIMEI)
                //    {
                //        if(tempIEMI.Length == 9)
                //        {
                //            SanPham_DTO tempSP = new SanPham_DTO(item);
                //            tempSP.IMEI = tempIEMI;
                //            SPTheoHD.Add(tempSP);
                //        }
                //    }
                //}
                //else
                //{
                //    SPTheoHD.Add(sp);
                //}
                SPTheoHD.Add(sp);
            }
            return SPTheoHD;
        }
    }
}
