using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class HangHoa_BLL
    {
        HangHoa_DAL hhDAL = new HangHoa_DAL();
         
        public List<HangHoa_DTO> ThongTinHangHoa()
        {
            return hhDAL.ThongTinHangHoa();
        }
        public bool ThemHangHoa(HangHoa_DTO hh)
        {
            return hhDAL.ThemHangHoa(hh);
        }
        public bool SuaHangHoa(HangHoa_DTO hh)
        {
            return hhDAL.SuaHangHoa(hh);
        }
        public bool XoaHangHoa(string MaHang)
        {
            return hhDAL.XoaHangHoa(MaHang);
        }
        public List<HangHoa_DTO> TimKiemHangHoa( string tenhang)
        {
            return hhDAL.TimKiemHangHoa(tenhang);
        }
        public bool KiemtraKey(string mahh)
        {
            return hhDAL.KiemtraKey(mahh);
        }

    }
}
