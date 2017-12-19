using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public abstract class Character
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

        internal virtual void MoveRight(Area map, FoxDraw foxDraw)
        {
            if ((TileNumber % 10 != 9) && !map.WallTiles.Contains(TileNumber + 1))
            {
                double x = foxDraw.GetLeft(foxDraw.Tiles[CharacterId]) + 50;
                double y = foxDraw.GetTop(foxDraw.Tiles[CharacterId]);
                foxDraw.SetPosition(foxDraw.Tiles[CharacterId], x, y);
                TileNumber += 1;
            }
        }

        internal virtual void MoveLeft(Area map, FoxDraw foxDraw)
        {
            if ((TileNumber % 10 != 0) && !map.WallTiles.Contains(TileNumber - 1))
            {

                double x = foxDraw.GetLeft(foxDraw.Tiles[CharacterId]) - 50;
                double y = foxDraw.GetTop(foxDraw.Tiles[CharacterId]);
                foxDraw.SetPosition(foxDraw.Tiles[CharacterId], x, y);
                TileNumber -= 1;
            }
        }

        internal virtual void MoveUp(Area map, FoxDraw foxDraw)
        {
            if ((TileNumber / 10 != 0) && !map.WallTiles.Contains(TileNumber - 10))
            {
                double x = foxDraw.GetLeft(foxDraw.Tiles[CharacterId]);
                double y = foxDraw.GetTop(foxDraw.Tiles[CharacterId]) - 50;
                foxDraw.SetPosition(foxDraw.Tiles[CharacterId], x, y);
                TileNumber -= 10;
            }
        }

        internal virtual void MoveDown(Area map, FoxDraw foxDraw)
        {
            if ((TileNumber / 10 != 10) && !map.WallTiles.Contains(TileNumber + 10))
            {
                double x = foxDraw.GetLeft(foxDraw.Tiles[CharacterId]);
                double y = foxDraw.GetTop(foxDraw.Tiles[CharacterId]) + 50;
                foxDraw.SetPosition(foxDraw.Tiles[CharacterId], x, y);
                TileNumber += 10;
            }
        }

    }
}
