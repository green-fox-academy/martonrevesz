using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Reptile : Animal
    {
        public Reptile(string name) : base(name)
        {

        }
        protected override void Greet()
        {
            Console.WriteLine("hello reptile");
        }

        public override string WantChild()
        {
            if (name == "Frog")
            {
                return "want egg in a froggy way";
            }
            return "want a child from an egg";
        }
    }
}
