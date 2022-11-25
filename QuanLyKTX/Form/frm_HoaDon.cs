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
    public partial class frm_HoaDon : Form
    {
        private HoaDon_BUS HdBUS;
        public frm_TrangChu fmtrangch;
        public string nv;
        private string user;
        private string role;
        public frm_HoaDon(string user = "", string role = "")
        {
            InitializeComponent();
            fmtrangch = new frm_TrangChu();
            nv = fmtrangch.MNV;
            HdBUS = new HoaDon_BUS();
            this.user = user;
            this.role = role;
        }
        public static bool them = true;
        public void LoadData()
        {
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.DataSource = HdBUS.GetAllInformation(nv);

            cbbMaPhong.DataSource = HdBUS.GetRoom(nv);
            cbbMaPhong.DisplayMember = "MaPhong";
            cbbMaPhong.ValueMember = "MaPhong";

            cbbMaPhongTK.DataSource = HdBUS.GetRoom(nv);
            cbbMaPhongTK.DisplayMember = "MaPhong";
            cbbMaPhongTK.ValueMember = "MaPhong";
        }
        string maHD = RandomString(7);

        public static String RandomString(int length)
        {
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return (str_build.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = maHD;
            cbTrangThai.Text = "Chưa thanh toán";
            cbTrangThai.Enabled = false;
            them = true;
            gbHoaDon.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnHuy.Enabled = true;
            btnLoad.Enabled = true;
            //btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                HdBUS.AddInvoice(maHD, cbbMaPhong.Text, cbTrangThai.Text, float.Parse(txtTienDien.Text),
                                                   float.Parse(txtTienNuoc.Text), dateTimePicker1.Value);
                gbHoaDon.Enabled = false;
            }
            else
            {
                HdBUS.UpdateInvoice(txtMaHD.Text, cbbMaPhong.Text, cbTrangThai.Text, float.Parse(txtTienDien.Text),
                                                   float.Parse(txtTienNuoc.Text), dateTimePicker1.Value);
            }
            LoadData();
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            //btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLoad.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            cbbMaPhong.Text = "";
            txtTienDien.Clear();
            txtTienNuoc.Clear();

            btnLoad.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            btnLuu.Enabled = true;
            gbHoaDon.Enabled = true;
            cbTrangThai.Enabled = true;
            int r = dgvHoaDon.CurrentCell.RowIndex;

            string trangthai = dgvHoaDon.Rows[r].Cells[2].Value.ToString();
            cbTrangThai.Text = trangthai;
            if (trangthai == "Đã thanh toán")
            {
                MessageBox.Show("Hóa đơn này đã được thanh toán !");
                txtMaHD.Clear();
                cbbMaPhong.Text = "";
                txtTienDien.Clear();
                txtTienNuoc.Clear();
                cbTrangThai.Enabled = false;
            }
            else
            {
                txtMaHD.Text = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
                cbbMaPhong.Text = dgvHoaDon.Rows[r].Cells[1].Value.ToString();
                txtTienDien.Text = dgvHoaDon.Rows[r].Cells[3].Value.ToString();
                txtTienNuoc.Text = dgvHoaDon.Rows[r].Cells[4].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dgvHoaDon.Rows[r].Cells[5].Value.ToString());
            }
            txtMaHD.Enabled = false;
            cbbMaPhong.Enabled = false;
            dateTimePicker1.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnLoad.Enabled = false;
            //vbBtnSua.Enabled = false;
            //btnXoa.Enabled = false;
            btnLoad.Enabled = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLocHDchuathanhtoan_Click(object sender, EventArgs e)
        {
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.DataSource = HdBUS.UnpaidInvoice(nv);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            txtSoLuong.Text = HdBUS.CountInvoiceRoom(nv, cbbMaPhongTK.Text).ToString();
            dgvHoaDon.DataSource = HdBUS.FillterInvoice(nv, cbbMaPhongTK.Text);

        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
