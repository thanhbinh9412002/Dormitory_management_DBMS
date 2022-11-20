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
    public partial class frm_SinhVien : Form
    {
        private SinhVien_BUS SvBUS;
        public frm_TrangChu fmtrangch;
        public string nv;
        public frm_SinhVien()
        {
            InitializeComponent();
            fmtrangch = new frm_TrangChu();
            nv = fmtrangch.MNV;
            SvBUS = new SinhVien_BUS();
        }
        public static bool them = true;
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        public void LoadData()
        {
            cbbMaPhong.DataSource = SvBUS.GetRoom(nv);
            cbbMaPhong.DisplayMember = "MaPhong";
            cbbMaPhong.ValueMember = "MaPhong";

            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.DataSource = SvBUS.GetAllInformation(nv);

        }

        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
            gbThongTinSinhVien.Enabled = false;
            btnLuu.Enabled = false;
            MessageBox.Show(nv);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            gbThongTinSinhVien.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnHuy.Enabled = true;
            btnLoad.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            ClearTextBoxes();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (chkNam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            if (them == true)
            {
                SvBUS.AddStudent(txtMaSV.Text, txtHoTen.Text, txtSoDT.Text, gioitinh, int.Parse(txtNamHoc.Text),
                                                   txtTonGiao.Text, txtQuocTich.Text, txtSoCMND.Text, cbbMaPhong.Text);
            }
            else
            {
                SvBUS.UpdateStudent(txtMaSV.Text, txtHoTen.Text, txtSoDT.Text, gioitinh, int.Parse(txtNamHoc.Text),
                                                   txtTonGiao.Text, txtQuocTich.Text, txtSoCMND.Text, cbbMaPhong.Text);
            }
            LoadData();
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLoad.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvSinhVien.CurrentCell.RowIndex;
            string masv = dgvSinhVien.Rows[r].Cells[0].Value.ToString();
            SvBUS.DeleteStudent(masv);
            MessageBox.Show("Xóa thành công");
            LoadData();
            btnLoad.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtSoDT.Clear();
            txtNamHoc.Clear();
            txtTonGiao.Clear();
            txtQuocTich.Clear();
            txtSoCMND.Clear();
            cbbMaPhong.Text = "";

            btnLoad.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            btnLuu.Enabled = true;
            gbThongTinSinhVien.Enabled = true;

            int r = dgvSinhVien.CurrentCell.RowIndex;
            txtMaSV.Text = dgvSinhVien.Rows[r].Cells[0].Value.ToString();
            txtHoTen.Text = dgvSinhVien.Rows[r].Cells[1].Value.ToString();
            txtSoDT.Text = dgvSinhVien.Rows[r].Cells[2].Value.ToString();
            string gioitinh = dgvSinhVien.Rows[r].Cells[3].Value.ToString();
            if (gioitinh == "Nam")
            {
                chkNam.Checked = true;
            }
            else
            {
                chkNu.Checked = true;
            }
            txtNamHoc.Text = dgvSinhVien.Rows[r].Cells[4].Value.ToString();
            txtTonGiao.Text = dgvSinhVien.Rows[r].Cells[5].Value.ToString();
            txtQuocTich.Text = dgvSinhVien.Rows[r].Cells[6].Value.ToString();
            txtSoCMND.Text = dgvSinhVien.Rows[r].Cells[7].Value.ToString();
            cbbMaPhong.Text = dgvSinhVien.Rows[r].Cells[8].Value.ToString();
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLoad.Enabled = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSVTimKiem.Text;
            dgvSinhVien.DataSource = SvBUS.SearchStudent(mssv);
            btnLoad.Enabled = true;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {

        }
    }
}
