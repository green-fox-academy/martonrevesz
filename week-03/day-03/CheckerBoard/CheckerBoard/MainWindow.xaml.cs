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

namespace CheckerBoard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawChessBoard(foxDraw);
        }
        static void DrawChessBoard(FoxDraw foxDraw)
        {
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        foxDraw.FillColor(Colors.Black);
                    }
                    else
                    {
                        foxDraw.FillColor(Colors.White);
                    }
                    foxDraw.DrawRectangle(10 + 15 * j, 10 + 15 * i , 15 , 15);
                }
            }
        }
    }
}
