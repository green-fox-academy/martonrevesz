using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTwoALot
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = double.Parse(Console.ReadLine());
            if (myDouble < 0)
            {
                Console.WriteLine("Not enough");
            }
            else if (myDouble == 1)
            {
                Console.WriteLine("One");
            }
            else if (myDouble == 2)
            {
                Console.WriteLine("Two");
            }
            else
            {
                Console.WriteLine("Lot");
            }
    }
}
