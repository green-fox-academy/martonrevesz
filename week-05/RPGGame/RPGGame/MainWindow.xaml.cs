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

        public MainWindow()
        {
            InitializeComponent();
            FoxDraw = new FoxDraw(canvas);
            var map = new Map(FoxDraw);
            var hero = new Character("hero", "./Assets/hero-down.png");
            map.DrawMap();
            map.DrawCharacter(hero);
            
        }

        private void WindowsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
            {
                double x = FoxDraw.GetLeft(FoxDraw.Tiles[110]) + 50;
                double y = FoxDraw.GetTop(FoxDraw.Tiles[110]);
                FoxDraw.SetPosition(FoxDraw.Tiles[110], x, y);                  
            }
            if (e.Key == Key.Left)
            {
                double x = FoxDraw.GetLeft(FoxDraw.Tiles[110]) - 50;
                double y = FoxDraw.GetTop(FoxDraw.Tiles[110]);
                FoxDraw.SetPosition(FoxDraw.Tiles[110], x, y);
            }
            if (e.Key == Key.Up)
            {
                double x = FoxDraw.GetLeft(FoxDraw.Tiles[110]);
                double y = FoxDraw.GetTop(FoxDraw.Tiles[110]) - 50;
                FoxDraw.SetPosition(FoxDraw.Tiles[110], x, y);
            }
            if (e.Key == Key.Down)
            {
                double x = FoxDraw.GetLeft(FoxDraw.Tiles[110]);
                double y = FoxDraw.GetTop(FoxDraw.Tiles[110]) + 50;
                FoxDraw.SetPosition(FoxDraw.Tiles[110], x, y);
            }
        }
    }
}
