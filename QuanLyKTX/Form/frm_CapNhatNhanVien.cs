using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKTX.DAO;
using QuanLyKTX.Class;

namespace QuanLyKTX
{
    public partial class frm_CapNhatNhanVien : Form
    {
        public frm_NhanVien fmNhanVien;
        public string MaNhanVien = null;
        public string TenNhanVien = null;
        public string SoDienThoai = null;
        public string GioiTinh = null;
        public string TonGiao = null;
        public string QuocTich = null;
        public string CMND_CCCD = null;
        public string ChucVu = null;
        public string MaNQL = null;
        public int tmp;
        private string user;
        private string role;
        public frm_CapNhatNhanVien(string user = "", string role = "")
        {
            InitializeComponent();
            this.role = role;
            this.user = user;
        }
        private void frm_CapNhatNhanVien_Load(object sender, EventArgs e)
        {
            NhanVien_BUS nvBUS = new NhanVien_BUS();
            cbb_MaNQL.DataSource = nvBUS.Lay_Ma_Nguoi_Quan_Ly();
            cbb_MaNQL.DisplayMember = "MaNhanVien";
            cbb_MaNQL.ValueMember = "MaNhanVien";
            cbb_chucvu.DataSource = nvBUS.Lay_Chuc_Vu_Nhan_Vien();
            cbb_chucvu.DisplayMember = "ChucVu";
            cbb_chucvu.ValueMember = "ChucVu";
            if (tmp == 0)
            {
                txt_TenNhanVien.Focus();
                txt_MaNhanVien.Text = Tao_Ma_Nhan_Vien("NV");
                txt_MaNhanVien.ReadOnly = true; 
            }
            else
            {
                txt_MaNhanVien.Text = MaNhanVien;
                txt_TenNhanVien.Text = TenNhanVien;
                txt_SoDienThoai.Text = SoDienThoai;
                cbb_GioiTinh.Text = GioiTinh;
                txt_TonGiao.Text = TonGiao;
                txt_QuocTich.Text = QuocTich;
                txt_CMND.Text = CMND_CCCD;
                cbb_chucvu.Text = ChucVu;
                cbb_MaNQL.Text = MaNQL;
                txt_MaNhanVien.Focus();
            }    
        }

        public static string Tao_Ma_Nhan_Vien(string tiento)
        {
            var nvBUS = new NhanVien_BUS();
            string key = tiento;
            string hauto;
            string tmp = nvBUS.Lay_Ma_Nhan_Vien();
            hauto = tmp.Substring(2);
            int sonhanvien = Int32.Parse(hauto);
            sonhanvien++;
            hauto = sonhanvien.ToString();
            if (sonhanvien < 10)
                hauto = "0" + hauto;
            key = key + hauto;
            return key;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(tmp == 0)
            {
                NhanVien nv = new NhanVien(txt_MaNhanVien.Text, txt_TenNhanVien.Text, txt_SoDienThoai.Text, cbb_GioiTinh.Text,
                    txt_TonGiao.Text, txt_QuocTich.Text, txt_CMND.Text, cbb_chucvu.Text, cbb_MaNQL.Text);
                NhanVien_BUS nvBUS = new NhanVien_BUS();
                if (nvBUS.ThemNhanVien(nv) > 0)
                {
                    MessageBox.Show("Thêm mới nhân viên thành công!");
                    this.Close();
                }
                else MessageBox.Show("Có lỗi xảy ra!");
            }    
            else
            {
                NhanVien nv = new NhanVien(txt_MaNhanVien.Text, txt_TenNhanVien.Text, txt_SoDienThoai.Text, cbb_GioiTinh.Text,
                    txt_TonGiao.Text, txt_QuocTich.Text, txt_CMND.Text, cbb_chucvu.Text, cbb_MaNQL.Text);
                NhanVien_BUS nvBUS = new NhanVien_BUS();
                if (nvBUS.SuaNhanVien(nv) > 0)
                {
                    DialogResult dr;
                    dr = MessageBox.Show("Sửa đổi thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    DialogResult dr;
                    dr = MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbb_chucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_chucvu.Text == "Quản lý")
            {
                cbb_MaNQL.Text = txt_MaNhanVien.Text;
                cbb_MaNQL.Enabled = false;
            }
        }
    }
}
