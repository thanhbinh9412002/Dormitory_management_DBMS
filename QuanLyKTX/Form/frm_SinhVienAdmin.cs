using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKTX.Bus;

namespace QuanLyKTX
{
    public partial class frm_SinhVienAdmin : Form
    {
        private SinhVienAdmin_BUS SvAdminBUS;
        private string user;
        private string role;
        public frm_SinhVienAdmin(string user = "", string role = "")
        {
            InitializeComponent();
            SvAdminBUS = new SinhVienAdmin_BUS();
            this.user = user;
            this.role = role;
        }

        private void frm_SinhVienAdmin_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = SvAdminBUS.GetAllInformationSV();
            txtSoLuong.Enabled = false;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string gioitinh = cbbGioiTinh.Text;
            if (gioitinh == "Nam")
            {
                dgvSinhVien.DataSource = SvAdminBUS.FillterStudentMale();
            }
            else
            {
                dgvSinhVien.DataSource = SvAdminBUS.FillterStudentFemale();
            }
            string manql = "Admin";
            txtSoLuong.Text = SvAdminBUS.CountStudentGender(manql, gioitinh).ToString();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
