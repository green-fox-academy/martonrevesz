using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Boss : Monster
    {
        public Boss(int gameLevel, int TileNumber, int d6) : base(gameLevel, TileNumber, d6)
        {
            ImageSource = "./Assets/boss.png";
        }
    }
}
