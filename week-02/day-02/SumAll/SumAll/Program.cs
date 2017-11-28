using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ai = { 3, 4, 5, 6, 7 };
            Console.WriteLine(ArraySum(ai));
            Console.ReadLine();
        }

        static int ArraySum(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }
            return sum;
        }
    }
}
