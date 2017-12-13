using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmNS
{
    public class Animal
    {
        public int HungerValue { get; set; }
        public int ThirstValue { get; set; }

        public Animal()
        {
            HungerValue = 50;
            ThirstValue = 50;
        }

        public int Eat()
        {
            return --HungerValue;
        }

        public int Drink()
        {
            return --ThirstValue;
        }

        public int[] Play()
        {
            return new int[] { ++HungerValue,  ++ThirstValue};
        }
    }
}
