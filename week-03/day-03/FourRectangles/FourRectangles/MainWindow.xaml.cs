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

namespace FourRectangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawRectangle(foxDraw);
        }
        static void DrawRectangle(FoxDraw foxDraw)
        {
            foxDraw.FillColor(Colors.Green);
            foxDraw.DrawRectangle(50, 50, 60, 60);

            foxDraw.FillColor(Colors.Red);
            foxDraw.DrawRectangle(110, 110, 70, 70);

            foxDraw.FillColor(Colors.Blue);
            foxDraw.DrawRectangle(180, 180, 80, 80);

            foxDraw.FillColor(Colors.Yellow);
            foxDraw.DrawRectangle(260, 260, 30, 30);
        }
    }
}
