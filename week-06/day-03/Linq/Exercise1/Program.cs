using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            n.Where(i => (i % 2 == 0)).ToList().ForEach(i => Console.WriteLine(i));
            Console.ReadLine();
        }
    }
}
