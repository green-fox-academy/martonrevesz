using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircrafts
{
    class Program
    {
        static void Main(string[] args)
        {
            var f16first = new F35();
            Console.WriteLine(f16first.Refill(16).ToString());
            Console.WriteLine(f16first.Fight());
            Console.WriteLine(f16first.GetStatus());
            Console.ReadLine();
        }
    }
}
