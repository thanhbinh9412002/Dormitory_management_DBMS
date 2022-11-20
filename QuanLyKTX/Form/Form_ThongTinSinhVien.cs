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
    public partial class Form_ThongTinSinhVien : Form
    {
        private string user;
        private string role;
        public string manhanvienfor = null;
        public Form_ThongTinSinhVien(string user = "", string role = "")
        {
            InitializeComponent();
            this.user = user;
            this.role = role;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form_ThongTinSinhVien_Load(object sender, EventArgs e)
        {
            MessageBox.Show(manhanvienfor);
        }
    }
}
