using System;
using System.Collections.Generic;

namespace PallidaExamCandyShop
{
    internal class CandyShop
    {
        public int SugarAmount { get; set; }
        public double Money { get; set; } = 0;
        public List<Sweet> Storage = new List<Sweet>();

        public static string CANDY = "Candy";
        public static string LOLLIPOP = "Lollipop";

        public CandyShop(int sugarAmount)
        {
            SugarAmount = sugarAmount;
        }

        internal void CreateSweets(Sweet sweet)
        {
            Storage.Add(sweet);
            SugarAmount -= sweet.SugarNeed;        
        }

        internal void PrintInfo()
        {
            Console.WriteLine(String.Format("Inventory: {0} candies, {1} lollipops, Income: {2}$, Sugar: {3}gr", CountCandy(), CountLollipop(), Money, SugarAmount)); 
        }

        internal void Sell(string type, int quantity)
        {
            int sellCounter = 0;
            for (int i = 0; i < Storage.Count; i++)
            {
                if (type == "Candy" && Storage[i].GetType() == typeof(Candy))
                {
                    Money += Storage[i].Price;
                    Storage.Remove(Storage[i]);
                    sellCounter++;
                }
                else if (type == "Lollipop" && Storage[i].GetType() == typeof(Lollipop))
                {
                    Money += Storage[i].Price;
                    Storage.Remove(Storage[i]);
                    sellCounter++;
                }
            }
        }

        internal void Raise(double percentage)
        {
            foreach (Sweet sweet in Storage)
                sweet.Price *= (1 + percentage / 100);
        }

        internal void BuySugar(int amount)
        {
            SugarAmount += amount;
            Money -= 1/10.0 * amount;
            
        }

        public int CountCandy()
        {
            int counter = 0;
            foreach (Sweet sweet in Storage)
                if (sweet.GetType()== typeof(Candy))
                    counter++;
            return counter;
        }

        public int CountLollipop()
        {
            int counter = 0;
            foreach (Sweet sweet in Storage)
                if (sweet.GetType() == typeof(Lollipop))
                    counter++;
            return counter;
        }
    }
}