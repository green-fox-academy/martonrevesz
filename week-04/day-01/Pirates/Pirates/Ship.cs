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
            Console.WriteLine("Captains consumed rum: " + Captain.DrinkLevel
                + "\nCaptain's state: " + Captain.State
                + "\nAlive pirates: " + Livecounter());
        }

        public bool Battle(Ship anotherShip)
        {
            int score = Livecounter() - Captain.DrinkLevel;
            int anotherShipsScore = anotherShip.Livecounter() - anotherShip.Captain.DrinkLevel;
            int losses = random.Next(Math.Min(Crew.Count, anotherShip.Crew.Count));

            if (score >= anotherShipsScore)
            {
                CelebrateBattle();
                anotherShip.LoseBattle(losses);
                return true;
            }
            anotherShip.CelebrateBattle();
            LoseBattle(losses);
            return false;
        }

        public void LoseBattle(int losses)
        {
            for (int i = 0; i < losses; i++)
            {
                Crew.Remove(Crew[0]);
            }
        }

        public void CelebrateBattle()
        {
            int drinkRum = random.Next(2, 6);

            for (int j = 0; j < drinkRum; j++)
            {
                Captain.DrinkSomeRum();
                for (int i = 0; i < Crew.Count; i++)
                {
                    Crew[i].DrinkSomeRum();
                }
            }
        }

        public int Livecounter()
        {
            int liveCounter = 0;
            foreach (var pirate in Crew)
            {
                if (pirate.State != "dead")
                {
                    liveCounter++;
                }
            }
            return liveCounter;
        }
    }
}
