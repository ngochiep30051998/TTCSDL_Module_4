using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL_Module_4.DTO
{
    public class DoiTra_DTO
    {
        public int IDDoiTra { get; set; }
        public DateTime NgayDoi { get; set; }
        public int IDKH { get; set; }
        public int IDNV { get; set; }
        public DoiTra_DTO()
        {
            IDDoiTra = 0;
            NgayDoi = DateTime.Now;
            IDKH = 0;
            IDNV = 0;
        }
        public DoiTra_DTO(DataRow data)
        {
            IDDoiTra = Convert.ToInt32(data["IDDoiTra"]);
            NgayDoi = Convert.ToDateTime(data["NgayDoi"]);
            IDKH = Convert.ToInt32(data["IDKH"]);
            IDNV = Convert.ToInt32(data["IDNV"]);
        }
    }
}
