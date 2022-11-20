using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKTX.BUS;
using QuanLyKTX.Class;

namespace QuanLyKTX
{
    public partial class frm_TrangThietBi : Form
    {
        private string user;
        private string role;
        public int sukien;
        public frm_TrangThietBi(string user = "", string role = "")
        {
            InitializeComponent();
            this.user = user;
            this.role = role;
        }

        private void frm_TrangThietBi_Load(object sender, EventArgs e)
        {
            LoadData();
            btn_luu.Enabled = false;
        }

        private void LoadData()
        {
            var ttbBUS = new TrangThietBi_BUS();
            DataTable dt = ttbBUS.DanhDachThietBi();
            this.dtgv_trangthietbi.DataSource = dt;
        }

        private void dtgv_trangthietbi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txt_mathietbi.Text = Convert.ToString(dtgv_trangthietbi.CurrentRow.Cells["MaThietBi"].Value);
                txt_tenthietbi.Text = Convert.ToString(dtgv_trangthietbi.CurrentRow.Cells["TenThietBi"].Value);
                txt_soluong.Text = Convert.ToString(dtgv_trangthietbi.CurrentRow.Cells["TongSoLuong"].Value);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var ttbBUS = new TrangThietBi_BUS();
            sukien = 0;
            txt_tenthietbi.Focus();
            txt_mathietbi.Text = Tao_Ma_Thiet_Bi("TB");
            txt_mathietbi.ReadOnly = true;
            txt_tenthietbi.ReadOnly = false;
            txt_soluong.ReadOnly = false;
            btn_luu.Enabled = true;
        }

        public static string Tao_Ma_Thiet_Bi(string tiento)
        {
            var ttbBUS = new TrangThietBi_BUS();
            string key = tiento;
            string hauto;
            string tmp = ttbBUS.TimMaThietBiLonNhat();
            hauto = tmp.Substring(2);
            int sotietbi = Int32.Parse(hauto);
            sotietbi++;
            hauto = sotietbi.ToString();
            key = key + hauto;
            return key;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            sukien = 1;
            txt_tenthietbi.Focus();
            txt_mathietbi.ReadOnly = true;
            txt_tenthietbi.ReadOnly = false;
            txt_soluong.ReadOnly = false;
            btn_luu.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(txt_mathietbi.Text != "")
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn xóa thiết bị tên '" + txt_tenthietbi.Text + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    TrangThietBi_BUS ttbBUS = new TrangThietBi_BUS();
                    if (ttbBUS.XoaThietBi(txt_mathietbi.Text) > 0)
                    {
                        MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_mathietbi.ResetText();
                        txt_tenthietbi.ResetText();
                        txt_soluong.ResetText();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
            }    
            else
            {
                MessageBox.Show("Bạn chưa chọn thiết bị cần xóa! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            TrangThietBi tb = new TrangThietBi(txt_mathietbi.Text, txt_tenthietbi.Text, int.Parse(txt_soluong.Text));
            var ttbBUS = new TrangThietBi_BUS();
            if(txt_tenthietbi.Text != "")
            {
                if(txt_soluong.Text != "")
                {
                    if(sukien == 0)
                    {
                        if (ttbBUS.ThemThietBi(tb) > 0)
                        {
                            MessageBox.Show("Thêm  mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_mathietbi.ResetText();
                            txt_tenthietbi.ResetText();
                            txt_soluong.ResetText();
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Đã có lỗi xảy ra! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (ttbBUS.SuaThietBi(tb) > 0)
                        {
                            MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_mathietbi.ResetText();
                            txt_tenthietbi.ResetText();
                            txt_soluong.ResetText();
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Đã có lỗi xảy ra! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }   
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập số lượng! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên thiết bị! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
