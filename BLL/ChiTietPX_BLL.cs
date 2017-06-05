using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ChiTietPX_BLL
    {
        ChiTietPX_DAL ctpxDAL = new ChiTietPX_DAL();
        public List<ChiTietPX_DTO> ChiTietPX(string mapx)
        {
            return ctpxDAL.ChiTietPX(mapx);
        }
        public bool ThemChiTietPX(ChiTietPX_DTO ctpx)
        {
            return ctpxDAL.ThemChiTietPX(ctpx);
        }
        public bool SuaChiTietPX(ChiTietPX_DTO ctpx)
        {
            return ctpxDAL.SuaChiTietPX(ctpx);
        }
        public bool XoaChiTietPX(string MaHang)
        {
            return ctpxDAL.XoaChiTietPN(MaHang);
        }
    }
}
