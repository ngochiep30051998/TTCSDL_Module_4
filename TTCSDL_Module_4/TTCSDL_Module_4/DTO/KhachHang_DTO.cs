using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL_Module_4.DTO
{
    public class KhachHang_DTO
    {
        public int IDKH { get; set; }
        public string TenKH { get; set; }
        public string TenDV { get; set; }
        public string MaSoThue { get; set; }
        public string DiaChi { get; set; }
        public string SoTK { get; set; }
        public string SoDT { get; set; }
        public KhachHang_DTO()
        {
            IDKH = 0;
            TenKH = "";
            TenDV = "";
            MaSoThue = "";
            DiaChi = "";
            SoTK = "";
            SoDT = "";
        }
        public KhachHang_DTO(DataRow data)
        {
            IDKH = Convert.ToInt32(data["IDKH"]);
            TenKH = data["TenKH"].ToString();
            TenDV = data["TenDV"].ToString();
            MaSoThue = data["MaSoThue"].ToString();
            DiaChi = data["DiaChi"].ToString();
            SoTK = data["SoTK"].ToString();
            SoDT = data["SoDT"].ToString();
        }
    }
}
