using PallidaWareHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaWareHouse.ViewModels
{
    public class SummaryViewModel
    {
        public Clothing Clothes { get; set; }
        public int Quantity { get; set; }
        public double SubTotal { get; set; }
    }
}
