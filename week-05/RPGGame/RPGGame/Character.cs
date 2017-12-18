using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public abstract class Character
    {
        public static int CharacterCounter = 0;
        public string Name { get; private set; }
        public string ImageSource { get; set; }
        public int TileNumber { get;  set; }
        public int CharacterId { get; set; }

        public Character(string name, int tileNumber)
        {
            Name = name;
            TileNumber = tileNumber;
            CharacterId = CharacterCounter;
            CharacterCounter++;
        }


    }
}
