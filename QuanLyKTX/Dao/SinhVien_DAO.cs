using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKTX.DataProvider;

namespace QuanLyKTX.Dao
{
    public class SinhVien_DAO
    {
        private DBConnection cnn = null;
        public SinhVien_DAO()
        {
            cnn = new DBConnection();
        }

        public DataTable GetRoom(string manv)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaNQL", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = manv;
            return cnn.executeReader("SELECT * FROM dbo.func_PhongQuanLy(@MaNQL)", sqlParameters);
        }
        //public DataTable GetRoom(string manv)
        //{
        //    SqlParameter[] sqlParameters = new SqlParameter[1];
        //    sqlParameters[0] = new SqlParameter("@MaNQL", System.Data.SqlDbType.Char);
        //    sqlParameters[0].Value = manv;
        //    return cnn.executeReader("SELECT * FROM dbo.func_PhongQuanLy(@MaNQL)", sqlParameters);
        //}
        public DataTable GetAllInformation(string manv)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaNQL", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = manv;
            return cnn.executeReader("SELECT * FROM dbo.func_SinhVienQuanLy(@MaNQL)", sqlParameters);
        }

        public DataTable FillterStudent(string manv, string gioitinh)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaNQL", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = manv;
            sqlParameters[1] = new SqlParameter("@gioitinh", System.Data.SqlDbType.NVarChar);
            sqlParameters[1].Value = gioitinh;
            return cnn.executeReader("SELECT * FROM dbo.func_GioiTinhSinhVienQuanLy(@MaNQL,@gioitinh)", sqlParameters);
        }

        public int CountStudentGender(string manv, string gioitinh)
        {
            int newProdID = 0;
            string sql = "[dbo].[func_SoLuongSinhVienTheoGioiTinh]";
            string[] pNames = { "@MaNQL", "@gioitinh" };
            object[] pvalues = { manv, gioitinh };
            newProdID = cnn.ExecuteStoredProcedure(sql, pNames, pvalues);
            return newProdID;
        }

        public void AddStudent(string ma, string ten, string sodt, string gioitinh, int namhoc, string tongiao, string quoctich,
                                        string cmd, string maphong)
        {
            string sql = "proc_ThemSinhVien";
            string[] pNames = { "@masv", "@tensv", "@sdt", "@gioitinh", "@namhoc", "@tongiao", "@quoctich", "@cmnd_cccd", "@maphong" };
            object[] pvalues = { ma, ten, sodt, gioitinh, namhoc, tongiao, quoctich, cmd, maphong };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }

        public void DeleteStudent(string ma)
        {
            string sql = "proc_XoaSinhVien";
            string[] pNames = { "@masv" };
            object[] pvalues = { ma };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }

        public void UpdateStudent(string ma, string ten, string sodt, string gioitinh, int namhoc, string tongiao, string quoctich,
                                        string cmd, string maphong)
        {
            string sql = "proc_SuaSinhVien";
            string[] pNames = { "@masv", "@tensv", "@sdt", "@gioitinh", "@namhoc", "@tongiao", "@quoctich", "@cmnd_cccd", "@maphong" };
            object[] pvalues = { ma, ten, sodt, gioitinh, namhoc, tongiao, quoctich, cmd, maphong };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
        public DataTable SearchStudent(string mssv)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MSSV", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = mssv;
            return cnn.executeReader("select * from func_DanhSachSinhVienTheoMSSV(@MSSV)", sqlParameters);
        }
    }
}
