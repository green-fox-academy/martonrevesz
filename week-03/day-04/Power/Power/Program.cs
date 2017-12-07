using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = 3;
            int exponent = 6;
            Console.WriteLine(Power(baseNumber, exponent));
            Console.ReadLine();
        }

        static int Power(int baseNumber, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            return baseNumber * Power(baseNumber, exponent - 1);
        }
    }
}
