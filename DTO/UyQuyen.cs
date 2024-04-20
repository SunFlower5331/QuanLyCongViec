using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UyQuyen
    {
      
        public string maCV {  get; set; }
        public string ten {  get; set; }
        public string phongban {  get; set; }
        public string hoten {  get; set; }
  
        public string maNV {  get; set; }
        public string thoiGianHoanThanh {  get; set; }
        public int songayhethan { get; set; }
        public string Tuychonchiase { get; set; }
        public string trangthai { get; set; }
        public DateTime ngayBanGiao { get; set; }
    public UyQuyen(string maCV,string ten,string phongban,string hoten,string maNV,string thoiGianHoanThanh,string Tuychonchiase,string trangthai, DateTime ngayBanGiao)
        {
            this.maCV = maCV;
            this.ten = ten;
            this.phongban = phongban;
            this.hoten = hoten;
            this.maNV = maNV;
            this.thoiGianHoanThanh = thoiGianHoanThanh;
            this.Tuychonchiase = Tuychonchiase;
            this.trangthai = trangthai;
            this.ngayBanGiao = ngayBanGiao;
    

        }

    }
}
