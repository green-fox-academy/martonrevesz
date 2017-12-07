using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNthFibonacci(8));
            Console.ReadLine();
        }
        static int FindNthFibonacci(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            return FindNthFibonacci(n - 1) + FindNthFibonacci(n - 2);
        }
    }
}
