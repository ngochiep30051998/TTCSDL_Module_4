using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL_Module_4.DTO
{
    public class HoaDon_DTO
    {
        public int IDHD { get; set; }
        public DateTime NgayLapHD { get; set; }
        public int IDKH { get; set; }
        public int IDNV { get; set; }
        public string HinhThucTT { get; set; }
        public decimal ThueGTGT { get; set; }
        public string TenKH { get; set; }
        public string TenNV { get; set; }
        public HoaDon_DTO()
        {
            IDHD = 0;
            NgayLapHD = DateTime.Now;
            IDKH = 0;
            IDNV = 0;
            HinhThucTT = "";
            TenKH = "";
            TenNV = "";
            ThueGTGT = 0;
        }
        public HoaDon_DTO(DataRow data)
        {
            IDHD = Convert.ToInt32(data["IDHD"]);
            NgayLapHD = Convert.ToDateTime(data["NgayLapHD"]);
            IDKH = Convert.ToInt32(data["IDKH"]);
            IDNV = Convert.ToInt32(data["IDNV"]);
            HinhThucTT = data["HinhThucTT"].ToString();
            TenKH = data["TenKH"].ToString();
            TenNV = data["TenNV"].ToString();
            ThueGTGT = Convert.ToDecimal(data["ThueGTGT"]);
        }
    }
}
