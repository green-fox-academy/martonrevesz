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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            //  draw a red horizontal line to the canvas' middle.
            //  draw a green vertical line to the canvas' middle.
            DrawLines(foxDraw);
        }
        public static void DrawLines(FoxDraw foxDraw)
        {
            foxDraw.DrawLine(0, 175 , 525, 175 );
            foxDraw.DrawLine(263, 0, 263, 350);
        }
    }
}
