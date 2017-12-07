using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDown(15);
            Console.ReadLine();
        }

        static void CountDown(int n)
        {
            Console.WriteLine(n);
            if (n > 0)
            {
                CountDown(n - 1);
            }
            
        }
    }
}
