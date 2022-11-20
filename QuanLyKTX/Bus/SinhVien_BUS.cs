using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKTX.Class;
using QuanLyKTX.Dao;

namespace QuanLyKTX.Bus
{
    public class SinhVien_BUS
    {
        private SinhVien_DAO SvDAO;
        public SinhVien_BUS()
        {
            SvDAO = new SinhVien_DAO();
        }
        public DataTable GetRoom(string manv)
        {
            return SvDAO.GetRoom(manv);
        }
        public DataTable GetAllInformation(string manv)
        {
            return SvDAO.GetAllInformation(manv);
        }
        public DataTable FillterStudent(string manv, string gioitinh)
        {
            return SvDAO.FillterStudent(manv, gioitinh);
        }
        public int CountStudentGender(string manv, string gioitinh)
        {
            return SvDAO.CountStudentGender(manv, gioitinh);
        }

        public void AddStudent(string ma, string ten, string sodt, string gioitinh, int namhoc, string tongiao, string quoctich,
                                        string cmd, string maphong)
        {
            SvDAO.AddStudent(ma, ten, sodt, gioitinh, namhoc, tongiao, quoctich, cmd, maphong);
        }

        public void DeleteStudent(string ma)
        {
            SvDAO.DeleteStudent(ma);
        }
        public void UpdateStudent(string ma, string ten, string sodt, string gioitinh, int namhoc, string tongiao, string quoctich,
                                        string cmd, string maphong)
        {
            SvDAO.UpdateStudent(ma, ten, sodt, gioitinh, namhoc, tongiao, quoctich, cmd, maphong);
        }

        public DataTable SearchStudent(string mssv)
        {
            return SvDAO.SearchStudent(mssv);
        }
    }
}
