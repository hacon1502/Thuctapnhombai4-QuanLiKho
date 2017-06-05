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
    public class NguoiDung_DAL:DatabaseAccess2
    {
        public List<NguoiDung_DTO> ThongTinNguoiDung()
        {
            List<NguoiDung_DTO> ttnd = new List<NguoiDung_DTO>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from TaiKhoan";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NguoiDung_DTO nd = new NguoiDung_DTO();              
                nd.TenDangNhap = reader.GetString(0);
                nd.MatKhau = reader.GetString(1);
                nd.TenNguoiDung = reader.GetString(2);
                nd.PhanQuyen = reader.GetString(3);           
                ttnd.Add(nd);
            }
            if (reader != null)
                reader.Close();
            return ttnd;
        }

        public bool ThemNguoiDung(NguoiDung_DTO nd)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into TaiKhoan values( @TenDangNhap, @MatKhau,@TenNguoiDung, @PhanQuyen)";
            cmd.Connection = conn;
            cmd.Parameters.Add("@TenDangNhap", SqlDbType.NVarChar).Value = nd.TenDangNhap;
            cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = nd.MatKhau;
            cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = nd.TenNguoiDung;
            cmd.Parameters.Add("@PhanQuyen", SqlDbType.NVarChar).Value = nd.PhanQuyen;          
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
        public bool SuaNguoiDung(NguoiDung_DTO nd)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update TaiKhoan set matkhau= @MatKhau, tennguoidung= @TenNguoiDung, phanquyen=@PhanQuyen  where tendangnhap= @TenDangNhap";
            cmd.Connection = conn;
            cmd.Parameters.Add("@TenDangNhap", SqlDbType.NVarChar).Value = nd.TenDangNhap;
            cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = nd.MatKhau;
            cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = nd.TenNguoiDung;         
            cmd.Parameters.Add("@PhanQuyen", SqlDbType.NVarChar).Value = nd.PhanQuyen;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
        public bool XoaNguoiDung(string ten)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from TaiKhoan where tendangnhap=@ten";
            cmd.Connection = conn;
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }
    }
}
