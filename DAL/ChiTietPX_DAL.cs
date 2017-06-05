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
    public class ChiTietPX_DAL : DatabaseAccess2
    {
        public List<ChiTietPX_DTO> ChiTietPX(string mapx)
        {
            List<ChiTietPX_DTO> ttctpx = new List<ChiTietPX_DTO>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from CHITIET_PX where MA_PX=@MaPX;";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaPX", SqlDbType.VarChar).Value = mapx;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ChiTietPX_DTO ctpx = new ChiTietPX_DTO();
                ctpx.MaPX = reader.GetString(0);
                ctpx.MaHang = reader.GetString(1);
                ctpx.TenHangXuat = reader.GetString(2);
                ctpx.SLXuat = reader.GetInt32(3);
                ctpx.ID = reader.GetInt32(4);
                ctpx.DonGiaXuat = reader.GetInt32(5);
                ctpx.TongTienXuat = reader.GetInt32(6);
                ttctpx.Add(ctpx);
            }
            if (reader != null)
                reader.Close();
            return ttctpx;
        }
        public bool ThemChiTietPX(ChiTietPX_DTO ctpn)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into  CHITIET_PX values(@MaPX, @MaHang, @TenHangXuat, @SLXuat, @ID, @DonGiaXuat, @TongTienXuat)";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaPX", SqlDbType.VarChar).Value = ctpn.MaPX;
            cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = ctpn.MaHang;
            cmd.Parameters.Add("@TenHangXuat", SqlDbType.NVarChar).Value = ctpn.TenHangXuat;
            cmd.Parameters.Add("@SLXuat", SqlDbType.Int).Value = ctpn.SLXuat;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ctpn.ID;
            cmd.Parameters.Add("@DonGiaXuat", SqlDbType.Int).Value = ctpn.DonGiaXuat;
            cmd.Parameters.Add("@TongTienXuat", SqlDbType.Int).Value = ctpn.TongTienXuat;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
        public bool SuaChiTietPX(ChiTietPX_DTO ctpn)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update CHITIET_PN set  TEN_HANG_XUAT=@TenHangXuat, SL_XUAT=@SLXuat, ID=@ID, DON_GIA_XUAT=@DonGiaXuat, TONG_TIEN_XUAT=@TongTienXuat where  MA_PX=@MaPX and MA_HANG=@MaHang";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaPX", SqlDbType.VarChar).Value = ctpn.MaPX;
            cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = ctpn.MaHang;
            cmd.Parameters.Add("@TenHangXuat", SqlDbType.NVarChar).Value = ctpn.TenHangXuat;
            cmd.Parameters.Add("@SLXuat", SqlDbType.Int).Value = ctpn.SLXuat;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ctpn.ID;
            cmd.Parameters.Add("@DonGiaXuat", SqlDbType.Int).Value = ctpn.DonGiaXuat;
            cmd.Parameters.Add("@TongTienXuat", SqlDbType.Int).Value = ctpn.TongTienXuat;
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
            cmd.CommandText = "delete from CHITIET_PX where MA_HANG=@MaHang";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = MaHang;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
        

    }
}
