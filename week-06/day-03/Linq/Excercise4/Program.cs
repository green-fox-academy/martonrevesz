using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 3, 9, 2, 8, 6, 5 };
            numbers.Where(n => n * n > 20).ToList().ForEach(n => Console.WriteLine(n));
            Console.ReadLine();
        }
    }
}
