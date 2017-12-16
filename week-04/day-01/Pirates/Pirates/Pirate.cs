using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    class Pirate
    {
        Random random = new Random();

        public int DrinkLevel { get; private set; } = 0;
        public string State { get; private set; } = "sober";


        public void DrinkSomeRum()
        {
            if (State == "dead")
            {
                Console.WriteLine("He is dead.");
            }
            else
            {
                DrinkLevel++;
            }
        }

        public void HowsItGoingMate()
        {
            if (State == "dead")
            {
                Console.WriteLine("He is dead.");
            }
            else if (DrinkLevel < 5)
            {
                Console.WriteLine("Pour me anudder!");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                State = "passed out";
            }
        }

        public void Die()
        {
            State = "dead";
        }

        public void Brawl(Pirate anotherPirate)
        {
            int randomNumber = random.Next(3);

            if (randomNumber == 0)
            {
                Die();
            }
            else if (randomNumber == 1)
            {
                anotherPirate.Die();
            }
            else
            {
                State = "passed out";
                anotherPirate.State = "passed out";
            }
        }
    }
}
