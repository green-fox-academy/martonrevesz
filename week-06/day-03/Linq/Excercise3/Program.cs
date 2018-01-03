using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            numbers.Where(n => n > 0).Select(n => n * n).ToList().ForEach(n => Console.WriteLine(n));
            Console.ReadLine();
        }
    }
}
