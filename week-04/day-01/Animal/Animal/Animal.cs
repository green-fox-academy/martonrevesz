using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        public int HungerValue { get; set; }
        public int ThirstValue { get; set; }

        public Animal()
        {
            HungerValue = 50;
            ThirstValue = 50;
        }

        public void Eat()
        {
            HungerValue--;
        }

        public void Drink()
        {
            ThirstValue--;
        }

        public void Play()
        {
            HungerValue++;
            ThirstValue++;
        }
    }
}
