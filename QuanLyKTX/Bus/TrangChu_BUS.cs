using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKTX.DAO;
using QuanLyKTX.Class;


namespace QuanLyKTX.BUS
{
    internal class TrangChu_BUS
    {
        private TrangChu_DAO tcDAO;
        public TrangChu_BUS()
        {
            tcDAO = new TrangChu_DAO();
        }
        public string TimMaNhanVien(string CMND_CCCD)
        {
            return tcDAO.TimMaNhanVien(CMND_CCCD);
        }
        public int TimSoLuongNhanVienTheoGioiTinh(string gioitinh)
        {
            return tcDAO.TimSoLuongNhanVienTheoGioiTinh(gioitinh);
        }
        public int TongSoNhanVien()
        {
            return tcDAO.TongSoNhanVien();
        }
        public int TimSoLuongSinhVienTheoGioiTinh(string manv,string gioitinh)
        {
            return tcDAO.TimSoLuongSinhVienTheoGioiTinh(manv,gioitinh);
        }
        public int TongSoSinhVien()
        {
            return tcDAO.TongSoSinhVien();
        }
        public int TongSoTaiKhoan()
        {
            return tcDAO.TongSoTaiKhoan();
        }
        public int TongSoToa()
        {
            return tcDAO.TongSoToa();
        }
        public int SoLuongPhongConCho()
        {
            return tcDAO.SoLuongPhongConCho();
        }
        public int SoLuongPhongDu()
        {
            return tcDAO.SoLuongPhongDu();
        }
        public int SoLuongThietBiHong()
        {
            return tcDAO.SoLuongThietBiHong();
        }
        public int TongSoLuongThietBi()
        {
            return tcDAO.TongSoLuongThietBi();
        }
        public int SoPhongQuanLy(string manv, string trangthai)
        {
            return tcDAO.SoPhongQuanLy(manv, trangthai);
        }
    }
}
