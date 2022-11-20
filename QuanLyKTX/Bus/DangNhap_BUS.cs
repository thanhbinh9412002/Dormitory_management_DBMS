using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKTX.DAO;
using QuanLyKTX.Class;

namespace QuanLyKTX.BUS
{
    internal class DangNhap_BUS
    {
        private DangNhap_DAO dnDAO;
        public DangNhap_BUS()
        {
            dnDAO = new DangNhap_DAO();
        }

        public int Check_Tai_Khoan(Tai_khoan tk)
        {
            return dnDAO.Check_Tai_Khoan(tk);
        }
    }
}
