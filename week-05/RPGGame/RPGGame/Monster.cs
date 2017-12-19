using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Monster : Character
    {
        public Monster(int gameLevel, int tileNumber, int d6) : base(tileNumber)
        {
            Level = gameLevel;
            CurrentHP = gameLevel * 2 * d6 + d6;
            DefendPoint = gameLevel / 2 * d6 + d6 / 2;
            StrikePoint = gameLevel * d6 + gameLevel;
        }



        public void Move(Area map, FoxDraw foxDraw)
        {
            var random = new Random();
            var list = FindOptions(map, foxDraw);
            
            int directionNumber = random.Next(list.Count);
            if (list[directionNumber] == "right")
            {
                MoveRight(map, foxDraw);
            }
            else if (list[directionNumber] == "up")
            {
                MoveUp(map, foxDraw);
            }
            else if (list[directionNumber] == "down")
            {
                MoveDown(map, foxDraw);
            }
            else if (list[directionNumber] == "left")
            {
                MoveLeft(map, foxDraw);
            }
        }

        private List<string> FindOptions(Area map, FoxDraw foxDraw)
        {
            var list = new List<string>();
            if ((TileNumber % 10) != 9 && !map.WallTiles.Contains(TileNumber + 1))
            {
                list.Add("right");
            }
            if ((TileNumber % 10) != 0 && !map.WallTiles.Contains(TileNumber - 1))
            {
                list.Add("left");
            }
            if ((TileNumber / 10) != 0 && !map.WallTiles.Contains(TileNumber - 10))
            {
                list.Add("up");
            }
            if ((TileNumber / 10) != Area.HeightUnits - 1 && !map.WallTiles.Contains(TileNumber + 10))
            {
                list.Add("down");
            }
            return list;
        }
    }
}
