using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumDigit(2017));
            Console.ReadLine();
        }

        static int SumDigit(int n)
        {
            if (n < 10)
            {
                return n;
            }
            return (n % 10) + SumDigit(n / 10);          
        }
    }
}
