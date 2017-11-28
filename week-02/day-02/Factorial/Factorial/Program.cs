using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorio(40));
        }

        static BigInteger Factorio(BigInteger n)
        {
            BigInteger factorial = 1;
            for (BigInteger i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
