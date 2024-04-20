using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTCV
    {
        public string maCV { get; set; }
        public string maNV { get; set; }
        public string trangthai { get; set; }
        public DateTime thoiGianHoanThanh { get; set; }
        public DateTime songayhethan { get; set; }
        public string Tuychonchiase { get; set; }
        public DateTime ngaycapnhat { get; set; }
        public CTCV(string maCV, string maNV, string trangthai, DateTime thoiGianHoanThanh, DateTime songayhethan, string tuychonchiase, DateTime ngaycapnhat)
        {
            this.maCV = maCV;
            this.maNV = maNV;
            this.trangthai = trangthai;
            this.thoiGianHoanThanh = thoiGianHoanThanh;
            this.songayhethan = songayhethan;
            this.Tuychonchiase = tuychonchiase;
            this.ngaycapnhat = ngaycapnhat;
        }
    }
}
