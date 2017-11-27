using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a side length: ");
            Double.TryParse(Console.ReadLine(), out double a);
            Console.WriteLine("the surface of your cube is: " + 6 * a * a);
            Console.WriteLine("the volume of your cube is: " + a * a * a);
        }
    }
}
