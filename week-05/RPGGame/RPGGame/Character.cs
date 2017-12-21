using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Character 
    {
        public static int CharacterCounter = Area.HeightUnits * Area.WidthUnits;
        public string ImageSource { get; set; }
        public int TileNumber { get;  set; }
        public int CharacterId { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int DefendPoint { get; set; }
        public int StrikePoint { get; set; }
        public int Level { get; set; }

        public Character(int tileNumber)
        {
            TileNumber = tileNumber;
            CharacterId = CharacterCounter;
            CharacterCounter++;
        }
    }
}
