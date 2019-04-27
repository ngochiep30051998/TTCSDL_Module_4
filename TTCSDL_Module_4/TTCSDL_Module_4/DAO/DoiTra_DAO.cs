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
                SPTheoHD.Add(sp);
            }
            return SPTheoHD;
        }
        public List<DoiTra_DTO> TimKiemPhieuDT(string Ten)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("TimKiemPT @TenKH", new object[] { Ten });
            List<DoiTra_DTO> DanhSachPT = new List<DoiTra_DTO>();
            foreach (DataRow item in data.Rows)
            {
                DoiTra_DTO hd = new DoiTra_DTO(item);
                DanhSachPT.Add(hd);
            }
            return DanhSachPT;
        }
        public List<CTDoiTra_DTO> LayChiTietPT(int IDDoiTra)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("TimKiemCTPT @IDPT", new object[] { IDDoiTra });
            List<CTDoiTra_DTO> DanhSachSP = new List<CTDoiTra_DTO>();
            foreach (DataRow item in data.Rows)
            {
                CTDoiTra_DTO hd = new CTDoiTra_DTO(item);
                DanhSachSP.Add(hd);
            }
            return DanhSachSP;
        }
        public int ThemKH(string TenKH,string SDT)
        {
            try
            {
                string query = string.Format("insert into KHACHHANG(TenKH,SoDT) values (N'{0}','{1}')", TenKH, SDT);
                return DataProvider.Instance.ExecuteNonQuery(query);
            } catch(Exception ex)
            {
                return -1;
            }
        }
        public int LayMaKH(string TenKH,string SoDT)
        {
            int id = 0;
            string QueryKH = string.Format("select IDKH from KHACHHANG where KHACHHANG.TenKH = N'{0}' and SoDT = {1}", TenKH, SoDT);
            DataTable data = DataProvider.Instance.ExecuteQuery(QueryKH);
            if(data.Rows.Count <= 0)
            {
                return 0;
            } else
            {
                foreach (DataRow item in data.Rows)
                {
                   id = Convert.ToInt32(item["IDKH"]);
                }
            }
            return id;
        }
        public int ThemPhieuDoiTra(DateTime NgayDoi,int IDKH,int IDNV)
        {
            try
            {
                string query = string.Format("insert into DOITRA (NgayDoi, IDKH,IDNV) values('{0}',{1},{2})", NgayDoi.ToShortDateString(), IDKH,IDNV);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int LayIDDoiTraMoi()
        {
            int id = 0;
            string Query = string.Format("select max(IDDoiTra) as IDDoiTra from DOITRA");
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            if (data.Rows.Count <= 0)
            {
                return 0;
            }
            else
            {
                foreach (DataRow item in data.Rows)
                {
                    id = Convert.ToInt32(item["IDDoiTra"]);
                }
            }
            return id;
        }
        public int ThemCTPhieuTra(List<CTDoiTra_DTO> DSPT,int IDDoitra)
        {
            try
            {
                foreach (CTDoiTra_DTO ct in DSPT)
                {
                    int insert = DataProvider.Instance.ExecuteNonQuery("ThemCTPhieuTra @IDDoiTra , @IDSP , @SoLuong , @LyDo , @IDHoaDon , @IMEI", 
                                                                        new object[] { IDDoitra, ct.IDSP, ct.SoLuong, ct.LyDo, ct.IDHoaDon, ct.IMEI });
                }
                return 1;
            } catch(Exception ex)
            {
                return 0;

            }
        }
        public string HoanThanh(List<CTDoiTra_DTO> DSPT,DateTime NgayDoi, string TenKH,int IDNV,string SoDT)
        {
            string ThongBaoLoi = "";
            try
            {
                int IDKHMoi;
                int MaKH = LayMaKH(TenKH, SoDT);
                if(MaKH == 0)
                {
                    ThemKH(TenKH, SoDT);
                    IDKHMoi = LayMaKH(TenKH, SoDT);
                    ThemPhieuDoiTra(NgayDoi, IDKHMoi, IDNV);
                }
                else
                {
                    ThemPhieuDoiTra(NgayDoi, MaKH, IDNV);
                }
                int IDDoiTraMoi = LayIDDoiTraMoi();
                ThemCTPhieuTra(DSPT, IDDoiTraMoi);
                return "success";
            } catch(Exception ex)
            {
                ThongBaoLoi = ex.Message;
                 return ThongBaoLoi;
            }
        }
        public List<NhanVien_DTO> LayTatCaNV()
        {
            List<NhanVien_DTO> DSNV = new List<NhanVien_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from nhanvien");
            foreach(DataRow item in data.Rows)
            {
                NhanVien_DTO NV = new NhanVien_DTO(item);
                DSNV.Add(NV);
            }
            return DSNV;
        }
        public int XoaPhieuTra(int id)
        {
            int xoa = DataProvider.Instance.ExecuteNonQuery("delete from DOITRA where IDDoiTra = " + id);
            if(xoa > 0)
            {
                return 1;

            }
            return 0;
        }
    }
}
