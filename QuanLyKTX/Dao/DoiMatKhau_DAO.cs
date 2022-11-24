using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKTX.DataProvider;

namespace QuanLyKTX.DAO
{
    internal class DoiMatKhau_DAO
    {
        private DBConnection cnn = null;
        public DoiMatKhau_DAO()
        {
            cnn = new DBConnection();
        }
        public string KiemTraMatKhauCu(string TenTaiKhoan)
        {
            string spName = "[dbo].[func_LayMatKhau]";
            string[] pNames = { "@tentk"};
            object[] pValues = { TenTaiKhoan };
            string count = cnn.ExecuteStoredProcedureString(spName, pNames, pValues);
            return count;
        }
        public int DoiMatKhau(string tentaikhoan, string newpass)
        {
            string spName = "[dbo].[proc_DoiMatKhau]";
            string[] pNames = { "@tentk", "@mk"};
            object[] pValues = {tentaikhoan, newpass};
            int count = cnn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count;
        }
    }
}
