using System;
using System.Collections.Generic;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
            planetList.Insert(planetList.IndexOf("Uranus"), "Saturn");
            // print index of saturn
            Console.WriteLine(planetList[planetList.IndexOf("Saturn")]);
            Console.ReadLine();
        }
    }
}
