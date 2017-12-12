using System;

namespace Garden
{
    public abstract class Plant
    {
        public int Treshold { get; internal set; }
        public double CurrentWater { get; internal set; } = 0;
        public double AbsorbRate { get; set; }
        public string Color { get; set; }

        public Plant(string color)
        {
            Color = color;
        }

        public abstract void AbsorbWater(double amount);
    }
}