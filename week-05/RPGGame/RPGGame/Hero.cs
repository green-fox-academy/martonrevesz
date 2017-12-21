using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RPGGame
{
    public class Hero : Character
    {
        public Hero(int tileNumber, int d6) : base(  tileNumber)
        {
            ImageSource = "./Assets/hero-down.png";
            MaxHP = 30;
            CurrentHP = Math.Min(20 + 3 * d6, MaxHP);
            DefendPoint = 2 * d6;
            StrikePoint = 5 + d6;
            Level = 1;
        }
    }
}
