using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddNumbersToN(9));
            Console.ReadLine();
        }
        static int AddNumbersToN(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n + AddNumbersToN(n - 1);
        }
    }
}
