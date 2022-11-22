using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKTX.Dao;
using System.Data;

namespace QuanLyKTX.Bus
{
    public class SinhVienAdmin_BUS
    {
        private SinhVienAdmin_DAO SvAdminDAO;
        public SinhVienAdmin_BUS()
        {
            SvAdminDAO = new SinhVienAdmin_DAO();
        }
        public DataTable GetAllInformationSV()
        {
            return SvAdminDAO.GetAllInformationSV();
        }
        public DataTable FillterStudentMale()
        {
            return SvAdminDAO.FillterStudentMale();
        }
        public DataTable FillterStudentFemale()
        {
            return SvAdminDAO.FillterStudentFemale();
        }
        public int CountStudentGender(string manv, string gioitinh)
        {
            return SvAdminDAO.CountStudentGender(manv, gioitinh);
        }
    }
}
