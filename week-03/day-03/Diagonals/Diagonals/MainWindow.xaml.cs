﻿using System;
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

namespace Diagonals
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw the canvas' diagonals in green.
            DrawDiagonals(foxDraw);
        }

        static void DrawDiagonals(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 0, 525, 350);
            foxDraw.DrawLine(0, 350, 525, 0);
        }
    }
}
