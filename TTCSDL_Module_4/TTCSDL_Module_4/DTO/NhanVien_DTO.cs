using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL_Module_4.DTO
{
    public class NhanVien_DTO
    {
        public int IDNV { get; set; }
        public string TenNV { get; set; }
        public NhanVien_DTO()
        {
            IDNV = 0;
            TenNV = "";
        }
        public NhanVien_DTO(DataRow data)
        {
            IDNV = (int)data["IDNV"];
            TenNV = data["TenNV"].ToString();
        }
    }
}
