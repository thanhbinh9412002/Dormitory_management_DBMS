using QuanLyKTX.Bus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class frm_Phong : Form
    {
        private Phong_BUS PhongBUS;
        public frm_TrangChu fmtrangch;
        public frm_ChiTietPhong fmChiTietPhong;
        public frm_ThietBiTrongPhong fmThietBiTrongPhong;
        public string matoa;
        private string user;
        private string role;
        public string mp;
        public string manv;
        public frm_Phong(string user = "", string role = "")
        {
            InitializeComponent();
            fmtrangch = new frm_TrangChu();
            PhongBUS = new Phong_BUS();
            this.user = user;
            this.role = role;
        }
        public void LoadTextBox()
        {
            int SVHienTai = 0;
            txtSVHienTai.Text = SVHienTai.ToString();
            txtToa.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["Toa"].Value);
        }
        public void LoadDataAdmin()
        {
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.DataSource = PhongBUS.GetAllInformationToa(matoa);

        }
        public void LoadDataUser()
        {
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.DataSource = PhongBUS.GetAllInformation(manv);
            LoadTextBox();

        }
        private void frm_Phong_Load(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                LoadDataAdmin();
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                LoadDataUser();
                gbThongTinPhong.Enabled = false;
            }    
        }
        public static bool them = true;
        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            gbThongTinPhong.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                PhongBUS.AddPhong(txtMaPhong.Text, txtToa.Text, int.Parse(txtSVHienTai.Text), int.Parse(txtSVToiDa.Text));
            }
            LoadDataUser();
            txtMaPhong.Clear();
            txtSVHienTai.Clear();
            txtSVToiDa.Clear();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaPhong = Convert.ToString(dgvPhong.CurrentRow.Cells["MaPhong"].Value);
            int svhientai = Convert.ToInt32(dgvPhong.CurrentRow.Cells["SoLuongSinhVienHienTai"].Value);
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                if (svhientai == 0)
                {
                    PhongBUS.DeletePhong(MaPhong);
                    MessageBox.Show("Xóa thành công");
                    LoadDataUser();
                }
                else
                {
                    MessageBox.Show("Không thể xóa");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaPhong.Clear();
            txtSVHienTai.Clear();
            txtSVToiDa.Clear();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPhong.DataSource = PhongBUS.GetAllInformationToa(matoa);
            }
            else
            {
                dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPhong.DataSource = PhongBUS.GetAllInformation(manv);
            }
        }

        private void btnTimKiemPhongDay_Click(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPhong.DataSource = PhongBUS.PhongDay(matoa);
            }
            else
            {
                string tentoa = txtToa.Text;
                dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPhong.DataSource = PhongBUS.PhongDay(tentoa);
            }
        }

        private void btnPhongConCho_Click(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPhong.DataSource = PhongBUS.PhongConCho(matoa);
            }
            else
            {
                string tentoa = txtToa.Text;
                dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPhong.DataSource = PhongBUS.PhongConCho(tentoa);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                mp = Convert.ToString(dgvPhong.CurrentRow.Cells["MaPhong"].Value);
                matoa = Convert.ToString(dgvPhong.CurrentRow.Cells["Toa"].Value);
            }
        }
        private void btnChiTietPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmChiTietPhong = new frm_ChiTietPhong();
            fmChiTietPhong.maphong = mp;
            fmChiTietPhong.manql = manv;
            fmChiTietPhong.toa = matoa;
            fmChiTietPhong.ShowDialog();
            this.Show();
        }

        private void btnThietBiTrongPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmThietBiTrongPhong = new frm_ThietBiTrongPhong();
            fmThietBiTrongPhong.maphong = mp;
            fmThietBiTrongPhong.manql = manv;
            fmThietBiTrongPhong.toa = matoa;
            fmThietBiTrongPhong.ShowDialog();
            this.Show();
        }
    }
}
