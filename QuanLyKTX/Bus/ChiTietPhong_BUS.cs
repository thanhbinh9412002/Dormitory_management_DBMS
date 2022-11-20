using QuanLyKTX.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.Bus
{
    public class ChiTietPhong_BUS
    {
        private ChiTietPhong_DAO ChiTietPhongDAO;
        public ChiTietPhong_BUS()
        {
            ChiTietPhongDAO = new ChiTietPhong_DAO();
        }
        public DataTable GetAllInformation(string maphong)
        {
            return ChiTietPhongDAO.GetAllInformation(maphong);
        }
        public DataTable GetComboBox(string matoa)
        {
            return ChiTietPhongDAO.GetComboBox(matoa);
        }
    }
}
