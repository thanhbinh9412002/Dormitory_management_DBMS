using QuanLyKTX.DataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.Dao
{
    public class Toa_DAO
    {
        private DBConnection cnn = null;
        public Toa_DAO()
        {
            cnn = new DBConnection();
        }
        public DataTable GetInformationToa()
        {
            string sql = "pro_DanhSachToa";
            return cnn.ExecuteProcedureDatatableNoPara(sql);
        }
        public void AddToa(string tentoa, int sophong, string manql)
        {
            string sql = "proc_ThemToa";
            string[] pNames = { "@TenToa", "@SoPhong", "@MaNguoiQuanLy" };
            object[] pvalues = { tentoa, sophong, manql };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
        public void UpdateToa(string tentoa, int sophong, string manql)
        {
            string sql = "proc_SuaToa";
            string[] pNames = { "@TenToa", "@SoPhong", "@MaNguoiQuanLy" };
            object[] pvalues = { tentoa, sophong, manql };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
        public void DeleteToa(string tentoa)
        {
            string sql = "proc_XoaToa";
            string[] pNames = { "@TenToa" };
            object[] pvalues = { tentoa };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
        public int CountPhong(string matoa)
        {
            int soluongsd = 0;
            string sql = "[dbo].[func_SoLuongPhong]";
            string[] pNames = { "@TenToa" };
            object[] pvalues = { matoa };
            soluongsd = cnn.ExecuteStoredProcedure(sql, pNames, pvalues);
            return soluongsd;
        }
    }
}
