using QuanLyKTX.DataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.Dao
{
    public class XemPhong_DAO
    {
        private DBConnection conn;
        public XemPhong_DAO()
        {
            conn = new DBConnection();
        }
        public DataTable PhongConCho()
        {
            string sql = "SELECT * FROM [dbo].[view_PhongConCho]";
            return conn.executeLoadData(sql);
        }
        public DataTable PhongDay()
        {
            string sql = "SELECT * FROM [dbo].[view_PhongDay]";
            return conn.executeLoadData(sql);
        }
    }
}
