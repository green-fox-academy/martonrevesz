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

namespace ColoredBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw a box that has different colored lines on each edge.
            DrawColoredBox(foxDraw);
        }

        public static void DrawColoredBox(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green); 
            foxDraw.DrawLine(10, 10, 200, 10);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(200, 10, 200, 100);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(200, 100, 10, 100);
            foxDraw.StrokeColor(Colors.Yellow);
            foxDraw.DrawLine(10, 100, 10, 10);
        }
    }
}

