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

namespace HorizontalLines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawHorizontalLine(foxDraw, 30, 70);
            DrawHorizontalLine(foxDraw, 156, 20);
            DrawHorizontalLine(foxDraw, 300, 300);
        }

        static void DrawHorizontalLine(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(x, y, x + 50, y);
        }
    }
}
