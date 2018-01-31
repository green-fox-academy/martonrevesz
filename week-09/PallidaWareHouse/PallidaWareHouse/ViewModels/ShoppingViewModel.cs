using PallidaWareHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaWareHouse.ViewModels
{
    public class ShoppingViewModel
    {
        public List<Clothing> ClothesList { get; set;}
        public List<string> UniqueNames { get; set; }
        public List<string> UniqueSizes { get; set; }
    }
}
