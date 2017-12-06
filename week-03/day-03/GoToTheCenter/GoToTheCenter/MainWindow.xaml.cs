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

namespace GoToTheCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            LineToCenter(foxDraw, 30, 50);
            LineToCenter(foxDraw, 462, 200);
            LineToCenter(foxDraw, 90, 240);
        }

        static void LineToCenter(FoxDraw foxDraw, int x1, int x2)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(x1, x2, 263, 175);
        }
    }
}
