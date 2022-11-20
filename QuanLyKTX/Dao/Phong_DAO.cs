using QuanLyKTX.DataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.Dao
{
    public class Phong_DAO
    {
        private DBConnection cnn = null;
        public Phong_DAO()
        {
            cnn = new DBConnection();
        }
        public DataTable GetAllInformation(string manv)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaNQL", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = manv;
            return cnn.executeReader("SELECT * FROM func_DanhSachPhongTheoNhanVien(@MaNQL)", sqlParameters);
        }
        public DataTable GetAllInformationToa(string TenToa)
        {
            string sql = "pro_DanhSachPhongTheoToa";
            string[] pNames = { "@matoa" };
            object[] pvalues = { TenToa };
            return cnn.ExecuteProcedureDatatable(sql, pNames, pvalues);
        }
        public void AddPhong(string maphong, string tentoa, int svhientai, int svtoida)
        {
            string sql = "proc_ThemPhong1Toa";
            string[] pNames = { "@MaPhong", "@Toa", "@SoLuongSinhVienHienTai", "@SoLuongSinhVienToiDa" };
            object[] pvalues = { maphong, tentoa, svhientai, svtoida };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
        public void DeletePhong(string maphong)
        {
            string sql = "proc_XoaPhong";
            string[] pNames = { "@MaPhong" };
            object[] pvalues = { maphong };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
        public DataTable PhongConCho(string tentoa)
        {
            string sql = "pro_DanhSachPhongConCho";
            string[] pNames = { "@TenToa" };
            object[] pvalues = { tentoa };
            return cnn.ExecuteProcedureDatatable(sql, pNames, pvalues);
        }
        public DataTable PhongDay(string tentoa)
        {
            string sql = "pro_DanhSachPhongDay";
            string[] pNames = { "@TenToa" };
            object[] pvalues = { tentoa };
            return cnn.ExecuteProcedureDatatable(sql, pNames, pvalues);
        }
    }
}
