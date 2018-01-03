using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the uppercase characters in a string!

            string text = "Green Fox Academy corsacAsbest";

            text.Where(s => s.ToString()
                .ToUpper() == s.ToString())
                .ToList()
                .ForEach(s => Console.Write(s));
            Console.ReadLine();
        }
    }
}
