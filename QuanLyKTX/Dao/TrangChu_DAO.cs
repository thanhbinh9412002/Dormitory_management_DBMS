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
        // cho admin
        public int TimSoLuongNhanVienTheoGioiTinh(string gioitinh)
        {
            string spName = "[dbo].[func_SoLuongNhanVienTheoGioiTinh]"; 
            string[] pNames = { "@gioitinh"};
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
        public int TimSoLuongSinhVienTheoGioiTinh(string manv,string gioitinh)
        {
            int newProdID = 0;
            string sql = "[dbo].[func_SoLuongSinhVienTheoGioiTinh]";
            string[] pNames = { "@MaNQL", "@gioitinh" };
            object[] pvalues = { manv, gioitinh };
            newProdID = cnn.ExecuteStoredProcedure(sql, pNames, pvalues);
            return newProdID;
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
        public int SoPhongQuanLy(string manv, string trangthai)  // Tính số phòng mà nhân viên đó quản lý ( quản lý)
        {
            string spName = "[dbo].[func_DanhSachSoPhongTheoNhanVien]";
            string[] pNames = { "@MaNQL" , "@trangthai"};
            object[] pValues = { manv, trangthai};
            int count = cnn.ExecuteStoredProcedure(spName, pNames, pValues);
            return count;
        }
    }
}