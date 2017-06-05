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
    public class ChiTietPN_DAL:DatabaseAccess2
    {
        public List<ChiTietPN_DTO> ChiTietPN(string mapn)
        {
            List<ChiTietPN_DTO> ttctpn = new List<ChiTietPN_DTO>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from CHITIET_PN where MA_PN=@MaPN;";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaPN", SqlDbType.VarChar).Value = mapn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ChiTietPN_DTO ctpn = new ChiTietPN_DTO();
                ctpn.MaPN = reader.GetString(0);
                ctpn.MaHang = reader.GetString(1);
                ctpn.TenHang = reader.GetString(2);
                ctpn.SoLuong = reader.GetInt32(3);
                ctpn.ID = reader.GetInt32(4);
                ctpn.DonGiaNhap = reader.GetInt32(5);
                ctpn.TongTienNhap = reader.GetInt32(6);
                ttctpn.Add(ctpn);
            }
            if (reader != null)
                reader.Close();
            return ttctpn;
        }
        public bool ThemChiTietPN(ChiTietPN_DTO ctpn)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into  CHITIET_PN values(@MaPN, @MaHang, @TenHangNhap, @SLNhap, @ID, @DonGiaNhap, @TongTienNhap)";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaPN", SqlDbType.VarChar).Value = ctpn.MaPN;
            cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = ctpn.MaHang;
            cmd.Parameters.Add("@TenHangNhap", SqlDbType.NVarChar).Value = ctpn.TenHang;
            cmd.Parameters.Add("@SLNhap", SqlDbType.Int).Value = ctpn.SoLuong;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ctpn.ID;
            cmd.Parameters.Add("@DonGiaNhap", SqlDbType.Int).Value = ctpn.DonGiaNhap;
            cmd.Parameters.Add("@TongTienNhap", SqlDbType.Int).Value = ctpn.TongTienNhap;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
        public bool SuaChiTietPN(ChiTietPN_DTO ctpn)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update CHITIET_PN set  TEN_HANG_NHAP=@TenHangNhap, SL_NHAP=@SoLuong, ID=@ID, DON_GIA_NHAP=@DonGiaNhap, TONG_TIEN_NHAP=@TongTienNhap where  MA_PN=@MaPN and MA_HANG=@MaHang";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaPN", SqlDbType.VarChar).Value = ctpn.MaPN;
            cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = ctpn.MaHang;
            cmd.Parameters.Add("@TenHangNhap", SqlDbType.NVarChar).Value = ctpn.TenHang;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ctpn.SoLuong;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ctpn.ID;
            cmd.Parameters.Add("@DonGiaNhap", SqlDbType.Int).Value = ctpn.DonGiaNhap;
            cmd.Parameters.Add("@TongTienNhap", SqlDbType.Int).Value = ctpn.TongTienNhap;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
        public bool XoaChiTietPN(string MaHang)
        {

            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from CHITIET_PN where MA_HANG=@MaHang";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = MaHang;
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
            cmd.CommandText = "select * from HANGHOA where MA_HANG='" + hh.MaHang + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                hh.MaHang = reader.GetString(0);
                hh.TenHang = reader.GetString(1);
                hh.DonGia = reader.GetInt32(5);
                tthh.Add(hh);
            }
            if (reader != null)
                reader.Close();
            return tthh;
        }

    }
}
