using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class PhieuNhap_DAL : DatabaseAccess2
    {
        public List<PhieuNhap_DTO> ThongTinPhieuNhap()
        {
            List<PhieuNhap_DTO> ttpn = new List<PhieuNhap_DTO>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PHIEUNHAP";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PhieuNhap_DTO pn = new PhieuNhap_DTO();
                pn.MaPN = reader.GetString(0);
                pn.NguonNhap = reader.GetString(1);
                pn.NgayNhap = reader.GetDateTime(2);
                pn.DiaChi = reader.GetString(3);
                pn.GhiChuNhap = reader.GetString(4);
                
                ttpn.Add(pn);
            }
            if (reader != null)
                reader.Close();
            return ttpn;
        }
  
        public bool ThemPhieuNhap(PhieuNhap_DTO pn)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into PHIEUNHAP values(@MaPN, @NguonNhap, @NgayNhap, @DiaChi, @GhiChuNhap)";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaPN", SqlDbType.VarChar).Value = pn.MaPN;
            cmd.Parameters.Add("@NguonNhap", SqlDbType.NVarChar).Value = pn.NguonNhap;
            cmd.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = pn.NgayNhap;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = pn.DiaChi;
            cmd.Parameters.Add("@GhiChuNhap", SqlDbType.NVarChar).Value = pn.GhiChuNhap;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
       
        public bool SuaPhieuNhap(PhieuNhap_DTO pn)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update PHIEUNHAP set  NGUON_NHAP=@NguonNhap, NGAY_NHAP=@NgayNhap, DIA_CHI=@DiaChi, GHI_CHU_NHAP= @GhiChuNhap where MA_PN=@MaPN";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaPN", SqlDbType.VarChar).Value = pn.MaPN;
            cmd.Parameters.Add("@NguonNhap", SqlDbType.NVarChar).Value = pn.NguonNhap;
            cmd.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = pn.NgayNhap;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = pn.DiaChi;
            cmd.Parameters.Add("@GhiChuNhap", SqlDbType.NVarChar).Value = pn.GhiChuNhap;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
  
        public bool XoaPhieuNhap(string MaPN)
        {

            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from PHIEUNHAP where MA_PN=@MaPN";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaPN", SqlDbType.NVarChar).Value = MaPN;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
        
        public List<HangHoa_DTO> autoDuLieu()
        {
            List<HangHoa_DTO> tthh = new List<HangHoa_DTO>();
            HangHoa_DTO hh = new HangHoa_DTO();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from HANGHOA where MA_HANG='" +hh.MaHang+"'" ;
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                hh.MaHang = reader.GetString(0);
                hh.TenHang = reader.GetString(1);
                
                tthh.Add(hh);
            }
            if (reader != null)
                reader.Close();
            return tthh;
        }

        public List<PhieuNhap_DTO> TimKiemPN(string mapn)
        {
            List<PhieuNhap_DTO> ttpn = new List<PhieuNhap_DTO>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PHIEUNHAP where MA_PN like N'%'+@MaPN+'%'";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaPN", SqlDbType.VarChar).Value = mapn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PhieuNhap_DTO pn = new PhieuNhap_DTO();
                pn.MaPN = reader.GetString(0);
                pn.NguonNhap = reader.GetString(1);
                pn.NgayNhap = reader.GetDateTime(2);
                pn.DiaChi = reader.GetString(3);
                pn.GhiChuNhap = reader.GetString(4);
                ttpn.Add(pn);
            }
            reader.Close();
            return ttpn;
          
        }

    }
}
