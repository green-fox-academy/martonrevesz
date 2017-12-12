using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Tree : Plant
    {
        public Tree(string color) : base(color)
        {
            Treshold = 10;
            AbsorbRate = 0.4;
        }
        public override void AbsorbWater(double amount)
        {
            CurrentWater += amount * AbsorbRate;
        }
    }
}
