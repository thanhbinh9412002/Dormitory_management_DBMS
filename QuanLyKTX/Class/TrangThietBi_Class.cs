using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.Class
{
    internal class TrangThietBi
    {
        private string mathietbi;
        private string tenthietbi;
        private int soluong;

        public TrangThietBi(string mathietbi, string tenthietbi, int soluong)
        {
            this.mathietbi = mathietbi;
            this.tenthietbi = tenthietbi;
            this.soluong = soluong;
        }

        public string MaThietBi { get => mathietbi; set => mathietbi = value; }
        public string TenThietBi { get => tenthietbi; set => tenthietbi = value; }
        public int SoLuong { get => soluong; set => soluong = value; }
    }
}
