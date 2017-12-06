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

namespace PurpleSteps
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            PurpleSteps(foxDraw);
        }
        static void PurpleSteps(FoxDraw foxDraw)
        {
            foxDraw.FillColor(Colors.Purple);
            foxDraw.StrokeColor(Colors.Black);
            for (int i = 0; i < 30; i++)
            {
                foxDraw.DrawRectangle(10 + 15 * i, 10 + 15 * i , 15, 15);
            }
        }
    }
}
