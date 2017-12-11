using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Dice>();
            for (int i = 0; i < 6; i++)
            {
                list.Add(new Dice());
            }
            for (int i = 0; i < 6; i++)
            {
                list[i].Roll();
                if (list[i].GetCurrentNumber() != 6)
                {
                    list[i].ReRoll();
                }
                Console.WriteLine(list[i].GetCurrentNumber());
            }
            Console.ReadLine();
        }
    }
}
