using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
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
        List<Monster> monsterList = new List<Monster>();
        Area area;
        GameLogic gameLogic;
        Random random = new Random();
        int heroStepCounter = 0;
        
        int gameLevel = 1;

        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            gameLogic = new GameLogic(foxDraw);
            InitializeGameBoardWithCharacters(gameLevel);

        }

        private void Game()
        {

            int monsterNumber = gameLogic.CheckSameField(hero, monsterList);
            if (monsterNumber > -1)
            {
                bool winBattle = gameLogic.Battle(hero, monsterList[monsterNumber], monsterList, canvas);
            }
            textBlock.Text = "Hero Level: " + hero.Level + "Hero HP: " + hero.CurrentHP
                + "Hero DP: " + hero.DefendPoint + "Hero SP: " + hero.StrikePoint;
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
                foreach  (Monster monster in monsterList)
                {
                    
                    monster.Move(area, foxDraw);
                }
            }           
        }



        public void InitializeGameBoardWithCharacters(int gameLevel)
        {
            int d6 = random.Next(1, 7);
            area = new Area(foxDraw);
            hero = new Hero(0, d6);

            area.DrawMap();
            area.DrawCharacter(hero);

            int randomNumber1 = random.Next(area.FreeTiles.Count);
            var skeleton1 = new Skeleton(gameLevel, area.FreeTiles[randomNumber1], d6);
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
