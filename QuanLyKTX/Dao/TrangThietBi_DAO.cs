using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyKTX.DataProvider;
using QuanLyKTX.Class;

namespace QuanLyKTX.DAO
{
    internal class TrangThietBi_DAO
    {
        private DBConnection cnn;
        public TrangThietBi_DAO()
        {
            cnn = new DBConnection();
        }
        public DataTable DanhSachThietBi()
        {
            string spName = "[dbo].[proc_DanhSachTatCaTrangThietBi]";
            return cnn.ExecuteProcedureDatatableNoPara(spName);
        }
        public int ThemThietBi(TrangThietBi tb)
        {
            string spName = "[dbo].[proc_ThemThietBi]";
            string[] pNames = { "@matb", "@tentb", "@tongsl" };
            object[] pValues = { tb.MaThietBi, tb.TenThietBi, tb.SoLuong};
            int count = cnn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count;
        }
        public string TimMaThietBiLonNhat()
        {
            string spName = "[dbo].[func_LayMaTB]";
            string[] pNames = { };
            object[] pValues = { };
            return cnn.ExecuteStoredProcedureString(spName, pNames, pValues);
        }
        public int SuaThietBi(TrangThietBi tb)
        {
            string spName = "[dbo].[proc_SuaThietBi]";
            string[] pNames = { "@matb", "@tentb", "@tongsl" };
            object[] pValues = { tb.MaThietBi, tb.TenThietBi, tb.SoLuong };
            int count = cnn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count;
        }
        public int XoaThietBi(string matb)
        {
            string spName = "[dbo].[proc_XoaThietBi]";
            string[] pNames = { "@matb"};
            object[] pValues = {matb};
            int count = cnn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count;
        }
    }
}
