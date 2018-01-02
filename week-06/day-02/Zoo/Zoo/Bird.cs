using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Bird : Animal
    {
        public Bird(string name) : base(name)
        {

        }
        protected override void Greet()
        {
            Console.WriteLine("hello flyable");
        }

        public override string WantChild()
        {
            return "want a child from an egg";
        }
    }
}
