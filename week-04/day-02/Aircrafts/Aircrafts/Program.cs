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
            var carrier1 = new Carrier(9000, 300);
            carrier1.AddAircraft(f16First);
            carrier1.AddAircraft(f16Second);
            carrier1.AddAircraft(f35First);
            carrier1.AddAircraft(f35First);

            var carrier2 = new Carrier(200, 3000);
            var f35FirstC2 = new F35();
            carrier2.AddAircraft(f35FirstC2);

            carrier1.Fill();
            carrier2.Fill();
            carrier1.Fight(carrier2);
            Console.WriteLine(carrier1.GetStatus());
            Console.WriteLine(carrier2.GetStatus());
            Console.ReadLine();
        }
    }
}
