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
    public partial class frm_DoiMatKhau : Form
    {
        private string user;
        private string role;
        private bool showpass1 = true;

        public frm_DoiMatKhau(string user = "", string role = "")
        {
            InitializeComponent();
            this.user = user;
            this.role = role;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc là muốn đổi mật khẩu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txt_newpass.Text.Length >= 8)
                {
                    if (txt_newpass.Text == txt_confirmnewpass.Text)
                    {
                        DoiMatKhau_BUS dmkBUS = new DoiMatKhau_BUS();
                        if (txt_oldpassword.Text == dmkBUS.KiemTraMatKhauCu(user))
                        {
                            if (dmkBUS.DoiMatKhau(user, txt_newpass.Text) > 0)
                            {
                                if (MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                {
                                    this.Close();
                                }
                            }
                            else
                            {
                                lb_trangthai.Text = "Đã có lỗi xảy ra! Vui lòng kiểm tra lại!";
                            }
                        }
                        else
                        {
                            lb_trangthai.Text = "Mật khẩu cũ bạn vừa nhập không chính xác! Vui lòng nhập lại!";
                            txt_newpass.ResetText();
                            txt_confirmnewpass.ResetText();
                            txt_oldpassword.Focus();
                        }
                    }
                    else
                    {
                        lb_trangthai.Text = "Xác nhận mật khẩu mới không chính xác! Vui lòng nhập lại!";
                        txt_confirmnewpass.ResetText();
                        txt_confirmnewpass.Focus();
                    }
                }
                else
                {
                    lb_trangthai.Text = "Mật khẩu mới phải tối thiểu 8 ký tự!";
                    txt_newpass.ResetText();
                    txt_confirmnewpass.ResetText();
                    txt_newpass.Focus();
                }
            }    
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txt_user.Text = user;
            txt_user.Enabled = false;
            txt_oldpassword.Focus();
        }

        private void txt_user_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txt_oldpassword.Focus();
            }
        }

        private void txt_oldpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txt_newpass.Focus();
            }
        }

        private void txt_newpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txt_confirmnewpass.Focus();
            }
        }

        private void txt_confirmnewpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                btn_luu.Focus();
            }
        }

        private void btn_hienpass_Click_1(object sender, EventArgs e)
        {
            if (showpass1)
            {
                txt_oldpassword.UseSystemPasswordChar = false;
                txt_newpass.UseSystemPasswordChar = false;
                txt_confirmnewpass.UseSystemPasswordChar = false;
                btn_hienpass.Text = "Ẩn mật khẩu";
                btn_hienpass.Image = QuanLyKTX.Properties.Resources.private_password;
                showpass1 = false;
            }
            else
            {
                txt_oldpassword.UseSystemPasswordChar = true;
                txt_newpass.UseSystemPasswordChar = true;
                txt_confirmnewpass.UseSystemPasswordChar = true;
                btn_hienpass.Text = "Hiện mật khẩu";
                btn_hienpass.Image = QuanLyKTX.Properties.Resources.show_password;
                showpass1 = true;
            }
        }
    }
}
