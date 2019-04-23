using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL_Module_4.DTO
{
    public class CTDoiTra_DTO
    {
        public string IMEI { get; set; }
        public string TenSP { get; set; }
        public Nullable<decimal> Gia { get; set; }
        public string LyDo { get; set; }

        public int IDDoitra { get; set; }
        public int IDSP { get; set; }
        public int IDHoaDon { get; set; }
        public int SoLuong { get; set; }
        public CTDoiTra_DTO()
        {
            IDDoitra = 0;
            IDHoaDon = 0;
            IDSP = 0;
            SoLuong = 0;
            Gia = null;
            LyDo = "";
            IMEI = "";
            TenSP = "";
        }
        public CTDoiTra_DTO(DataRow data)
        {
            IDDoitra = Convert.ToInt32(data["IDDoitra"]);
            IDHoaDon = Convert.ToInt32(data["IDHoaDon"]); 
            IDSP = Convert.ToInt32(data["IDSP"]); 
            SoLuong = Convert.ToInt32(data["SoLuong"]); 
            Gia =  Convert.ToInt32(data["Gia"]); 
            LyDo = data["LyDo"].ToString();
            IMEI = data["IMEI"].ToString();
            TenSP = data["TenSP"].ToString();
        }
    }
}
