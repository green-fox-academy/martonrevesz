using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Monster : Character
    {
        static Random random = new Random();

        public Monster(int gameLevel, int tileNumber, int d6) : base(tileNumber)
        {
            int levelDecide = random.Next(10);
            if (levelDecide < 5)
            {
                Level = gameLevel;
            }
            else if (levelDecide < 9)
            {
                Level = gameLevel + 1;
            }
            else
            {
                Level = gameLevel + 2;
            }
            CurrentHP = gameLevel * 2 * d6;
            DefendPoint = gameLevel / 2 * d6;
            StrikePoint = gameLevel * 2 * d6;
        }



        public void Move(Area map, FoxDraw foxDraw)
        {
            var list = FindOptions(map);
            
            int directionNumber = random.Next(0,list.Count);

            if (list[directionNumber] == "right")
            {
                MoveRight(map, foxDraw);
            }
            else if (list[directionNumber] == "up")
            {
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

        private List<string> FindOptions(Area map)
        {
            var list = new List<string>();
            if ((TileNumber % 10) != 9 && !map.WallTiles.Contains(TileNumber + 1))
            {
                list.Add("right");
            }
            if ((TileNumber / 10) != 0 && !map.WallTiles.Contains(TileNumber - 10))
            {
                list.Add("up");
            }
            if ((TileNumber / 10) != 10 && !map.WallTiles.Contains(TileNumber + 10))
            {
                list.Add("down");
            }
            if ((TileNumber % 10) != 0 && !map.WallTiles.Contains(TileNumber - 1))
            {
                list.Add("left");
            }
            return list;
        }
    }
}
