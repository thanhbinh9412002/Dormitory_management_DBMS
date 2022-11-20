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
    public partial class frm_ThietBiTrongPhong : Form
    {
        private ThietBiTrongPhong_BUS TbBUS;
        public frm_Phong frmPhong;
        public string maphong = null;
        public string toa;
        public string manql;
        public frm_ThietBiTrongPhong()
        {
            InitializeComponent();
            frmPhong = new frm_Phong(); 
            //maphong = frmPhong.mp;
            TbBUS = new ThietBiTrongPhong_BUS();
        }
        public void LoadData()
        {

            dgvThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThietBi.DataSource = TbBUS.GetAllInformation(maphong);
        }
        public static bool them = true;
        private void frm_ThietBiTrongPhong_Load(object sender, EventArgs e)
        {
            LoadData();
            gbThongTinThietBi.Enabled = false;
            btnLuu.Enabled = false;
        }
        public bool check = true;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check)
            {
                txtMaPhong.Text = maphong;
            }else
            {
                txtMaPhong.Text = cbbMaPhongTimKiem.Text;
            }
            txtMaPhong.Enabled = false;

            cbbMaThietBi.DataSource = TbBUS.GetIdEq();
            cbbMaThietBi.DisplayMember = "MaThietBi";
            cbbMaThietBi.ValueMember = "MaThietBi";

            them = true;
            gbThongTinThietBi.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnHuy.Enabled = true;
            btnLoad.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                TbBUS.AddEqRoom(cbbMaThietBi.Text, txtMaPhong.Text, 0, int.Parse(txtSoLuongTot.Text), int.Parse(txtSoLuongToiDa.Text));
            }
            else
            {
                TbBUS.UpdateEqRoom(cbbMaThietBi.Text, txtMaPhong.Text, int.Parse(txtSoLuongHong.Text), int.Parse(txtSoLuongTot.Text), int.Parse(txtSoLuongToiDa.Text));
            }
            if (check)
            {
                LoadData();
            }
            else
            {
                dgvThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvThietBi.DataSource = TbBUS.GetAllInformation(cbbMaPhongTimKiem.Text);
            }
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLoad.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvThietBi.CurrentCell.RowIndex;
            string matb = dgvThietBi.Rows[r].Cells[0].Value.ToString();
            string maphong = dgvThietBi.Rows[r].Cells[1].Value.ToString();
            TbBUS.DeleteEqRoom(matb, maphong);
            MessageBox.Show("Xóa thành công");
            if (check)
            {
                LoadData();
            }
            else
            {
                dgvThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvThietBi.DataSource = TbBUS.GetAllInformation(cbbMaPhongTimKiem.Text);
            }
            btnLoad.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cbbMaThietBi.Text = "";
            txtMaPhong.Clear();
            txtSoLuongHong.Clear();
            txtSoLuongToiDa.Clear();
            txtSoLuongTot.Clear();

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
            gbThongTinThietBi.Enabled = true;

            int r = dgvThietBi.CurrentCell.RowIndex;
            cbbMaThietBi.Text = dgvThietBi.Rows[r].Cells[0].Value.ToString();
            txtMaPhong.Text = dgvThietBi.Rows[r].Cells[1].Value.ToString();
            txtSoLuongHong.Text = dgvThietBi.Rows[r].Cells[2].Value.ToString();
            txtSoLuongTot.Text = dgvThietBi.Rows[r].Cells[3].Value.ToString();
            txtSoLuongToiDa.Text = dgvThietBi.Rows[r].Cells[4].Value.ToString();

            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLoad.Enabled = true;
            txtMaPhong.Enabled = false;
            cbbMaThietBi.Enabled = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            cbbMaPhongTimKiem.DataSource = TbBUS.GetComboBox(toa);
            cbbMaPhongTimKiem.DisplayMember = "MaPhong";
            cbbMaPhongTimKiem.ValueMember = "MaPhong";
        }

        private void cbbMaThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string matb = cbbMaThietBi.Text;
            txtTenTb.Text = TbBUS.TenThietBi(matb);
        }

        private void cbbMaPhongTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            check = false;
            dgvThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThietBi.DataSource = TbBUS.GetAllInformation(cbbMaPhongTimKiem.Text);
            txtMaPhong.Text = cbbMaPhongTimKiem.Text;
        }
    }
}
