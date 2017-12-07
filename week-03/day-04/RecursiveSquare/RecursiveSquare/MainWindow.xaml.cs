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

namespace RecursiveSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawShape(foxDraw, 700, new Point(0, 0), 5);
        }

        static void DrawShape(FoxDraw foxDraw, int size, Point startPoint, int level)
        {
            if (level > 0)
            {
                level--;
                foxDraw.DrawLine(startPoint.X + size / 3, startPoint.Y, startPoint.X + size / 3, startPoint.Y + size);
                foxDraw.DrawLine(startPoint.X + 2 * size / 3, startPoint.Y, startPoint.X + 2 * size / 3, startPoint.Y + size);
                foxDraw.DrawLine(startPoint.X, startPoint.Y + size / 3, startPoint.X + size, startPoint.Y + size / 3);
                foxDraw.DrawLine(startPoint.X, startPoint.Y + 2 * size / 3, startPoint.X + size, startPoint.Y + 2 * size / 3);

                DrawShape(foxDraw, size / 3, new Point(startPoint.X + size / 3, startPoint.Y), level);
                DrawShape(foxDraw, size / 3, new Point(startPoint.X, startPoint.Y + size / 3), level);
                DrawShape(foxDraw, size / 3, new Point(startPoint.X + 2 * size / 3, startPoint.Y + size / 3), level);
                DrawShape(foxDraw, size / 3, new Point(startPoint.X + size / 3, startPoint.Y + 2 * size / 3), level);
            }
        }
    }
}
