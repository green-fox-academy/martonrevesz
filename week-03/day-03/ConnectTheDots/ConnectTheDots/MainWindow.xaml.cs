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

namespace ConnectTheDots
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            var list = new List<Point>() { new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290)};
            var list2 = new List<Point>() { new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90),
                new Point(100, 70), new Point(120, 100), new Point(85, 130), new Point(50, 100)};
            ConnectDots(foxDraw, list2);
        }

        static void ConnectDots(FoxDraw foxDraw, List<Point> list)
        {
            foxDraw.DrawPolygon(list);
        }
    }
}
