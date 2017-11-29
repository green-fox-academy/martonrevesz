using System;
using System.Collections.Generic;

namespace elementFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            if (list.Contains(7))
            {
                Console.WriteLine("Hoorray");
            }
            else
            {
                Console.WriteLine("Nooooooo");
            }

            //other solution
            if (list.IndexOf(7) > 0)
            {
                Console.WriteLine("Hoorray");
            }
            else
            {
                Console.WriteLine("Nooooooo");
            }
            Console.ReadLine();
        }
    }
}
