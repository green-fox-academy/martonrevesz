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

namespace LinePlay
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawGreenLines(foxDraw, 300);
            DrawPurpleLines(foxDraw, 300);
        }

        static void DrawGreenLines(FoxDraw foxDraw, int size)
        {
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = size;
            foxDraw.StrokeColor(Colors.Green);

            while (y1 <= size)
            {
                foxDraw.DrawLine(x1, y1, x2, y2);
                y1 += 20;
                x2 += 20;
            }
        }

        static void DrawPurpleLines(FoxDraw foxDraw, int size)
        {
            int x1 = 0;
            int y1 = 0;
            int x2 = size;
            int y2 = 0;
            foxDraw.StrokeColor(Colors.Purple);

            while (x1 <= size)
            {
                foxDraw.DrawLine(x1, y1, x2, y2);
                x1 += 20;
                y2 += 20;
            }
        }
    }
}
