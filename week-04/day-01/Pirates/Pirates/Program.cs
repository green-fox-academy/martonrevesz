using System;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            var ship1 = new Ship();
            var ship2 = new Ship();
            ship1.FillShip();
            ship2.FillShip();
            ship1.PrintShip();
            ship2.PrintShip();
            ship1.Crew[3].Brawl(ship1.Captain);
            ship1.PrintShip();


            Console.ReadLine();
        }
    }
}
