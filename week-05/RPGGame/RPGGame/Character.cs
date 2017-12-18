using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Character
    {
        public static int CharacterCounter = 0;
        public string Name { get; private set; }
        public string ImageSource { get; set; }
        public int TileNumber { get;  set; } = 0;
        public int CharacterId { get; set; }

        public Character(string name, string imageSource)
        {
            Name = name;
            ImageSource = imageSource;
            CharacterId = CharacterCounter;
            CharacterCounter++;
        }


    }
}
