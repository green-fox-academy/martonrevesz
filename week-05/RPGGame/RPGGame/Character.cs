using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public abstract class Character
    {
        public static int CharacterCounter = Map.HeightUnits * Map.WidthUnits;
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

        internal virtual void MoveRight(Map map, FoxDraw foxDraw)
        {
            if ((TileNumber % 10 != 9) && !map.WallTiles.Contains(TileNumber + 1))
            {
                double x = foxDraw.GetLeft(foxDraw.Tiles[CharacterId]) + 50;
                double y = foxDraw.GetTop(foxDraw.Tiles[CharacterId]);
                foxDraw.SetPosition(foxDraw.Tiles[CharacterId], x, y);
                TileNumber += 1;
            }
        }

        internal virtual void MoveLeft(Map map, FoxDraw foxDraw)
        {
            if ((TileNumber % 10 != 0) && !map.WallTiles.Contains(TileNumber - 1))
            {

                double x = foxDraw.GetLeft(foxDraw.Tiles[CharacterId]) - 50;
                double y = foxDraw.GetTop(foxDraw.Tiles[CharacterId]);
                foxDraw.SetPosition(foxDraw.Tiles[CharacterId], x, y);
                TileNumber -= 1;
            }
        }

        internal virtual void MoveUp(Map map, FoxDraw foxDraw)
        {
            if ((TileNumber / 10 != 0) && !map.WallTiles.Contains(TileNumber - 10))
            {
                double x = foxDraw.GetLeft(foxDraw.Tiles[CharacterId]);
                double y = foxDraw.GetTop(foxDraw.Tiles[CharacterId]) - 50;
                foxDraw.SetPosition(foxDraw.Tiles[CharacterId], x, y);
                TileNumber -= 10;
            }
        }

        internal virtual void MoveDown(Map map, FoxDraw foxDraw)
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
