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

namespace LineIntheMiddle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawLines(foxDraw, 0, 175, 525, 175);
            DrawLines(foxDraw, 263, 0, 263, 350);
        }
        public static void DrawLines(FoxDraw foxDraw, int x1, int y1, int x2, int y2)
        {
            foxDraw.DrawLine(x1, y1, x2, y2);
        }
    }
}
