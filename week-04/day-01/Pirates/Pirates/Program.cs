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
            ship1.Captain.DrinkSomeRum();
            ship1.Captain.DrinkSomeRum();
            ship1.Captain.DrinkSomeRum();
            ship1.Captain.DrinkSomeRum();
            ship1.PrintShip();
            ship2.PrintShip();

            ship1.Battle(ship2);

            ship1.Captain.HowsItGoingMate();
            ship2.Captain.HowsItGoingMate();
            ship1.PrintShip();
            ship2.PrintShip();
            Console.ReadLine();
        }
    }
}
