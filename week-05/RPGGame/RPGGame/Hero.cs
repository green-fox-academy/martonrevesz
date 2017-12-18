using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Hero : Character
    {
        public Hero(string name, int tileNumber) : base(name,  tileNumber)
        {
            ImageSource = "./Assets/hero-down.png";
        }
    }
}
