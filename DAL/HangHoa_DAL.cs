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
    public class HangHoa_DAL : DatabaseAccess2
    { 
        public List<HangHoa_DTO> ThongTinHangHoa()
        {
            List<HangHoa_DTO> tthh = new List<HangHoa_DTO>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from HANGHOA order by SL ASC";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                HangHoa_DTO hh = new HangHoa_DTO();            
                hh.MaHang = reader.GetString(0);
                hh.TenHang = reader.GetString(1);
                hh.SoLuong = reader.GetInt32(2);
                hh.GhiChu = reader.GetString(3);
                hh.ID = reader.GetInt32(4);
                hh.DonGia = reader.GetInt32(5);
                hh.HangSX = reader.GetString(6);
                tthh.Add(hh);
            }
            if (reader != null)
                reader.Close();
            return tthh;
        }

        public bool ThemHangHoa(HangHoa_DTO hh)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into HANGHOA values(@MaHang,@TenHang, @SoLuong, @GhiChu, @ID, @DonGia, @HangSX)";
            cmd.Connection = conn;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = hh.ID;
            cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = hh.MaHang;
            cmd.Parameters.Add("@TenHang", SqlDbType.NVarChar).Value = hh.TenHang;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = hh.SoLuong;
            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = hh.GhiChu;
            cmd.Parameters.Add("@DonGia", SqlDbType.Int).Value = hh.DonGia;
            cmd.Parameters.Add("@HangSX", SqlDbType.NVarChar).Value = hh.HangSX;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
        public bool SuaHangHoa(HangHoa_DTO hh)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update HANGHOA set TEN_HANG= @TenHang, SL= @SoLuong, GHI_CHU= @GhiChu, ID=@ID, DON_GIA=@DonGia, HANG_SX=@HangSX where MA_HANG=@MaHang";
            cmd.Connection = conn;        
            cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = hh.MaHang;
            cmd.Parameters.Add("@TenHang", SqlDbType.NVarChar).Value = hh.TenHang;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = hh.SoLuong;
            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = hh.GhiChu;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = hh.ID;
            cmd.Parameters.Add("@DonGia", SqlDbType.Int).Value = hh.DonGia;
            cmd.Parameters.Add("@HangSX", SqlDbType.NVarChar).Value = hh.HangSX;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
        public bool KiemtraKey(string mahh)
        {
            bool check = false;       
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from HANGHOA where MA_HANG='"+mahh+"'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                check = true;
            }
            reader.Close();
            return check;
        }
       
        public bool XoaHangHoa(string MaHang)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from HANGHOA where MA_HANG=@MaHang";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = MaHang;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }

        public List<HangHoa_DTO> TimKiemHangHoa(string tenhang)
        {
            List<HangHoa_DTO> dsHangHoa = new List<HangHoa_DTO>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from HANGHOA where TEN_HANG like N'%'+@TenHang+'%'";
            cmd.Connection = conn;
            cmd.Parameters.Add("@TenHang", SqlDbType.NVarChar).Value = tenhang;
            //cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = mahang;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.MaHang = reader.GetString(0);
                hh.TenHang = reader.GetString(1);
                hh.SoLuong = reader.GetInt32(2);
                hh.GhiChu = reader.GetString(3);
                hh.ID = reader.GetInt32(4);
                hh.DonGia = reader.GetInt32(5);
                hh.HangSX = reader.GetString(6);
                dsHangHoa.Add(hh);
            }
            reader.Close();
            return dsHangHoa;
        }
    }
}
