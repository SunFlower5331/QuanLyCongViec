using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string manv { get; set; }
        public string hoten { get; set; }
        public DateTime ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string diachi { get; set; }
        public string didong { get; set; }
        public string email { get; set; }
        public string chucvu { get; set; }
        public string phongban { get; set; }
        public double luong { get; set; }
        public string trangthai { get; set; }
        public string trinhdohocvan { get; set; }
        public string loaihinh { get; set; }
        public int quyenhan { get; set; }
        public NhanVien(string manv, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string didong, string email, string chucvu, string phongban, double luong, string trangthai, string trinhdohocvan, string loaihinh, int quyenhan)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.didong = didong;
            this.email = email;
            this.chucvu = chucvu;
            this.phongban = phongban;
            this.luong = luong;
            this.trangthai = trangthai;
            this.trinhdohocvan = trinhdohocvan;
            this.loaihinh = loaihinh;
            this.quyenhan = quyenhan;
        }
        public NhanVien()
        {

        }
    }
}
