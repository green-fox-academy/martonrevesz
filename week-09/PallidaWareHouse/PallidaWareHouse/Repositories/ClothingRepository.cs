using PallidaWareHouse.Entities;
using PallidaWareHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaWareHouse.Repositories
{
    public class ClothingRepository
    {
        public ClothingRepository(ClothesContext clothesContext)
        {
            ClothesContext = clothesContext;
        }

        public ClothesContext ClothesContext { get; set; }

        public List<Clothing> GetAll()
        {
            return ClothesContext.Clothes.ToList();
        }
    }
}
