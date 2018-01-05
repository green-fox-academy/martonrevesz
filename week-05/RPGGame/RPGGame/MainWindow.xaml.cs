using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace RPGGame
{
    public partial class MainWindow : Window
    {
        public FoxDraw foxDraw;
        Area area;
        GameLogic gameLogic;
        Random random = new Random();
        int heroStepCounter = 0;
        List<Monster> monsterList;
        Hero hero = new Hero(0, new Random().Next(1,7));

        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            area = new Area(foxDraw);
            area.DrawMap();
            area.DrawCharacter(hero);
            monsterList = new List<Monster>();
            gameLogic = new GameLogic(foxDraw, area, hero, textBlock, monsterList);
            gameLogic.InitializeGameBoardWithCharacters(1);
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
            if (e.Key == Key.Space && (area.CheckSameField(monsterList, hero) > -1))
                gameLogic.Game(area.CheckSameField(monsterList, hero));
            heroStepCounter++;
            if (heroStepCounter % 2 == 0)
                area.MoveRandom(monsterList);        
        }
    }
}
