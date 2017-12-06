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

namespace FunctionToCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            int width = 550;
            int height = 450;
            DrawLinesToCenter(foxDraw, 70, 110, width, height);
        }

        static void DrawLinesToCenter(FoxDraw foxDraw, int originalX, int originalY, int width, int height)
        {
            int x = originalX;
            int y = originalY;
            while(x <  originalX + width)
            {
                foxDraw.DrawLine(x, y, originalX + width / 2, originalY + height / 2);
                x += 20;
            }
            while (y < originalY+ height)
            {
                foxDraw.DrawLine(x, y, originalX + width / 2, originalY + height / 2);
                y += 20;
            }
            while (x > originalX)
            {
                foxDraw.DrawLine(x, y, originalX + width / 2, originalY + height / 2);
                x -= 20;
            }
            while (y  > originalY)
            {
                foxDraw.DrawLine(x, y, originalX + width / 2, originalY + height / 2);
                y -= 20;
            }
        }
    }
}
