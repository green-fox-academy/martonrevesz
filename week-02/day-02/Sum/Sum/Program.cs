using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumToSix = Sum(100);
			Console.WriteLine(sumToSix);
            Console.ReadLine();
        }

        static int Sum(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}
