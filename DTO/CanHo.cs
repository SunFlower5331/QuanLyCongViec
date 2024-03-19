using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CanHo
    {
        public string maCH { get; set; }
        public string maCD { get; set; }
        public DateTime ngaynhan { get; set; }
        public DateTime ngaychuyenvao { get; set; }
        public DateTime ngaychuyendi { get; set; }
        public float phidv { get; set; }
        public float phiql { get; set; }
        public float dienngaynhan { get; set; }
        public float nuocngaynhan { get; set; }
    }
}
