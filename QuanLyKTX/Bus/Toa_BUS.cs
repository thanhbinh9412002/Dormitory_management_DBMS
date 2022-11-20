using QuanLyKTX.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.Bus
{
    public class Toa_BUS
    {
        private Toa_DAO ToaDao;
        public Toa_BUS()
        {
            ToaDao = new Toa_DAO();
        }
        public DataTable GetInformationToa()
        {
            return ToaDao.GetInformationToa();
        }
        public void AddToa(string tentoa, int sophong, string manql)
        {
            ToaDao.AddToa(tentoa, sophong, manql);
        }
        public void UpdateToa(string tentoa, int sophong, string manql)
        {
            ToaDao.UpdateToa(tentoa, sophong, manql);
        }
        public void DeleteToa(string tentoa)
        {
            ToaDao.DeleteToa(tentoa);
        }
        public int CountPhong(string matoa)
        {
            return ToaDao.CountPhong(matoa);
        }
    }
}
