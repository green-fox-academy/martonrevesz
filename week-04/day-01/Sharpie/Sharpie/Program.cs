using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var sharpie1 = new Sharpie("red", 2.3);
            var sharpie2 = new Sharpie("blue", 1.8);
            var sharpie3 = new Sharpie("green", 2.1);
            var sharpieSet1 = new SharpieSet(new List<Sharpie>() { sharpie1, sharpie2, sharpie3 });
            sharpie1.Use();
            sharpie1.Use();
            Console.WriteLine(sharpieSet1.CountUsable());
            sharpie1.Use();
            Console.WriteLine(sharpieSet1.CountUsable());
            sharpieSet1.RemoveTrash();
            sharpie2.Use();
            Console.WriteLine(sharpieSet1.CountUsable());
            Console.WriteLine(sharpie1.InkAmount + ", " + sharpie1.Color);
            Console.WriteLine(sharpie2.InkAmount + ", " + sharpie2.Width);
            Console.ReadLine();
        }
    }
}
