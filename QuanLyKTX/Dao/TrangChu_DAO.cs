using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKTX.DataProvider;
using QuanLyKTX.Class;
using System.Data.SqlClient;

namespace QuanLyKTX.DAO
{
    internal class TrangChu_DAO
    {
        private DBConnection cnn;
        public TrangChu_DAO()
        {
            cnn = new DBConnection();
        }
        public string TimMaNhanVien(string CMND_CCCD)
        {
            string MaNV = "";
            string sql = "[dbo].[func_TimKiemNhanVien_CMND]";
            string[] pNames = { "@CMND_CCCD"};
            object[] pvalues = { CMND_CCCD };
            MaNV = cnn.ExecuteStoredProcedureString(sql, pNames, pvalues);
            return MaNV;
        }
        public int TimSoLuongNhanVienTheoGioiTinh(string gioitinh)
        {
            string spName = "[dbo].[func_SoLuongNhanVienTheoGioiTinh]"; // Tên hàm
            // Tên các tham số trong thủ tục
            string[] pNames = { "@gioitinh"};
            // Giá trị tương ứng muốn gán cho từng tham số trên
            object[] pValues = {gioitinh};
            int count = cnn.ExecuteStoredProcedure(spName, pNames, pValues);
            return count;
        }
        public int TongSoNhanVien()
        {
            string spName = "[dbo].[func_TongSoNhanVien]";
            string[] pNames = { };
            object[] pValues = { };
            int count = cnn.ExecuteStoredProcedure(spName, pNames, pValues);
            return count;
        }
        public int TimSoLuongSinhVienTheoGioiTinh(string gioitinh)
        {
            string spName = "[dbo].[func_SoLuongSinhVienTheoGioiTinh_Admin]"; // Tên hàm
            // Tên các tham số trong thủ tục
            string[] pNames = { "@gioitinh" };
            // Giá trị tương ứng muốn gán cho từng tham số trên
            object[] pValues = { gioitinh };
            int count = cnn.ExecuteStoredProcedure(spName, pNames, pValues);
            return count;
        }
        public int TongSoSinhVien()
        {
            string spName = "[dbo].[func_TongSoSinhVien]";
            string[] pNames = { };
            object[] pValues = { };
            int count = cnn.ExecuteStoredProcedure(spName, pNames, pValues);
            return count;
        }
        public int TongSoTaiKhoan()
        {
            string spName = "[dbo].[func_TongSoTaiKhoan]";
            string[] pNames = { };
            object[] pValues = { };
            int count = cnn.ExecuteStoredProcedure(spName, pNames, pValues);
            return count;
        }
        public int TongSoToa()
        {
            string spName = "[dbo].[func_TongSoToa]";
            string[] pNames = { };
            object[] pValues = { };
            int count = cnn.ExecuteStoredProcedure(spName, pNames, pValues);
            return count;
        }
        public int SoLuongPhongConCho()
        {
            string spName = "[dbo].[func_TongSoPhongConCho]";
            string[] pNames = { };
            object[] pValues = { };
            int count = cnn.ExecuteStoredProcedure(spName, pNames, pValues);
            return count;
        }
        public int SoLuongPhongDu()
        {
            string spName = "[dbo].[func_TongSoPhongDay]";
            string[] pNames = { };
            object[] pValues = { };
            int count = cnn.ExecuteStoredProcedure(spName, pNames, pValues);
            return count;
        }
        public int SoLuongThietBiHong()
        {
            string spName = "[dbo].[func_SoThietBiHong]";
            string[] pNames = { };
            object[] pValues = { };
            int count = cnn.ExecuteStoredProcedure(spName, pNames, pValues);
            return count;
        }
        public int TongSoLuongThietBi()
        {
            string spName = "[dbo].[func_TongSoThietBi]";
            string[] pNames = { };
            object[] pValues = { };
            int count = cnn.ExecuteStoredProcedure(spName, pNames, pValues);
            return count;
        }
    }
}