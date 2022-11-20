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
    public partial class frm_DangNhap : Form
    {
        public frm_TrangChu fmTrangChu;

        // HIỆU ỨNG//
        private int counter = 0;
        private int len = 0;
        private string txt;
        private bool showpass = true;
        //-----------//-----------//

        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            string password = txt_password.Text;
            string role;
            if (rdbtn_admin.Checked == true)
            {
                role = "Admin";
            }
            else
            {
                role = "Quản lý";
            }
            Tai_khoan tk = new Tai_khoan(user, password, role);
            DangNhap_BUS dnBUS = new DangNhap_BUS();
            int kq = dnBUS.Check_Tai_Khoan(tk);
            if (kq == 1)
            {
                txt_user.ResetText();
                txt_password.ResetText();
                rdbtn_admin.Refresh();
                rdbtn_quanly.Refresh();
                fmTrangChu = new frm_TrangChu(user, role);
                this.Hide();
                fmTrangChu.ShowDialog();
                this.Show();
            }
            else
            {
                lb_trangthai.Text = "Đăng nhập không thành công! Vui lòng kiểm tra lại !";
                txt_password.ResetText();
                rdbtn_admin.Refresh();
                rdbtn_quanly.Refresh();
                txt_password.Focus(); 
            }
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            txt_user.Focus();
            txt = label1.Text;
            len = txt.Length;
            label1.Text = "";
            timer1.Start();
        }

        private void txt_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                rdbtn_admin.Focus();
            }
            else if( e.KeyCode == Keys.Up)
            {
                txt_user.Focus();
            }    
        }

        private void rdbtn_admin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                btn_dangnhap.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txt_password.Focus();
            }
        }

        private void rdbtn_quanly_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                btn_dangnhap.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txt_password.Focus();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_user.ResetText();
            txt_password.ResetText();
            txt_user.Focus();
        }

        private void btn_hienpass_Click(object sender, EventArgs e)
        {
            if(showpass)
            {
                txt_password.UseSystemPasswordChar = false;
                btn_hienpass.Text = "Ẩn mật khẩu";
                btn_hienpass.Image = QuanLyKTX.Properties.Resources.private_password;
                showpass = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                btn_hienpass.Text = "Hiện mật khẩu";
                btn_hienpass.Image = QuanLyKTX.Properties.Resources.show_password;
                showpass = true;
            }    
        }
        private void frm_TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                counter = 0;
                label1.Text = "";
            }
            else
            {
                label1.Text = txt.Substring(0, counter);
                if (label1.ForeColor == Color.Blue)
                    label1.ForeColor = Color.Orange;
                else
                    label1.ForeColor = Color.Blue;
            }
        }
    }
}
