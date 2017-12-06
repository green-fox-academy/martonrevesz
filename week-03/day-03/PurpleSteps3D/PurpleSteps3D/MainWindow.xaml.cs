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

namespace PurpleSteps3D
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            PurpleSteps3D(foxDraw);
        }
        static void PurpleSteps3D(FoxDraw foxDraw)
        {
            foxDraw.FillColor(Colors.Purple);
            foxDraw.StrokeColor(Colors.Black);
            int j = 10;
            for (int i = 0; i < 8; i++)
            {
                foxDraw.DrawRectangle( j, j, 15 * i, 15 * i);
                j += 15 * i;
            }
        }
    }   
}
