using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThings
{
    class FleetOfThings
    {
        static void Main(string[] args)
        {
            var fleet = new Fleet();
            var thing0 = new Thing("Get milk");
            var thing1 = new Thing("Remove the obstacles");
            var thing2 = new Thing("Stand up");
            var thing3 = new Thing("Eat lunch");
            var thing4 = new Thing("Eat lunch");
            fleet.Add(thing0);
            fleet.Add(thing1);
            fleet.Add(thing2);
            fleet.Add(thing3);
            thing2.Complete();
            thing3.Complete();
            Console.WriteLine(thing0.CompareTo(thing1));
            Console.WriteLine(thing2.CompareTo(thing0));
            Console.WriteLine(thing3.CompareTo(thing3));
            fleet.PrintFleet();
            Console.ReadLine();
        }
    }
}
