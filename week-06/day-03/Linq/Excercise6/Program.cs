using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "good morning green fox academy";

            Dictionary<char, int> charFrequency = text.GroupBy(n => n)
                .ToDictionary(n => n.Key, n => n.Count());

            foreach (var item in charFrequency)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
            Console.ReadLine();
        }
    }
}
