using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKTX.DAO;
using QuanLyKTX.Class;

namespace QuanLyKTX
{
    internal class TrangThietBi_BUS
    {
        private TrangThietBi_DAO ttbDAO;
        public TrangThietBi_BUS()
        {
            ttbDAO = new TrangThietBi_DAO();
        }
        public DataTable DanhDachThietBi()
        {
            return ttbDAO.DanhSachThietBi();
        }
        public int ThemThietBi(TrangThietBi tb)
        {
            return ttbDAO.ThemThietBi(tb);
        }
        public string TimMaThietBiLonNhat()
        {
            return ttbDAO.TimMaThietBiLonNhat();
        }
        public int SuaThietBi(TrangThietBi tb)
        {
            return ttbDAO.SuaThietBi(tb);
        }
        public int XoaThietBi(string matb)
        {
            return ttbDAO.XoaThietBi(matb);
        }
    }
}
