using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var station = new Station(220);
            var car = new Car();
            station.Refill(car);
            Console.WriteLine(station.GasAmount);
            Console.WriteLine(car.GasAmount);
            Console.ReadLine();
        }
    }
}
