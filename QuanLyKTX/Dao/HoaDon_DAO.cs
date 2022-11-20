using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKTX.DataProvider;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKTX.Dao
{
    public class HoaDon_DAO
    {
        private DBConnection cnn = null;
        public HoaDon_DAO()
        {
            cnn = new DBConnection();
        }
        public DataTable GetAllInformation(string manv)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaNQL", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = manv;
            return cnn.executeReader("select * from func_HoaDonQL(@MaNQL)", sqlParameters);
        }
        public DataTable GetRoom(string manv)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaNQL", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = manv;
            return cnn.executeReader("SELECT * FROM dbo.func_PhongQuanLy(@MaNQL)", sqlParameters);
        }

        public DataTable FillterInvoice(string manv, string maphong)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaNQL", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = manv;
            sqlParameters[1] = new SqlParameter("@MaPhong", System.Data.SqlDbType.NVarChar);
            sqlParameters[1].Value = maphong;
            return cnn.executeReader("SELECT * FROM dbo.func_HoaDonPhongQuanLy(@MaNQL,@MaPhong)", sqlParameters);
        }

        public int CountInvoiceRoom(string manv, string maphong)
        {
            int newProdID = 0;
            string sql = "[dbo].[func_SoLuongHoaDonTheoMaPhong]";
            string[] pNames = { "@MaNQL", "@MaPhong" };
            object[] pvalues = { manv, maphong };
            newProdID = cnn.ExecuteStoredProcedure(sql, pNames, pvalues);
            return newProdID;
        }
        public void AddInvoice(string mahd, string maphong, string trangthai, float tiendien, float tiennuoc, DateTime ngaytao)
        {
            string sql = "proc_ThemHoaDonDienNuoc";
            string[] pNames = { "@mahd", "@maphong", "@trangthai", "@td", "@tn", "@ngaytao" };
            object[] pvalues = { mahd, maphong, trangthai, tiendien, tiennuoc, ngaytao };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
        public DataTable UnpaidInvoice(string manv)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaNQL", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = manv;
            return cnn.executeReader("select * from func_HoaDonChuaThanhToanTheoPhong(@MaNQL)", sqlParameters);
        }

        public void UpdateInvoice(string mahd, string maphong, string trangthai, float tiendien, float tiennuoc, DateTime ngaytao)
        {
            string sql = "proc_SuaHoaDonDienNuoc";
            string[] pNames = { "@mahd", "@maphong", "@trangthai", "@td", "@tn", "@ngaytao" };
            object[] pvalues = { mahd, maphong, trangthai, tiendien, tiennuoc, ngaytao };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
    }
}
