using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var filteredNumbers = numbers.GroupBy(n => n)
                .ToDictionary(n => n.Key, n => n.Count());

            foreach (var item in filteredNumbers)
                Console.WriteLine($"{item.Key} {item.Value}");
            Console.ReadLine();
        }
    }
}
