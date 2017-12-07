using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBunnies(133));
            Console.ReadLine();
        }

        static int CountBunnies(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return 2 + CountBunnies(n - 1);
        }
    }
}
