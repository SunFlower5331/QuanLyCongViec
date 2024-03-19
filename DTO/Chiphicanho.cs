using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Chiphicanho
    {
        public string MaCD { get; set; }
        public string MaCH { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public float SoDien { get; set; }
        public float SoNuoc { get; set; }
        public float PhiDien { get; set; }
        public float PhiNuoc { get; set; }
        public float CongNo { get; set; }
        public float TongPhiQuanLy { get; set; }
        public float TongPhiDichVu { get; set; }
        public float TongChiPhiDienNuoc { get; set; }
    }
}
