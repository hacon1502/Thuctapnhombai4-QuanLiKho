using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ChiTietPN_BLL
    {
        ChiTietPN_DAL ctpnDAL = new ChiTietPN_DAL();
        public List<ChiTietPN_DTO> ChiTietPN(string mapn)
        {
            return ctpnDAL.ChiTietPN(mapn);
        }
        public bool ThemChiTietPN(ChiTietPN_DTO ctpn)
        {
            return ctpnDAL.ThemChiTietPN(ctpn);
        }
        public bool SuaChiTietPN(ChiTietPN_DTO ctpn)
        {
            return ctpnDAL.SuaChiTietPN(ctpn);
        }
        public bool XoaChiTietPN(string MaHang)
        {
            return ctpnDAL.XoaChiTietPN(MaHang);
        }
    }
}
