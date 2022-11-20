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
    public partial class frm_Toa : Form
    {
        public frm_TrangChu fmTrangChu;
        private Toa_BUS ToaBus;
        public frm_Phong frmPhong;
        public string tentoa = null;
        private string user;
        private string role;
        public frm_Toa(string user = "", string role = "")
        {
            InitializeComponent();
            ToaBus = new Toa_BUS();
            this.user = user;
            this.role = role;
        }
        public void LoadData()
        {
            dgvToa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvToa.DataSource = ToaBus.GetInformationToa();

        }
        private void frm_Toa_Load(object sender, EventArgs e)
        {
            LoadData();
            gbThongTinToa.Enabled = false;
        }
        public static bool them = true;
        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            gbThongTinToa.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnHuy.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                ToaBus.AddToa(txtTenToa.Text, int.Parse(txtSoPhong.Text), txtMaNQL.Text);
            }
            else
            {
                ToaBus.UpdateToa(txtTenToa.Text, int.Parse(txtSoPhong.Text), txtMaNQL.Text);
            }
            LoadData();
            txtTenToa.Clear();
            txtSoPhong.Clear();
            txtMaNQL.Clear();
            btnThem.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            btnLuu.Enabled = true;
            gbThongTinToa.Enabled = true;

            int r = dgvToa.CurrentCell.RowIndex;
            txtTenToa.Text = dgvToa.Rows[r].Cells[0].Value.ToString();
            txtSoPhong.Text = dgvToa.Rows[r].Cells[1].Value.ToString();
            txtMaNQL.Text = dgvToa.Rows[r].Cells[2].Value.ToString();
        }
        private void dgvToa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tentoa = Convert.ToString(dgvToa.CurrentRow.Cells["TenToa"].Value);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvToa.CurrentCell.RowIndex;
            string TenToa = dgvToa.Rows[r].Cells[0].Value.ToString();
            int sophongsd = ToaBus.CountPhong(TenToa);
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                if (sophongsd == 0)
                {
                    ToaBus.DeleteToa(TenToa);
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể xóa");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenToa.Clear();
            txtSoPhong.Clear();
            txtMaNQL.Clear();
            btnThem.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnChiTietToa_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPhong = new frm_Phong(user, role);
            frmPhong.matoa = tentoa;
            frmPhong.ShowDialog();
            this.Show();
        }


    }
}
