using QuanLyKTX.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.Bus
{
    public class Phong_BUS
    {
        private Phong_DAO PhongDAO;
        public Phong_BUS()
        {
            PhongDAO = new Phong_DAO();
        }
        public DataTable GetAllInformation(string manv)
        {
            return PhongDAO.GetAllInformation(manv);
        }
        public DataTable GetAllInformationToa(string TenToa)
        {
            return PhongDAO.GetAllInformationToa(TenToa);
        }
        public void AddPhong(string maphong, string tentoa, int svhientai, int svtoida)
        {
            PhongDAO.AddPhong(maphong, tentoa, svhientai, svtoida);
        }
        public void DeletePhong(string maphong)
        {
            PhongDAO.DeletePhong(maphong);
        }
        public DataTable PhongConCho(string tentoa)
        {
            return PhongDAO.PhongConCho(tentoa);
        }
        public DataTable PhongDay(string tentoa)
        {
            return PhongDAO.PhongDay(tentoa);
        }
    }
}
