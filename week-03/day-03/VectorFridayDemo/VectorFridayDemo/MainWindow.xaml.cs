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

namespace VectorFridayDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {   
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            var list1 = new List<LinesSetToDraw>()
                {
                    new LinesSetToDraw(new Point(0,200), new Point(200, 200), new Vector(200, 0), new Vector(0, -200)),
                    new LinesSetToDraw(new Point(0,200), new Point(200, 200), new Vector(200, 0), new Vector(0, 200)),
                    new LinesSetToDraw(new Point(200, 0), new Point(200, 200),  new Vector(0, 200), new Vector(200, 0)),
                    new LinesSetToDraw(new Point(200,200), new Point(200, 400), new Vector(200, 0), new Vector(0, -200))
                };

            var list2 = new List<LinesSetToDraw>()
                {
                    new LinesSetToDraw(new Point(100,400), new Point(100, 400), new Vector(200, -345), new Vector(400, 0)),
                    new LinesSetToDraw(new Point(300, 55), new Point(300, 55),  new Vector(-200, 345), new Vector(200, 345)),
                    new LinesSetToDraw(new Point(500, 400), new Point(500, 400), new Vector(-200, -345), new Vector(-400, 0))
                };

            DrawPointsInBetween(foxDraw, list2, 20);
        }
        static void DrawPointsInBetween(FoxDraw foxDraw, List<LinesSetToDraw> list,  int resolution)
        {
            foxDraw.StrokeColor(Colors.Green);
            for (int i = 0; i < list.Count; i += 1)
            {
                for (int j = 0; j <= resolution; j++)
                {
                    var vector1 = Vector.Add(Vector.Multiply(Vector.Divide(list[i].Vector1, resolution), j), list[i].Point1);
                    var vector2 = Vector.Add(Vector.Multiply(Vector.Divide(list[i].Vector2, resolution), j), list[i].Point2);
                    foxDraw.DrawLine(vector1.X, vector1.Y, vector2.X, vector2.Y);
                }
            }
        }
    }

    public class LinesSetToDraw
    {
        public Point Point1 { get; set; }

        public Point Point2 { get; set; }

        public Vector Vector1 { get; set; }

        public Vector Vector2 { get; set; }


        public LinesSetToDraw(Point Point1, Point Point2, Vector Vector1, Vector Vector2)
        {
            this.Point1 = Point1; 
            this.Point2 = Point2;
            this.Vector1 = Vector1;
            this.Vector2 = Vector2;
        }        
    }
}
