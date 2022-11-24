
namespace QuanLyKTX
{
    partial class frm_DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.rdbtn_admin = new System.Windows.Forms.RadioButton();
            this.rdbtn_quanly = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_trangthai = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_hienpass = new System.Windows.Forms.Button();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(134, 69);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(158, 26);
            this.txt_user.TabIndex = 2;
            this.txt_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_user_KeyDown);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(134, 112);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(158, 26);
            this.txt_password.TabIndex = 3;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // rdbtn_admin
            // 
            this.rdbtn_admin.AutoSize = true;
            this.rdbtn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_admin.Location = new System.Drawing.Point(91, 152);
            this.rdbtn_admin.Name = "rdbtn_admin";
            this.rdbtn_admin.Size = new System.Drawing.Size(115, 24);
            this.rdbtn_admin.TabIndex = 4;
            this.rdbtn_admin.TabStop = true;
            this.rdbtn_admin.Text = "Quản trị viên";
            this.rdbtn_admin.UseVisualStyleBackColor = true;
            this.rdbtn_admin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbtn_admin_KeyDown);
            // 
            // rdbtn_quanly
            // 
            this.rdbtn_quanly.AutoSize = true;
            this.rdbtn_quanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_quanly.Location = new System.Drawing.Point(212, 152);
            this.rdbtn_quanly.Name = "rdbtn_quanly";
            this.rdbtn_quanly.Size = new System.Drawing.Size(80, 24);
            this.rdbtn_quanly.TabIndex = 5;
            this.rdbtn_quanly.TabStop = true;
            this.rdbtn_quanly.Text = "Quản lý";
            this.rdbtn_quanly.UseVisualStyleBackColor = true;
            this.rdbtn_quanly.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbtn_quanly_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ KÝ TÚC XÁ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trangthai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_trangthai.Location = new System.Drawing.Point(11, 240);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(363, 62);
            this.lb_trangthai.TabIndex = 12;
            this.lb_trangthai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.rdbtn_quanly);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Controls.Add(this.rdbtn_admin);
            this.panel1.Controls.Add(this.btn_hienpass);
            this.panel1.Controls.Add(this.lb_trangthai);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.btn_dangnhap);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 311);
            this.panel1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::QuanLyKTX.Properties.Resources.Key_icon;
            this.button2.Location = new System.Drawing.Point(82, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 26);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::QuanLyKTX.Properties.Resources.account_icon;
            this.button1.Location = new System.Drawing.Point(82, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 26);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.LightCoral;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Image = global::QuanLyKTX.Properties.Resources.Restart_icon;
            this.btn_reset.Location = new System.Drawing.Point(257, 194);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(117, 43);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "Đặt lại";
            this.btn_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_hienpass
            // 
            this.btn_hienpass.BackColor = System.Drawing.Color.LightCoral;
            this.btn_hienpass.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_hienpass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_hienpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienpass.Image = global::QuanLyKTX.Properties.Resources.show_password;
            this.btn_hienpass.Location = new System.Drawing.Point(134, 194);
            this.btn_hienpass.Name = "btn_hienpass";
            this.btn_hienpass.Size = new System.Drawing.Size(117, 43);
            this.btn_hienpass.TabIndex = 8;
            this.btn_hienpass.Text = "Hiển thị mật khẩu";
            this.btn_hienpass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hienpass.UseVisualStyleBackColor = false;
            this.btn_hienpass.Click += new System.EventHandler(this.btn_hienpass_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.LightCoral;
            this.btn_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.Image = global::QuanLyKTX.Properties.Resources.Login_icon;
            this.btn_dangnhap.Location = new System.Drawing.Point(11, 194);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(117, 43);
            this.btn_dangnhap.TabIndex = 7;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(384, 310);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DangNhap";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_TrangChu_FormClosing);
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.RadioButton rdbtn_admin;
        private System.Windows.Forms.RadioButton rdbtn_quanly;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Button btn_hienpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_trangthai;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

