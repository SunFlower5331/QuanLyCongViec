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
        public CTCV(string maCV, string maNV, string trangthai, DateTime thoiGianHoanThanh, DateTime songayhethan, string tuychonchiase)
        {
            this.maCV = maCV;
            this.maNV = maNV;
            this.trangthai = trangthai;
            this.thoiGianHoanThanh = thoiGianHoanThanh;
            this.songayhethan = songayhethan;
            Tuychonchiase = tuychonchiase;
        }
    }
}
