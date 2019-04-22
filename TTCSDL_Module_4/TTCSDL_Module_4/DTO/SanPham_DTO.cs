using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL_Module_4.DTO
{
    public class SanPham_DTO
    {
        public int IDSP { get; set; }
        public string TenSP { get; set; }
        public string DVT { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
        public string IMEI { get; set; }
        public SanPham_DTO()
        {
            IDSP = 0;
            TenSP = "";
            DVT = "";
            Gia = 0;
            SoLuong = 0;
            IMEI = "";
        }
        public SanPham_DTO(DataRow data)
        {
            IDSP = Convert.ToInt32(data["IDSP"]);
            TenSP = data["TenSP"].ToString();
            DVT = data["DVT"].ToString();
            Gia = Convert.ToDecimal(data["Gia"]);
            SoLuong = Convert.ToInt32(data["SoLuong"]);
            IMEI = data["IMEI"].ToString();
        }
    }
}
