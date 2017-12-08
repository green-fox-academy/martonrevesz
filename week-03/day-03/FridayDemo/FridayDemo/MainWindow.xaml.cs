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

namespace FridayDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            var myList1 = new List<Point>()
                { new Point(0,200), new Point(200, 200), new Point(200, 200), new Point(200, 0),
                  new Point(0,200), new Point(200, 200), new Point(200, 200), new Point(200, 400),
                  new Point(200, 0), new Point(200, 200), new Point(200, 200), new Point(400, 200),
                  new Point(200,200), new Point(200, 400), new Point(400, 200), new Point(200, 200),
                };
            var myList2 = new List<Point>()
                { new Point(100,400), new Point(300, 55), new Point(100, 400), new Point(500, 400),
                  new Point(300,55), new Point(100, 400), new Point(300, 55), new Point(500, 400),
                  new Point(500, 400), new Point(100, 400), new Point(500, 400), new Point(300, 55)
                };
            var myList3 = new List<Point>()
                { new Point(50, 50), new Point(50, 250), new Point(50, 250), new Point(350, 250),
                  new Point(50,250), new Point(350, 250), new Point(350, 250), new Point(350, 50),
                  new Point(350, 250), new Point(350, 50), new Point(350, 50), new Point(50, 50),
                  new Point(350,50), new Point(50, 50), new Point(50, 50), new Point(50, 250)
               };
            DrawPointsInBetween(foxDraw, myList1, 20);
        }
        static void DrawPointsInBetween(FoxDraw foxDraw, List<Point> list, int resolution)
        {
            foxDraw.StrokeColor(Colors.Green);
            for (int i = 0; i < list.Count; i += 4)
            {
                for (int j = 0; j <= resolution; j++)
                {
                    double x1 = (j * list[i].X + (resolution - j) * list[i + 1].X) / resolution;
                    double y1 = (j * list[i].Y + (resolution - j) * list[i + 1].Y) / resolution;
                    double x2 = (j * list[i + 2].X + (resolution - j) * list[i + 3].X) / resolution;
                    double y2 = (j * list[i + 2].Y + (resolution - j) * list[i + 3].Y) / resolution;
                    foxDraw.DrawLine(x1, y1, x2, y2);
                }
            }
        }
    }
}
