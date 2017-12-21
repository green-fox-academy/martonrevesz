using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Monster : Character
    {
        Random random = new Random();

        public Monster(int gameLevel, int tileNumber, int d6) : base(tileNumber)
        {
            int levelDecide = random.Next(10);
            if (levelDecide < 5)
            {
                Level = gameLevel;
            }
            else if (levelDecide < 9)
            {
                Level = gameLevel + 1;
            }
            else
            {
                Level = gameLevel + 2;
            }
            CurrentHP = gameLevel * 2 * d6;
            DefendPoint = gameLevel / 2 * d6;
            StrikePoint = gameLevel * 2 * d6;
        }
    }
}
