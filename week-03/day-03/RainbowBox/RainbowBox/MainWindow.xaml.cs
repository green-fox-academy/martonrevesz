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
using GreenFox;

namespace RainbowBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawRainbowBox(foxDraw, 42);
        }

        static void DrawRainbowBox(FoxDraw foxDraw, int size)
        {
            Color[] colors = {Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Purple};
            var random = new Random();
            for (int i = 0; i < 1000 ; i++)
            {
                foxDraw.FillColor(colors[i % colors.Length]);              
                foxDraw.DrawRectangle(random.Next(525), random.Next(375), size, size);
            }
        }
    }
}
