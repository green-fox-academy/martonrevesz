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

namespace EnvelopeStar
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawStar(foxDraw, 500, 5);
        }

        static void DrawStar(FoxDraw foxDraw, int size, int resolution)
        {
            foxDraw.StrokeColor(Colors.Green);
            // top left
            int x1 = size / 2;
            int y1 = 0;
            int x2 = size / 2;
            int y2 = size / 2;
            while (y1 < size / 2)
            {
                foxDraw.DrawLine(x1, y1, x2, y2);
                y1 += resolution;
                x2 -= resolution;
            }
            // top right
            x1 = size / 2;
            y1 = 0;
            x2 = size / 2;
            y2 = size / 2;
            while (y1 < size / 2)
            {
                foxDraw.DrawLine(x1, y1, x2, y2);
                y1 += resolution;
                x2 += resolution;
            }
            // bottom left
            x1 = size / 2;
            y1 = size / 2;
            x2 = size / 2;
            y2 = size;
            while (x1 > 0)
            {
                foxDraw.DrawLine(x1, y1, x2, y2);
                x1 -= resolution;
                y2 -= resolution;
            }
            // bottom right
            x1 = size / 2;
            y1 = size / 2;
            x2 = size / 2;
            y2 = size;
            while (x1 < size)
            {
                foxDraw.DrawLine(x1, y1, x2, y2);
                x1 += resolution;
                y2 -= resolution;
            }
        }
    }
}
