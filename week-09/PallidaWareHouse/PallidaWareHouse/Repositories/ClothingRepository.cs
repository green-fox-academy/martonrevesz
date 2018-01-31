using PallidaWareHouse.Entities;
using PallidaWareHouse.Models;
using PallidaWareHouse.ViewModels;
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

        public ShoppingViewModel GetShoppingViewModel()
        {
            return new ShoppingViewModel()
            {
                ClothesList = GetAll(),
                UniqueNames = ClothesContext.Clothes.GroupBy(c => c.ItemName).Select(g => g.First().ItemName).ToList(),
                UniqueSizes = ClothesContext.Clothes.GroupBy(c => c.Size).Select(g => g.First().Size).ToList()
            };
        }
    }
}
