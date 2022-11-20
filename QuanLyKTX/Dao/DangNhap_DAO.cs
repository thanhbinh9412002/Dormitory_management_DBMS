using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyKTX.DataProvider;
using QuanLyKTX.Class;

namespace QuanLyKTX.DAO
{
    internal class DangNhap_DAO
    {
        private DBConnection cnn = null ;
        public DangNhap_DAO()
        {
            cnn = new DBConnection();
        }
        public int Check_Tai_Khoan(Tai_khoan tk)
        {
            string spName = "[dbo].[func_KiemTraDangNhap]"; // Tên hàm
            // Tên các tham số trong thủ tục
            string[] pNames = { "@TenTK", "@MK", "@Vaitro" };
            // Giá trị tương ứng muốn gán cho từng tham số trên
            object[] pValues = { tk.Username, tk.Password, tk.Role };
            int count = cnn.ExecuteStoredProcedure(spName, pNames, pValues);
            return count;
        }
        
    }
}
