using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            var tiger = new Animal();
            var zebra = new Animal();
            var lion = new Animal();
            var farm = new Farm(new List<Animal>() { tiger, lion, zebra }, 3);
            tiger.Eat();
            tiger.Eat();
            tiger.Drink();
            tiger.Play();
            zebra.Drink();
            lion.Eat();
            lion.Eat();
            Console.WriteLine("tiger: " + tiger.HungerValue + ", " + tiger.ThirstValue + "\n");
            Console.WriteLine("zebra: " + zebra.HungerValue + ", " + zebra.ThirstValue + "\n");
            Console.WriteLine("lion: " + lion.HungerValue + ", " + lion.ThirstValue + "\n");
            farm.Breed();
            farm.Breed();
            farm.Slaughter();
            for (int i = 0; i < farm.AnimalList.Count; i++)
            {
                Console.WriteLine(farm.AnimalList[i].HungerValue);
            }
            Console.ReadLine();
        }
    }
}
