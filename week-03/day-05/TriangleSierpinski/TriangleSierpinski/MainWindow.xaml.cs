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

namespace TriangleSierpinski
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawShape(foxDraw, 700.0, new Point(0, 0), 8);
        }

        static void DrawShape(FoxDraw foxDraw, double sizeX, Point startPoint, int level)
        {
            if (level > 0)
            {
                level--;
                double sizeY = 0.866025 * sizeX;
                foxDraw.DrawLine(startPoint.X, startPoint.Y, startPoint.X + sizeX, startPoint.Y);
                foxDraw.DrawLine(startPoint.X, startPoint.Y, startPoint.X +  sizeX / 2, startPoint.Y + sizeY);
                foxDraw.DrawLine(startPoint.X + sizeX /2 , startPoint.Y + sizeY, startPoint.X + sizeX, startPoint.Y);
                
                DrawShape(foxDraw, sizeX / 2, new Point(startPoint.X, startPoint.Y), level);
                DrawShape(foxDraw, sizeX / 2, new Point(startPoint.X + sizeX /2, startPoint.Y), level);
                DrawShape(foxDraw, sizeX / 2, new Point(startPoint.X + sizeX / 4, startPoint.Y + sizeY / 2), level);
            }
        }
    }
}
