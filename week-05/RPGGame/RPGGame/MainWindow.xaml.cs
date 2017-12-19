using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RPGGame
{
    public partial class MainWindow : Window
    {
        public FoxDraw foxDraw;
        Character hero;
        Area area;
        Random random = new Random();
        int heroStepCounter = 0;
        Skeleton skeleton1;

        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            int gameLevel = 0;

            InitializeGameBoardWithCharacters(gameLevel);
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

            heroStepCounter++;
            if (heroStepCounter % 2 == 0)
            {
                skeleton1.Move(area, foxDraw);
            }
        }

        public void InitializeGameBoardWithCharacters(int gameLevel)
        {
            int d6 = random.Next(1,7);
            area = new Area(foxDraw);
            hero = new Hero(0, d6);

            area.DrawMap();
            area.DrawCharacter(hero);

            int randomNumber1 = random.Next(area.FreeTiles.Count);
            skeleton1 = new Skeleton(gameLevel, area.FreeTiles[randomNumber1], d6);
            area.FreeTiles.Remove(randomNumber1);
            area.DrawCharacter(skeleton1);

            int randomNumber2 = random.Next(area.FreeTiles.Count);
            var skeleton2 = new Skeleton(gameLevel, area.FreeTiles[randomNumber2], d6);
            area.FreeTiles.Remove(randomNumber2);
            area.DrawCharacter(skeleton2);

            int randomNumber3 = random.Next(area.FreeTiles.Count);
            var skeleton3 = new Skeleton(gameLevel, area.FreeTiles[randomNumber3], d6);
            area.FreeTiles.Remove(randomNumber3);
            area.DrawCharacter(skeleton3);

            int randomNumber4 = random.Next(area.FreeTiles.Count);
            var boss = new Boss(gameLevel, area.FreeTiles[randomNumber4], d6);
            area.FreeTiles.Remove(randomNumber4);
            area.DrawCharacter(boss);
        }
    }
}
