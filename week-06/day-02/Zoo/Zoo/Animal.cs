using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Animal
    {
        protected string name;
        protected int age;
        protected bool IsHealthy;
        protected string gender;

        public Animal(string name)
        {
            this.name = name;
        }

        protected abstract void Greet();
        public abstract string WantChild();

        public string GetName()
        {
            return name;
        }
    }


}
