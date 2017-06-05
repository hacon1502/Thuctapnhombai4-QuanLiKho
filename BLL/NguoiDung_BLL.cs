using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class NguoiDung_BLL
    {
        NguoiDung_DAL ndDAL = new NguoiDung_DAL();

        public List<NguoiDung_DTO> ThongTinNguoiDung()
        {
            return ndDAL.ThongTinNguoiDung();
        }
        public bool ThemNguoiDung(NguoiDung_DTO nd)
        {
            return ndDAL.ThemNguoiDung(nd);
        }
        public bool SuaNguoiDung(NguoiDung_DTO nd)
        {
            return ndDAL.SuaNguoiDung(nd);
        }
        public bool XoaNguoiDung(string tendn)
        {
            return ndDAL.XoaNguoiDung(tendn);
        }
    }
}
