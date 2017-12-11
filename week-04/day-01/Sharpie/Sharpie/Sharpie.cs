using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSet
{
    class Sharpie
    {
        public string Color { get; set; }
        public double Width { get; set; }
        public double InkAmount { get; set; } = 3;

        public Sharpie(string color, double width)
        {
            Color = color;
            Width = width;
        }

        public void Use()
        {
            if (InkAmount > 0)
            {
                InkAmount--;
            }
        }
    }
}
