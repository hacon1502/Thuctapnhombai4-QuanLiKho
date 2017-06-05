using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class PhieuXuat_BLL
    {
        PhieuXuat_DAL pxDAL = new PhieuXuat_DAL();

        public List<PhieuXuat_DTO> ThongTinPhieuXuat()
        {
            return pxDAL.ThongTinPhieuXuat();
        }
        public List<HangHoa_DTO> autoDuLieu()
        {
            return pxDAL.autoDuLieu();
        }
        public bool ThemPhieuXuat(PhieuXuat_DTO px)
        {
            return pxDAL.ThemPhieuXuat(px);
        }
        public bool SuaPhieuXuat(PhieuXuat_DTO px)
        {
            return pxDAL.SuaPhieuXuat(px);
        }
        public bool XoaPhieuXuat(string MaPX)
        {
            return pxDAL.XoaPhieuXuat(MaPX);
        }
        public List<PhieuXuat_DTO> TimKiemPX(string mapx)
        {
            return pxDAL.TimKiemPX(mapx);
        }

    }
}
