using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKTX.DAO;
using QuanLyKTX.Class;

namespace QuanLyKTX
{
    internal class NhanVien_BUS
    {
        private NhanVien_DAO nvDAO;
        public NhanVien_BUS()
        {
            nvDAO = new NhanVien_DAO();
        }
        public DataTable DanhSachNhanVien()
        {
            return nvDAO.DanhSachNhanVien();
        }
        /*public DataTable TimNhanVien(string MaNV)
        {
            return nvDAO.TimNhanVien(MaNV);
        }*/
        public int SuaNhanVien(NhanVien nv)
        {
            return nvDAO.SuaNhanVien(nv);
        }
        public int ThemNhanVien(NhanVien nv)
        {
            return nvDAO.ThemNhanVien(nv);
        }
        public int XoaNhanVien(string MaNhanVien1)
        {
            return nvDAO.XoaNhanVien(MaNhanVien1);
        }
        public DataTable Lay_Ma_Nguoi_Quan_Ly()
        {
            return nvDAO.Lay_Ma_Nguoi_Quan_Ly();
        }
        public string Lay_Ma_Nhan_Vien()
        {
            return nvDAO.Lay_Ma_Nhan_Vien();
        }
        public DataTable NhanVien_Chucvu(string chucvu)
        {
            return nvDAO.NhanVien_Chucvu(chucvu);
        }
    }
}
