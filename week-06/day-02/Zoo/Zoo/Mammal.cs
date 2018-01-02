using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Mammal : Animal
    {
        private int numberOfLegs;

        public Mammal(string name) : base(name)
        {

        }

        protected override void Greet()
        {
            Console.WriteLine("hello mom");
        }

        public override string WantChild()
        {
            return "want a child from my uterus";
        }
    }
}
