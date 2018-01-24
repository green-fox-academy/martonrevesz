using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cargos.Models
{
    public class Cargo
    {
        public int Caliber25 { get; set; }
        public int Caliber30 { get; set; }
        public int Caliber50 { get; set; }
        public string ShipStatus { get; set; } = "empty";
        public bool Ready { get; set; }
    }
}
