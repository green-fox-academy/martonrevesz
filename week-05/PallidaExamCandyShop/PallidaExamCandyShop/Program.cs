using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PallidaExamCandyShop
{
    class Program
    {
        static void Main(string[] args)
        {            
            var candyShop = new CandyShop(300);
            candyShop.CreateSweets(new Candy());
            candyShop.CreateSweets(new Candy());
            candyShop.CreateSweets(new Lollipop());
            candyShop.CreateSweets(new Lollipop());
            candyShop.PrintInfo();
            candyShop.Sell(CandyShop.CANDY, 1);
            candyShop.PrintInfo();
            candyShop.Raise(5);
            candyShop.Sell(CandyShop.LOLLIPOP, 1);
            candyShop.PrintInfo();
            candyShop.BuySugar(300);
            candyShop.PrintInfo();
            Console.ReadLine();
        }
    }
}
