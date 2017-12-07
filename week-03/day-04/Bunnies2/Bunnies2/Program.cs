using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBunnies(19));
            Console.ReadLine();
        }

        static int CountBunnies(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n % 2 == 0)
            {
                return 3 + CountBunnies(n - 1);
            }
            return 2 + CountBunnies(n - 1);
        }
    }
}
