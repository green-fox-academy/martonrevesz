using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Boss : Character
    {
        public Boss(string name, int TileNumber) : base(name, TileNumber)
        {
            ImageSource = "./Assets/boss.png";
        }
    }
}
