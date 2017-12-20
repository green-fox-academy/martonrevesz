using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;


namespace RPGGame
{
    public partial class MainWindow : Window
    {
        public FoxDraw foxDraw;
        List<Monster> monsterList = new List<Monster>();
        Area area;
        GameLogic gameLogic;
        Random random = new Random();
        int heroStepCounter = 0;
        Hero hero = new Hero(0, new Random().Next(1,7));
        int gameLevel = 1;

        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            area = new Area(foxDraw);
            area.DrawMap();
            area.DrawCharacter(hero);
            gameLogic = new GameLogic(foxDraw);
            InitializeGameBoardWithCharacters(gameLevel);
            textBlock.Text = "Hero (Level " + hero.Level + ") HP: " + hero.CurrentHP + "/" + hero.MaxHP + " | DP: "
                 + hero.DefendPoint + " | SP: " + hero.StrikePoint;
        }

        public void Game()
        {
            int monsterNumber = gameLogic.CheckSameField(hero, monsterList);
            bool flag = true;
            if (monsterNumber > -1)
            {
                bool winBattle = gameLogic.Battle(hero, monsterList[monsterNumber], monsterList);
                if (winBattle)
                {
                    foreach (Monster monster in monsterList)
                    {
                        if (monster.GetType() == typeof(Boss) || ((Skeleton)monster).HasTheKey == true)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        InitializeGameBoardWithCharacters(++gameLevel);
                    }
                }
            }
            textBlock.Text = "Hero (Level " + hero.Level + ") HP: " + hero.CurrentHP + "/" + hero.MaxHP + " | DP: "
                + hero.DefendPoint + " | SP: " + hero.StrikePoint;
        }

        private void WindowsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
            {
                hero.MoveRight(area, foxDraw);
            }
            if (e.Key == Key.Left)
            {
                hero.MoveLeft(area, foxDraw);
            }
            if (e.Key == Key.Up)
            {
                hero.MoveUp(area, foxDraw);
            }
            if (e.Key == Key.Down)
            {
                hero.MoveDown(area, foxDraw);
            }
            if (e.Key == Key.Space && (gameLogic.CheckSameField(hero, monsterList) > -1))
            {
                Game();
            }
            heroStepCounter++;
            if (heroStepCounter % 2 == 0)
            {
                for (int i = 0; i < monsterList.Count; i++)
                {
                    monsterList[i].Move(area, foxDraw);
                }
            }           
        }

        public void InitializeGameBoardWithCharacters(int gameLevel)
        {
            int d6 = random.Next(1, 7);
            foreach (Monster monster in monsterList)
            {
                foxDraw.SetPosition(foxDraw.Tiles[monster.CharacterId], -500, -500);
            }
            monsterList.Clear();                     
            hero.TileNumber = 0;
            foxDraw.SetPosition(foxDraw.Tiles[110], 0, 0);


            int randomNumber1 = random.Next(area.FreeTiles.Count);
            var skeleton1 = new Skeleton(gameLevel, area.FreeTiles[randomNumber1], d6);
            skeleton1.HasTheKey = true;
            monsterList.Add(skeleton1);
            area.DrawCharacter(skeleton1);


            int randomNumber2 = random.Next(area.FreeTiles.Count);
            var skeleton2 = new Skeleton(gameLevel, area.FreeTiles[randomNumber2], d6);
            monsterList.Add(skeleton2);
            area.DrawCharacter(skeleton2);

            int randomNumber3 = random.Next(area.FreeTiles.Count);
            var skeleton3 = new Skeleton(gameLevel, area.FreeTiles[randomNumber3], d6);
            monsterList.Add(skeleton3);
            area.DrawCharacter(skeleton3);

            int randomNumber4 = random.Next(area.FreeTiles.Count);
            var boss = new Boss(gameLevel, area.FreeTiles[randomNumber4], d6);
            monsterList.Add(boss);
            area.DrawCharacter(boss);
        }
    }
}
