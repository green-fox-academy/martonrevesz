using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI",
                "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS", "ACADEMI" };

            cities.Where(c => c.StartsWith("A") && c.EndsWith("I"))
                .ToList()
                .ForEach(c => Console.WriteLine(c));
            Console.ReadLine();
        }
    }
}
