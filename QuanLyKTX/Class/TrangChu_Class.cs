using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX
{
    internal class TrangChu
    {
        private string user;
        private string password;
        private string role;

        TrangChu(string user, string password, string role)
        {
            this.user = user;
            this.password = password;
            this.role = role;
        }
        public string User { get => user; set => user = value; }
    }
}
