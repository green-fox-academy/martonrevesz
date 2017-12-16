using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    class Ship

    {
        Random random = new Random();
        public const int ShipMaxCapacity = 40;

        public List<Pirate> Crew { get; private set; }
        public Pirate Captain { get; private set; }

        public void FillShip()
        {
            Captain = new Pirate();
            Crew = new List<Pirate>();
            int piratesNumber = random.Next(ShipMaxCapacity);
            for (int i = 0; i < piratesNumber; i++)
            {
                Crew.Add(new Pirate());
            }
        }

        public void PrintShip()
        {
            int liveCounter = 0;
            foreach (var pirate in Crew)
            {
                if (pirate.State != "dead")
                {
                    liveCounter++;
                }
            }      
            Console.WriteLine("Captains consumed rum: " + Captain.DrinkLevel
                + "\nCaptain's state: " + Captain.State
                + "\nAlive pirates: " + liveCounter);
        }
    }
}
