using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCounter = new Counter(50);
            myCounter.Add(5);
            myCounter.Add();
            Console.WriteLine(myCounter.Get());
            myCounter.Reset();
            Console.WriteLine(myCounter.Get());
            Console.ReadLine();
        }
    }
}
