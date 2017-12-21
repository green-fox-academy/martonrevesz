using System;
using System.Collections.Generic;

namespace RPGGame
{
    public class Area

    {
        static Random random = new Random();
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
                    FreeTiles.Add(i);                       
            }            
        }

        public void DrawMap()
        {
            for (int i = 0; i < HeightUnits; i++)
            {
                for (int j = 0; j < WidthUnits; j++)
                {
                    if (WallTiles.Contains(WidthUnits * i + j))
                        MyFoxDraw.AddImage("./Assets/wall.png", 50 * j, 50 * i);
                    else
                        MyFoxDraw.AddImage("./Assets/floor.png", 50 * j, 50 * i);
                }
            }
        }

        public void DrawCharacter(Character character)
        {
            MyFoxDraw.AddImage(character.ImageSource, ((character.TileNumber % WidthUnits) * 50), ((character.TileNumber / WidthUnits) * 50));
        }

        internal void MoveRight(Character character)
        {
            if ((character.TileNumber % WidthUnits != WidthUnits - 1) && !WallTiles.Contains(character.TileNumber + 1))
            {
                double x = MyFoxDraw.GetLeft(MyFoxDraw.Items[character.CharacterId]) + 50;
                double y = MyFoxDraw.GetTop(MyFoxDraw.Items[character.CharacterId]);
                MyFoxDraw.SetPosition(MyFoxDraw.Items[character.CharacterId], x, y);
                character.TileNumber += 1;
            }
        }

        internal void MoveLeft(Character character)
        {
            if ((character.TileNumber % WidthUnits != 0) && !WallTiles.Contains(character.TileNumber - 1))
            {

                double x = MyFoxDraw.GetLeft(MyFoxDraw.Items[character.CharacterId]) - 50;
                double y = MyFoxDraw.GetTop(MyFoxDraw.Items[character.CharacterId]);
                MyFoxDraw.SetPosition(MyFoxDraw.Items[character.CharacterId], x, y);
                character.TileNumber -= 1;
            }
        }

        internal void MoveUp(Character character)
        {
            if ((character.TileNumber / WidthUnits != 0) && !WallTiles.Contains(character.TileNumber - 10))
            {
                double x = MyFoxDraw.GetLeft(MyFoxDraw.Items[character.CharacterId]);
                double y = MyFoxDraw.GetTop(MyFoxDraw.Items[character.CharacterId]) - 50;
                MyFoxDraw.SetPosition(MyFoxDraw.Items[character.CharacterId], x, y);
                character.TileNumber -= 10;             }
        }

        internal void MoveDown(Character character)
        {
            if ((character.TileNumber / WidthUnits != HeightUnits - 1) && !WallTiles.Contains(character.TileNumber + 10))
            {
                double x = MyFoxDraw.GetLeft(MyFoxDraw.Items[character.CharacterId]);
                double y = MyFoxDraw.GetTop(MyFoxDraw.Items[character.CharacterId]) + 50;
                MyFoxDraw.SetPosition(MyFoxDraw.Items[character.CharacterId], x, y);
                character.TileNumber += 10;
            }
        }

        public void MoveRandom(List<Monster> monsterList)
        {
            foreach (Monster monster in monsterList)
            {
                var list = FindOptions(monster);
                int directionNumber = random.Next(list.Count);

                if (list[directionNumber] == "right")
                    MoveRight(monster);
                else if (list[directionNumber] == "up")                
                    MoveUp(monster);                
                else if (list[directionNumber] == "down")                
                    MoveDown(monster);                
                else if (list[directionNumber] == "left")                
                    MoveLeft(monster);                
            }           
        }

        private List<string> FindOptions(Character character)
        {
            var list = new List<string>();
            if ((character.TileNumber % 10) != 9 && !WallTiles.Contains(character.TileNumber + 1))           
                list.Add("right");            
            if ((character.TileNumber / 10) != 0 && !WallTiles.Contains(character.TileNumber - 10))            
                list.Add("up");            
            if ((character.TileNumber / 10) != 10 && !WallTiles.Contains(character.TileNumber + 10))            
                list.Add("down");            
            if ((character.TileNumber % 10) != 0 && !WallTiles.Contains(character.TileNumber - 1))            
                list.Add("left");            
            return list;
        }

        public void SetInvisible(List<Monster> monsterList)
        {
            foreach (Character monster in monsterList)
                MyFoxDraw.SetPosition(MyFoxDraw.Items[monster.CharacterId], -500, -500);
        }          
        public void SetInvisible(Character character)
        {
            MyFoxDraw.SetPosition(MyFoxDraw.Items[character.CharacterId], -500, -500);
        }

        public void ResetPositionToZero(Character character)
        {
            MyFoxDraw.SetPosition(MyFoxDraw.Items[character.CharacterId], 0, 0);
            character.TileNumber = 0;
        }
    }
}
