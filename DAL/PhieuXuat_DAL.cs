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
    public class PhieuXuat_DAL : DatabaseAccess2
    {
        public List<PhieuXuat_DTO> ThongTinPhieuXuat()
        {
            List<PhieuXuat_DTO> ttpx = new List<PhieuXuat_DTO>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PHIEUXUAT";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PhieuXuat_DTO px = new PhieuXuat_DTO();
                px.MaPX = reader.GetString(0);
                px.NguoiNhan = reader.GetString(1);
                px.NgayXuat = reader.GetDateTime(2);
                px.DiaChi = reader.GetString(3);
                px.GhiChuXuat = reader.GetString(4);

                ttpx.Add(px);
            }
            if (reader != null)
                reader.Close();
            return ttpx;
        }

        public bool ThemPhieuXuat(PhieuXuat_DTO pn)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into PHIEUXUAT values(@MaPX, @NguoiNhan, @NgayXuat, @DiaChi, @GhiChuXuat)";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaPX", SqlDbType.VarChar).Value = pn.MaPX;
            cmd.Parameters.Add("@NguoiNhan", SqlDbType.NVarChar).Value = pn.NguoiNhan;
            cmd.Parameters.Add("@NgayXuat", SqlDbType.DateTime).Value = pn.NgayXuat;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = pn.DiaChi;
            cmd.Parameters.Add("@GhiChuXuat", SqlDbType.NVarChar).Value = pn.GhiChuXuat;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }

        public bool SuaPhieuXuat(PhieuXuat_DTO pn)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update PHIEUXUAT set  NGUOI_NHAN=@NguoiNhan, NGAY_XUAT=@NgayXuat, DIA_CHI=@DiaChi, GHI_CHU_XUAT= @GhiChuXuat where MA_PX=@MaPX";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaPX", SqlDbType.VarChar).Value = pn.MaPX;
            cmd.Parameters.Add("@NguoiNhan", SqlDbType.NVarChar).Value = pn.NguoiNhan;
            cmd.Parameters.Add("@NgayXuat", SqlDbType.DateTime).Value = pn.NgayXuat;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = pn.DiaChi;
            cmd.Parameters.Add("@GhiChuXuat", SqlDbType.NVarChar).Value = pn.GhiChuXuat;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
                return true;
            else
                return false;
        }

        public bool XoaPhieuXuat(string MaPX)
        {

            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from PHIEUXUAT where MA_PX=@MaPX";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaPX", SqlDbType.NVarChar).Value = MaPX;
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

                tthh.Add(hh);
            }
            if (reader != null)
                reader.Close();
            return tthh;
        }

        public List<PhieuXuat_DTO> TimKiemPX(string mapx)
        {
            List<PhieuXuat_DTO> ttpx = new List<PhieuXuat_DTO>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PHIEUXUAT where MA_PX like N'%'+@MaPX+'%'";
            cmd.Connection = conn;
            cmd.Parameters.Add("@MaPN", SqlDbType.VarChar).Value = mapx;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PhieuXuat_DTO px = new PhieuXuat_DTO();
                px.MaPX = reader.GetString(0);
                px.NguoiNhan = reader.GetString(1);
                px.NgayXuat = reader.GetDateTime(2);
                px.DiaChi = reader.GetString(3);
                px.GhiChuXuat = reader.GetString(4);
                ttpx.Add(px);
            }
            reader.Close();
            return ttpx;

        }

    }
}
