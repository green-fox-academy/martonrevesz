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
using System.Windows.Media.Imaging;

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
                foxDraw.Items[hero.CharacterId].Source = new BitmapImage(new Uri("./Assets/hero-right.png", UriKind.Relative));
                area.MoveRight(hero);
            }
            if (e.Key == Key.Left)
            {
                foxDraw.Items[hero.CharacterId].Source = new BitmapImage(new Uri("./Assets/hero-left.png", UriKind.Relative));
                area.MoveLeft(hero);
            }
            if (e.Key == Key.Up)
            {
                foxDraw.Items[hero.CharacterId].Source = new BitmapImage(new Uri("./Assets/hero-up.png", UriKind.Relative));
                area.MoveUp(hero);
            }
            if (e.Key == Key.Down)
            {
                foxDraw.Items[hero.CharacterId].Source = new BitmapImage(new Uri("./Assets/hero-down.png", UriKind.Relative));
                area.MoveDown(hero);
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
                    area.MoveRandom(monsterList[i]);
                }
            }           
        }

        public void InitializeGameBoardWithCharacters(int gameLevel)
        {
            int d6 = random.Next(1, 7);
            foreach (Monster monster in monsterList)
            {
                foxDraw.SetPosition(foxDraw.Items[monster.CharacterId], -500, -500);
            }
            monsterList.Clear();                     
            hero.TileNumber = 0;
            foxDraw.SetPosition(foxDraw.Items[110], 0, 0);

            for (int i = 0; i < 3; i++)
            {
                int randomNumber = random.Next(area.FreeTiles.Count);
                monsterList.Add(new Skeleton(gameLevel, area.FreeTiles[randomNumber], random.Next(1,7)));
                if (i == 0)
                    ((Skeleton)monsterList[i]).HasTheKey = true;
                area.DrawCharacter(monsterList[i]);
            }
            int randomNumber2 = random.Next(area.FreeTiles.Count);
            var boss = new Boss(gameLevel, area.FreeTiles[randomNumber2], d6);
            monsterList.Add(boss);
            area.DrawCharacter(boss);
        }
    }
}
