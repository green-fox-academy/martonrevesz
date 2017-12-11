using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            var sharpie1 = new Sharpie("red", 2.3);
            var sharpie2 = new Sharpie("blue", 1.8);
            sharpie1.Use();
            sharpie1.Use();
            sharpie2.Use();
            Console.WriteLine(sharpie1.InkAmount + ", " + sharpie1.Color);
            Console.WriteLine(sharpie2.InkAmount + ", " + sharpie2.Width);
            Console.ReadLine();
        }
    }
}
