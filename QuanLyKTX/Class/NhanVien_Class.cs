using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.Class
{
    internal class NhanVien
    {
        private string MaNhanVien;
        private string TenNhanVien;
        private string SoDienThoai;
        private string GioiTinh;
        private string TonGiao;
        private string QuocTich;
        private string CMND_CCCD;
        private string ChucVu;
        private string MaNQL;

        public NhanVien(string MaNhanVien, string TenNhanVien, string SoDienThoai, string GioiTinh, 
            string TonGiao, string QuocTich, string CMND_CCCD, string ChucVu, string MaNQL)
        {
            this.MaNhanVien = MaNhanVien;
            this.TenNhanVien = TenNhanVien;
            this.SoDienThoai = SoDienThoai;
            this.GioiTinh = GioiTinh;
            this.TonGiao = TonGiao;
            this.QuocTich = QuocTich;
            this.CMND_CCCD = CMND_CCCD;
            this.ChucVu = ChucVu;
            this.MaNQL = MaNQL;
        }

/*        public NhanVien(string TenNhanVien, string SoDienThoai, string GioiTinh,
            string TonGiao, string QuocTich, string CMND_CCCD, string ChucVu, string MaNQL)
        {
            this.TenNhanVien = TenNhanVien;
            this.SoDienThoai = SoDienThoai;
            this.GioiTinh = GioiTinh;
            this.TonGiao = TonGiao;
            this.QuocTich = QuocTich;
            this.CMND_CCCD = CMND_CCCD;
            this.ChucVu = ChucVu;
            this.MaNQL = MaNQL;
        }*/

        public string MaNV { get => MaNhanVien; set => MaNhanVien = value; }
        public string TenNV { get => TenNhanVien; set => TenNhanVien = value; }
        public string SoDT { get => SoDienThoai; set => SoDienThoai = value; }
        public string Gioitinh { get => GioiTinh; set => GioiTinh = value; }
        public string Tongiao { get => TonGiao; set => TonGiao = value; }
        public string Quoctich { get => QuocTich; set => QuocTich = value; }
        public string CMND { get => CMND_CCCD; set => CMND_CCCD = value; }
        public string CV { get => ChucVu; set => ChucVu = value; }
        public string Manql { get => MaNQL; set => MaNQL = value; }
    }
}
