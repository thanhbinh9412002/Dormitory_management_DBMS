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
    public partial class frm_XemPhong : Form
    {
        private XemPhong_BUS XemPhongBus;
        public int sukien;
        public int sukien1;
        public frm_XemPhong()
        {
            InitializeComponent();
            XemPhongBus = new XemPhong_BUS();
        }
        public void LoadDataPhongDay()
        {
            dgvXemToa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvXemToa.DataSource = XemPhongBus.PhongDay();
        }
        public void LoadDataPhongConTrong()
        {
            dgvXemToa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvXemToa.DataSource = XemPhongBus.PhongConCho();
        }
        private void frm_XemPhong_Load(object sender, EventArgs e)
        {
            if (sukien1 == 1)
            {
                LoadDataPhongDay();
            }
            else
            {
                LoadDataPhongConTrong();
            }    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
