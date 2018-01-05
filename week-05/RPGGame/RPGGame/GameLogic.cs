using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RPGGame
{
    public class GameLogic
    {
        public FoxDraw MyFoxDraw { get; set; }
        Random random = new Random();
        public int gameLevel = 1;
        public Area MyArea { get; set; }
        public Hero MyHero{ get; set; }
        public TextBlock MyTextBlock { get; set; }
        public List<Monster> MonsterList { get; set; }

        public GameLogic(FoxDraw myFoxDraw, Area area, Hero hero, TextBlock textBlock, List<Monster> monsterList)
        {
            MyArea = area;
            MyHero = hero;
            MyTextBlock = textBlock;
            MonsterList = monsterList;
        }

        public void InitializeGameBoardWithCharacters(int gameLevel)
        {
            int d6 = random.Next(1, 7);
            MyArea.SetInvisible(MonsterList);
            MonsterList.Clear();
            MyArea.ResetPositionToZero(MyHero);
            for (int i = 0; i < 3; i++)
            {
                int randomNumber = random.Next(MyArea.FreeTiles.Count);
                MonsterList.Add(new Skeleton(gameLevel, MyArea.FreeTiles[randomNumber], random.Next(1, 7)));
                if (i == 0)
                    ((Skeleton)MonsterList[i]).HasTheKey = true;
                MyArea.DrawCharacter(MonsterList[i]);
            }
            int randomNumber2 = random.Next(MyArea.FreeTiles.Count);
            var boss = new Boss(gameLevel, MyArea.FreeTiles[randomNumber2], d6);
            MonsterList.Add(boss);
            MyArea.DrawCharacter(boss);
            MyTextBlock.Text = "Hero (Level " + MyHero.Level + ") HP: " + MyHero.CurrentHP + "/" + MyHero.MaxHP + " | DP: "
                + MyHero.DefendPoint + " | SP: " + MyHero.StrikePoint;
        }

        public void Game(int monsterNumber)
        {
            bool flag = true;
            if (monsterNumber > -1)
            {
                bool winBattle = Battle(MonsterList[monsterNumber]);
                if (winBattle)
                {
                    foreach (Monster monster in MonsterList)
                    {
                        if (monster.GetType() == typeof(Boss) || ((Skeleton)monster).HasTheKey == true)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                        InitializeGameBoardWithCharacters(++gameLevel);
                }
            }
            MyTextBlock.Text = "Hero (Level " + MyHero.Level + ") HP: " + MyHero.CurrentHP + "/" + MyHero.MaxHP + " | DP: "
                + MyHero.DefendPoint + " | SP: " + MyHero.StrikePoint;
        }

        public bool Battle(Monster monster)
        {
            while (true)
            {
                Strike(MyHero, monster);
                if (monster.CurrentHP <= 0)
                {
                    MyArea.SetInvisible(monster);
                    MonsterList.Remove(monster);
                    MyHero.Level++;
                    MyHero.MaxHP += random.Next(1,7);
                    MyHero.DefendPoint += random.Next(1, 7);
                    MyHero.StrikePoint += random.Next(1, 7);
                    return true;
                }
                Strike(monster, MyHero);
                if (MyHero.CurrentHP <= 0)
                {
                    MyArea.SetInvisible(MyHero);
                    MessageBox.Show("Hero HP: 0 \n Game over");
                    return false;
                }
            }
        }

        public void Strike(Character char1, Character char2)
        {
            int d6 = random.Next(1,7);
            int SV = char1.StrikePoint + 2 * d6;
            if (SV > char2.DefendPoint)
                char2.CurrentHP -= (SV - char2.DefendPoint);
        }
    }
}
