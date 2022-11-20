using QuanLyKTX.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.Bus
{
    public class XemPhong_BUS
    {
        private XemPhong_DAO XemPhongDao;
        public XemPhong_BUS()
        {
            XemPhongDao = new XemPhong_DAO();
        }
        public DataTable PhongConCho()
        {
            return XemPhongDao.PhongConCho();
        }
        public DataTable PhongDay()
        {
            return XemPhongDao.PhongDay();
        }
    }
}
