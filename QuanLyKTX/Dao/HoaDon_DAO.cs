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
        public DataTable Transfer(DataTable dt)
        {
            dt.Columns.Add("Tổng tiền", typeof(float));
            float x = 0;
            float y = 0;
            foreach (DataRow dr in dt.Rows)
            {
                x = float.Parse(dr["Tiền Điện"].ToString());
                y = float.Parse(dr["Tiền Nước"].ToString());
                dr["Tổng tiền"] = x + y;
            }
            return dt;
        }
        public DataTable GetAllInformation(string manv)
        {
            DataTable dt;
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaNQL", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = manv;
            dt  =  cnn.executeReader("select * from func_HoaDonQL(@MaNQL)", sqlParameters);
            return Transfer(dt);
            
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
            DataTable dt;
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaNQL", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = manv;
            sqlParameters[1] = new SqlParameter("@MaPhong", System.Data.SqlDbType.NVarChar);
            sqlParameters[1].Value = maphong;
            dt = cnn.executeReader("SELECT * FROM dbo.func_HoaDonPhongQuanLy(@MaNQL,@MaPhong)", sqlParameters);
            return Transfer(dt);
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
            DataTable dt;
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaNQL", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = manv;
            dt = cnn.executeReader("select * from func_HoaDonChuaThanhToanTheoPhong(@MaNQL)", sqlParameters);
            return Transfer(dt);
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
