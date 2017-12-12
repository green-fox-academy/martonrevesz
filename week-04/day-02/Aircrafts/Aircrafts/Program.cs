using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircrafts
{
    class Program
    {
        static void Main(string[] args)
        {
                var f16First = new F16();
                var f16Second = new F16();
                var f35First = new F35();
                var carrier1 = new Carrier(0, 300);
                carrier1.AddAircraft(f16First);
                carrier1.AddAircraft(f16Second);
                carrier1.AddAircraft(f35First);
                carrier1.AddAircraft(f35First);
                carrier1.Fill();
                Console.WriteLine(f16First.GetStatus());
                Console.WriteLine(f16Second.GetStatus());
                Console.WriteLine(f35First.GetStatus());
                Console.WriteLine(carrier1.AmmoStore);
                Console.ReadLine();
        }
    }
}
