using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            var tiger = new Animal();
            var zebra = new Animal();
            tiger.Eat();
            tiger.Eat();
            tiger.Drink();
            tiger.Play();
            zebra.Drink();
            Console.WriteLine(tiger.HungerValue + ", " +  tiger.ThirstValue + "\n");
            Console.WriteLine(zebra.HungerValue + ", " +  zebra.ThirstValue + "\n");
            Console.ReadLine();
        }
    }
}
