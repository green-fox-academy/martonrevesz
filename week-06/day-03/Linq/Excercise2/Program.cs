using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            double average = numbers.Where(n => n % 2 == 1 || n % 2 == -1)
                .Average();
            Console.WriteLine(average);
            Console.ReadLine();
        }
    }
}
