using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKTX.Dao;
using QuanLyKTX.DAO;

namespace QuanLyKTX.BUS
{
    internal class DoiMatKhau_BUS
    {
        private DoiMatKhau_DAO dmkDAO;
        public DoiMatKhau_BUS()
        {
            dmkDAO = new DoiMatKhau_DAO();
        }
        public string KiemTraMatKhauCu(string TenTaiKhoan)
        {
            return dmkDAO.KiemTraMatKhauCu(TenTaiKhoan);
        }
        public int DoiMatKhau(string tentaikhoan, string newpass)
        {
            return dmkDAO.DoiMatKhau(tentaikhoan, newpass);
        }
    }
}
