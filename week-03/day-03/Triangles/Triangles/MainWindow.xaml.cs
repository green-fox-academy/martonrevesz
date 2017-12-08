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

namespace Triangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            int sideLength = 700;
            int baseLineY = 450;
            int pieces = 100;
            DrawTriangles(foxDraw, sideLength, baseLineY, pieces);
        }

        static void DrawTriangles(FoxDraw foxDraw, int sideLength, int baseLineY, int resolution)
        {
            Point a = new Point(50, baseLineY);
            Point b = new Point(50 + sideLength, baseLineY);
            Point c = new Point(50 + sideLength / 2, baseLineY - sideLength * 0.866);

            var points = new List<Point>() { a, b, c };
            foxDraw.FillColor(Colors.White);
            foxDraw.DrawPolygon(points);
            double x1 = a.X;
            double y1 = a.Y;
            double x2 = a.X;
            double y2 = a.Y;

            for (int i = 1; i < resolution; i++)
            {
                x1 = (i * a.X + (resolution - i) * c.X) / resolution;
                y1 = (i * a.Y + (resolution - i) * c.Y) / resolution;
                x2 = (i * a.X + (resolution - i) * b.X) / resolution;
                y2 = (i * a.Y + (resolution - i) * b.Y) / resolution;
                foxDraw.DrawLine(x1, y1, x2, y2);
            }

            x1 = c.X;
            y1 = c.Y;
            x2 = c.X;
            y2 = c.Y;

            for (int i = 1; i < resolution; i++)
            {
                x1 = (i * c.X + (resolution - i) * a.X) / resolution;
                y1 = (i * c.Y + (resolution - i) * a.Y) / resolution;
                x2 = (i * c.X + (resolution - i) * b.X) / resolution;
                y2 = (i * c.Y + (resolution - i) * b.Y) / resolution;
                foxDraw.DrawLine(x1, y1, x2, y2);
            }

            x1 = b.X;
            y1 = b.Y;
            x2 = b.X;
            y2 = b.Y;

            for (int i = 1; i < resolution; i++)
            {
                x1 = (i * b.X + (resolution - i) * a.X) / resolution;
                y1 = (i * b.Y + (resolution - i) * a.Y) / resolution;
                x2 = (i * b.X + (resolution - i) * c.X) / resolution;
                y2 = (i * b.Y + (resolution - i) * c.Y) / resolution;
                foxDraw.DrawLine(x1, y1, x2, y2);
            }
        }
    }
}
