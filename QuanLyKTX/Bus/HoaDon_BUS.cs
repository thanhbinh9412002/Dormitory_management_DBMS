using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKTX.Dao;
using System.Data;
namespace QuanLyKTX.Bus

{
    public class HoaDon_BUS
    {
        private HoaDon_DAO HdDAO;
        public HoaDon_BUS()
        {
            HdDAO = new HoaDon_DAO();
        }
        public DataTable GetAllInformation(string manv)
        {
            return HdDAO.GetAllInformation(manv);
        }
        public DataTable GetRoom(string manv)
        {
            return HdDAO.GetRoom(manv);
        }
        public DataTable FillterInvoice(string manv, string maphong)
        {
            return HdDAO.FillterInvoice(manv, maphong);
        }
        public int CountInvoiceRoom(string manv, string maphong)
        {
            return HdDAO.CountInvoiceRoom(manv, maphong);
        }
        public void AddInvoice(string mahd, string maphong, string trangthai, float tiendien, float tiennuoc, DateTime ngaytao)
        {
            HdDAO.AddInvoice(mahd, maphong, trangthai, tiendien, tiennuoc, ngaytao);
        }
        public DataTable UnpaidInvoice(string manv)
        {
            return HdDAO.UnpaidInvoice(manv);
        }
        public void UpdateInvoice(string mahd, string maphong, string trangthai, float tiendien, float tiennuoc, DateTime ngaytao)
        {
            HdDAO.UpdateInvoice(mahd, maphong, trangthai, tiendien, tiennuoc, ngaytao);
        }
    }
}
