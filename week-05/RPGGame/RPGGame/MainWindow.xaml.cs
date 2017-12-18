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
        public FoxDraw FoxDraw;
        Character hero;
        Map map;
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            FoxDraw = new FoxDraw(canvas);
            InitializeGameBoardWithCharacters();


        }

        private void WindowsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
            {
                FoxDraw.Tiles[110].Source = new BitmapImage(new Uri("./Assets/hero-right.png", UriKind.Relative));
                if ((hero.TileNumber % 10 != 9) && !map.WallTiles.Contains(hero.TileNumber + 1))
                {
                    double x = FoxDraw.GetLeft(FoxDraw.Tiles[110]) + 50;
                    double y = FoxDraw.GetTop(FoxDraw.Tiles[110]);
                    FoxDraw.SetPosition(FoxDraw.Tiles[110], x, y);
                    hero.TileNumber += 1;
                }
            }
            if (e.Key == Key.Left)
            {
                FoxDraw.Tiles[110].Source = new BitmapImage(new Uri("./Assets/hero-left.png", UriKind.Relative));
                if ((hero.TileNumber % 10 != 0) && !map.WallTiles.Contains(hero.TileNumber - 1))
                {
                    double x = FoxDraw.GetLeft(FoxDraw.Tiles[110]) - 50;
                    double y = FoxDraw.GetTop(FoxDraw.Tiles[110]);               
                    FoxDraw.SetPosition(FoxDraw.Tiles[110], x, y);
                    hero.TileNumber -= 1;
                }
            }
            if (e.Key == Key.Up)
            {
                FoxDraw.Tiles[110].Source = new BitmapImage(new Uri("./Assets/hero-up.png", UriKind.Relative));
                if ((hero.TileNumber / 10 != 0) && !map.WallTiles.Contains(hero.TileNumber - 10))
                {
                    double x = FoxDraw.GetLeft(FoxDraw.Tiles[110]);
                    double y = FoxDraw.GetTop(FoxDraw.Tiles[110]) - 50;
                    FoxDraw.SetPosition(FoxDraw.Tiles[110], x, y);
                    hero.TileNumber -= 10;
                }
            }
            if (e.Key == Key.Down)
            {
                FoxDraw.Tiles[110].Source = new BitmapImage(new Uri("./Assets/hero-down.png", UriKind.Relative));
                if ((hero.TileNumber / 10 != 10) && !map.WallTiles.Contains(hero.TileNumber + 10))
                {
                    double x = FoxDraw.GetLeft(FoxDraw.Tiles[110]);
                    double y = FoxDraw.GetTop(FoxDraw.Tiles[110]) + 50;
                    FoxDraw.SetPosition(FoxDraw.Tiles[110], x, y);
                    hero.TileNumber += 10;
                }
            }
        }

        public void InitializeGameBoardWithCharacters()
        {
            map = new Map(FoxDraw);
            hero = new Hero("hero", 0);

            map.DrawMap();
            map.DrawCharacter(hero);

            int randomNumber1 = random.Next(map.FreeTiles.Count);
            var skeleton1 = new Skeleton("skeleton1", map.FreeTiles[randomNumber1]);
            map.FreeTiles.Remove(randomNumber1);
            map.DrawCharacter(skeleton1);

            int randomNumber2 = random.Next(map.FreeTiles.Count);
            var skeleton2 = new Skeleton("skeleton2", map.FreeTiles[randomNumber2]);
            map.FreeTiles.Remove(randomNumber2);
            map.DrawCharacter(skeleton2);

            int randomNumber3 = random.Next(map.FreeTiles.Count);
            var skeleton3 = new Skeleton("skeleton3", map.FreeTiles[randomNumber3]);
            map.FreeTiles.Remove(randomNumber3);
            map.DrawCharacter(skeleton3);

            int randomNumber4 = random.Next(map.FreeTiles.Count);
            var boss = new Boss("boss", map.FreeTiles[randomNumber4]);
            map.FreeTiles.Remove(randomNumber4);
            map.DrawCharacter(boss);
        }
    }
}
