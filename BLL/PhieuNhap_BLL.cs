using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class PhieuNhap_BLL
    {
        PhieuNhap_DAL pnDAL = new PhieuNhap_DAL();
       
        public List<PhieuNhap_DTO> ThongTinPhieuNhap()
        {
            return pnDAL.ThongTinPhieuNhap();
        }
        public List<HangHoa_DTO> autoDuLieu()
        {
            return pnDAL.autoDuLieu();
        }
        public bool ThemPhieuNhap(PhieuNhap_DTO pn)
        {
            return pnDAL.ThemPhieuNhap(pn);
        }
        public bool SuaPhieuNhap(PhieuNhap_DTO pn)
        {
            return pnDAL.SuaPhieuNhap(pn);
        }
        public bool XoaPhieuNhap(string MaPN)
        {
            return pnDAL.XoaPhieuNhap(MaPN);
        }
        public List<PhieuNhap_DTO> TimKiemPN(string mapn)
        {
            return pnDAL.TimKiemPN(mapn);
        }
        
    }
}
