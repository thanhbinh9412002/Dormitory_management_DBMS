using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.Class
{
    internal class Tai_khoan
    {
        private string user;
        private string password;
        private string role;

        public Tai_khoan(string user, string password, string role)
        {
            this.user = user;
            this.password = password;
            this.role = role;
        }
    
        public string Username { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}