using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 4, 5 };
            Console.WriteLine("p1 has more element than p2: " + (p1.Length > p2.Length));
            Console.ReadLine();
        }
    }
}
