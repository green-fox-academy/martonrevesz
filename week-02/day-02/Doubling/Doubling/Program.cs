using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            int ak = 123;
            Console.WriteLine(Doubling(ak));
            Console.ReadLine();
        }

        static int Doubling(int number)
        {
            return number * 2;
        }
    }
}
