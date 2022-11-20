using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKTX.Dao;
using System.Data;
namespace QuanLyKTX.Bus
{
    public class ThietBiTrongPhong_BUS
    {
        private ThietBiTrongPhong_DAO TbDao;
        ChiTietPhong_BUS chiTietPhong = new ChiTietPhong_BUS();
        public ThietBiTrongPhong_BUS()
        {
            TbDao = new ThietBiTrongPhong_DAO();
        }
        public DataTable GetAllInformation(string maphong)
        {
            return TbDao.GetAllInformation(maphong);
        }
        public DataTable GetIdEq()
        {
            return TbDao.GetIdEq();
        }
        public void AddEqRoom(string matb, string maphong, int slhong, int sltot, int sltoida)
        {
            TbDao.AddEqRoom(matb, maphong, slhong, sltot, sltoida);
        }
        public void UpdateEqRoom(string matb, string maphong, int slhong, int sltot, int sltoida)
        {
            TbDao.UpdateEqRoom(matb, maphong, slhong, sltot, sltoida);
        }
        public void DeleteEqRoom(string ma, string maphong)
        {
            TbDao.DeleteEqRoom(ma, maphong);
        }
        public string TenThietBi(string ma)
        {
            return TbDao.TenThietBi(ma);
        }
        public DataTable GetComboBox(string matoa)
        {
            return chiTietPhong.GetComboBox(matoa);
        }
    }
}
