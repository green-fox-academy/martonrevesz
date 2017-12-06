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

namespace CenterBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawSquare(foxDraw, 100);
            DrawSquare(foxDraw, 80);
            DrawSquare(foxDraw, 60);
        }

        static void DrawSquare(FoxDraw foxDraw, int size)
        {
            foxDraw.DrawRectangle(263 - size / 2, 175 - size / 2, size, size);
        }
    }
}
