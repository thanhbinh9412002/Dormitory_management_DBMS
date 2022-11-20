using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyKTX.Class;
using QuanLyKTX.DataProvider;

namespace QuanLyKTX.DAO
{
    internal class NhanVien_DAO
    {
        private DBConnection conn;
        public NhanVien_DAO()
        {
            conn = new DBConnection();
        }

        public DataTable DanhSachNhanVien()
        {
            string spName = "[dbo].[proc_Danhsachnhanvien]";
            return conn.ExecuteProcedureDatatableNoPara(spName);
        }
        /*public DataTable TimNhanVien(string MaNV)
        {
            const string sql = "select * from NhanVien where MaNhanVien = @MaNV";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dt = new DataTable();
            dt = conn.executeReader(sql, sqlParameters);
            return dt;
        }*/
        public int SuaNhanVien(NhanVien nv)
        {
            string spName = "[dbo].[proc_SuaNhanVien]";
            string[] pNames = { "@manv", "@tennv", "@sdtnv", "@gioitinhnv", "@tongiaonv", "@quoctichnv", "@cmnd_cccd_nv", "@cv", "@manql" };
            object[] pValues = {nv.MaNV, nv.TenNV, nv.SoDT, nv.Gioitinh, nv.Tongiao, nv.Quoctich, nv.CMND, nv.CV, nv.Manql};
            int count = conn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count;
        }
        public int ThemNhanVien(NhanVien nv)
        {
            string spName = "[dbo].[proc_ThemNhanVien]";
            string[] pNames = { "@manv", "@tennv", "@sdtnv", "@gioitinhnv", "@tongiaonv", "@quoctichnv", "@cmnd_cccd_nv", "@cv", "@manql" };
            object[] pValues = { nv.MaNV, nv.TenNV, nv.SoDT, nv.Gioitinh, nv.Tongiao, nv.Quoctich, nv.CMND, nv.CV, nv.Manql };
            int count = conn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count;
        }
        public int XoaNhanVien(string MaNhanVien1)
        {
            string spName = "[dbo].[proc_XoaNhanVien]";
            string[] pNames = {"@manv"};
            object[] pValues = {MaNhanVien1};
            int count = conn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count ;
        }
        public DataTable Lay_Ma_Nguoi_Quan_Ly()
        {
            string spName = "[dbo].[proc_LayMaNGQL]";
            return conn.ExecuteProcedureDatatableNoPara(spName);
        }
        public string Lay_Ma_Nhan_Vien()
        {
            string spName = "[dbo].[func_LayMaNV]";
            string[] pNames = { };
            object[] pValues = { };
            string count = conn.ExecuteStoredProcedureString(spName, pNames, pValues);
            return count;
        }

        public DataTable NhanVien_Chucvu(string chucvu)
        {
            string sql = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            if (chucvu == "Bảo vệ")
            {
                sql = "SELECT * FROM [dbo].[view_NhanVienBaoVe]";
            }
            return conn.executeReader(sql, sqlParameters);
        }
    }
}
