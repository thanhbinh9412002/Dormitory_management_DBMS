using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKTX.BUS;

namespace QuanLyKTX
{
    public partial class frm_NhanVien : Form
    {
        public frm_TrangChu fmTrangChu;
        public frm_CapNhatNhanVien fmCapNhat;
        public frm_NhanVien fmNhanVien;
        public string MaNhanVien1 = null;
        public string TenNhanVien1 = null;
        public string SoDienThoai1 = null;
        public string GioiTinh1 = null;
        public string TonGiao1 = null;
        public string QuocTich1 = null;
        public string CMND_CCCD1 = null;
        public string ChucVu1 = null;
        public string MaNQL1 = null;
        public int sukien;
        private string user;
        private string role;
        public string manhanvienfor = null;
        public frm_NhanVien(string user = "", string role = "")
        {
            InitializeComponent();
            this.user = user;
            this.role = role; 
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmCapNhat = new frm_CapNhatNhanVien(user, role);
            fmCapNhat.tmp = 0;
            fmCapNhat.ShowDialog();
            this.Show();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            fmCapNhat = new frm_CapNhatNhanVien(user, role);
            if (sukien == 1)
            {
                fmCapNhat.MaNhanVien = MaNhanVien1;
                fmCapNhat.TenNhanVien = TenNhanVien1;
                fmCapNhat.SoDienThoai = SoDienThoai1;
                fmCapNhat.GioiTinh = GioiTinh1;
                fmCapNhat.TonGiao = TonGiao1;
                fmCapNhat.QuocTich = QuocTich1;
                fmCapNhat.CMND_CCCD = CMND_CCCD1;
                fmCapNhat.ChucVu = ChucVu1;
                fmCapNhat.MaNQL = MaNQL1;
                fmCapNhat.tmp = 1;
                this.Hide();
                fmCapNhat.ShowDialog();
                this.Show();
            }
            else 
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần chỉnh sửa. Mời chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(sukien == 1)
            {
                NhanVien_BUS nvBUS = new NhanVien_BUS();
                DialogResult dr;
                dr = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên tên '" + TenNhanVien1 + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (nvBUS.XoaNhanVien(MaNhanVien1) > 0)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần xóa. Mời chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            fmCapNhat = new frm_CapNhatNhanVien();
            fmTrangChu = new frm_TrangChu();
            LoadData();
        }
        public void LoadData()
        {
            var nvBUS = new NhanVien_BUS();
            DataTable nv = nvBUS.DanhSachNhanVien();
            this.dgvNhanVien.DataSource = nv;
            cbbChucVu.DataSource = nvBUS.Lay_Chuc_Vu_Nhan_Vien();
            cbbChucVu.DisplayMember = "ChucVu";
            cbbChucVu.ValueMember = "ChucVu";
        }

        private void dgvNhanVien_CellClick(object senderGrid, DataGridViewCellEventArgs f)
        {
            if (f.RowIndex >= 0 && f.ColumnIndex >= 0)
            {
                MaNhanVien1 = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaNhanVien"].Value);
                TenNhanVien1 = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenNhanVien"].Value);
                SoDienThoai1 = Convert.ToString(dgvNhanVien.CurrentRow.Cells["SoDienThoai"].Value);
                GioiTinh1 = Convert.ToString(dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value);
                TonGiao1 = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TonGiao"].Value);
                QuocTich1 = Convert.ToString(dgvNhanVien.CurrentRow.Cells["QuocTich"].Value);
                CMND_CCCD1 = Convert.ToString(dgvNhanVien.CurrentRow.Cells["CMND_CCCD"].Value);
                ChucVu1 = Convert.ToString(dgvNhanVien.CurrentRow.Cells["ChucVu"].Value);
                MaNQL1 = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaNQL"].Value);
                sukien = 1;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string chucvu = cbbChucVu.Text;
            var nvBUS = new NhanVien_BUS();
            DataTable nv = nvBUS.NhanVien_Chucvu(chucvu);
            this.dgvNhanVien.DataSource = nv;
        }

        private void btn_resest_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
