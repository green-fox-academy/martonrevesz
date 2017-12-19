using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Area

    {
        public const int WidthUnits = 10;
        public const int HeightUnits = 11;
        public FoxDraw MyFoxDraw { get; private set; }
        public List<int> WallTiles { get; private set; } = new List<int>()
            { 3, 5, 13, 15, 17, 18, 21, 22, 23, 25, 27, 28, 35, 40,
            41, 42, 43, 45, 46, 47, 48, 51, 53, 58, 61, 63, 65, 66,
            68, 75, 76, 78, 81, 82, 83, 88, 93, 95, 96, 98, 101, 103, 105 };
        public List<int> FreeTiles { get; set; }

        public Area(FoxDraw myFoxDraw)
        {
            MyFoxDraw = myFoxDraw;
            FreeTiles = new List<int>();
            for (int i = 0; i < WidthUnits * HeightUnits; i++)
            {
                if (!WallTiles.Contains(i))
                {
                    FreeTiles.Add(i);
                }          
            }            
        }

        public void DrawMap()
        {
            for (int i = 0; i < HeightUnits; i++)
            {
                for (int j = 0; j < WidthUnits; j++)
                {
                    if (WallTiles.Contains(10 * i + j))
                    {
                        MyFoxDraw.AddImage("./Assets/wall.png", 50 * j, 50 * i);
                    }
                    else
                    {
                        MyFoxDraw.AddImage("./Assets/floor.png", 50 * j, 50 * i);
                    }
                }
            }
        }

        public void DrawCharacter(Character character)
        {
            MyFoxDraw.AddImage(character.ImageSource, ((character.TileNumber % WidthUnits) * 50), ((character.TileNumber / WidthUnits) * 50));
        }
    }
}
