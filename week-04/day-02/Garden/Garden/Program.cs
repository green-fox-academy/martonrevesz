using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            var garden = new Garden();
            var yellowFlower = new Flower("yellow");
            var blueFlower = new Flower("blue");
            var orangeTree = new Tree("orange");
            var purpleTree = new Tree("purple");
            garden.AddPlant(yellowFlower);
            garden.AddPlant(blueFlower);
            garden.AddPlant(purpleTree);
            garden.AddPlant(orangeTree);
            garden.PrintStatus();
            garden.Water(40);
            garden.PrintStatus();
            garden.Water(70);
            garden.PrintStatus();
            Console.ReadLine();
        }
    }
}
