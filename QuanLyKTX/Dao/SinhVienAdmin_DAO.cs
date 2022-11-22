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
    public class SinhVienAdmin_DAO
    {
        private DBConnection cnn = null;
        public SinhVienAdmin_DAO()
        {
            cnn = new DBConnection();
        }
        public DataTable GetAllInformationSV()
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return cnn.executeReader("SELECT * FROM [dbo].[func_DanhSachSinhVien]()", sqlParameters);
        }
        public DataTable FillterStudentMale()
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            string sql = "SELECT * FROM [dbo].[view_SinhVienNam]";
            return cnn.executeReader(sql, sqlParameters);
        }
        public DataTable FillterStudentFemale()
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            string sql = "SELECT * FROM [dbo].[view_SinhVienNu]";
            return cnn.executeReader(sql, sqlParameters);
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
    }
}
