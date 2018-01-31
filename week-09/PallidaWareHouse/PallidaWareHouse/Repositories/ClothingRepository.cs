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

        public SummaryViewModel CalculateSummary(string itemName, string size, int quantity)
        {
            Clothing clothing = ClothesContext.Clothes.FirstOrDefault(c => c.ItemName.Equals(itemName) && c.Size.Equals(size));
            return new SummaryViewModel()
            {
                Clothes = clothing,
                Quantity = quantity,
                SubTotal = clothing.UnitPrice * quantity
            };
        }

        public List<Clothing> GetQueryList(int? price, string type)
        {
            if (type.Equals("equal"))
            {
                return ClothesContext.Clothes.Where(c => c.UnitPrice == price).ToList();
            }
            else if (type.Equals("higher"))
            {
                return ClothesContext.Clothes.Where(c => c.UnitPrice > price).ToList();
            }
            else if (type.Equals("lower"))
            {
                return ClothesContext.Clothes.Where(c => c.UnitPrice < price).ToList();
            }
            var list = new List<Clothing>();
            return list;
        }
    }
}