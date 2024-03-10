using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CanHo
    {
        public int maCH { get; set; }
        public int maCD { get; set; }
        public DateTime ngaynhan { get; set; }
        public DateTime ngaychuyenvao { get; set; }
        public DateTime ngaychuyendi { get; set; }
        public float phidv { get; set; }
        public float phiql { get; set; }
        public float dien_nuoc_ngaynhan { get; set; }
    }
}
