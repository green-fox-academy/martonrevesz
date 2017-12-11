using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThings
{
    class Fleet
    {
        private List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }

        public void PrintFleet()
        {
            for (int i = 0; i < Things.Count; i++)
            {
                var sb = new StringBuilder();
                sb.Append((i + 1) + ". [");
                if (Things[i].GetCompleted())
                {
                    sb.Append("X");
                }
                else
                {
                    sb.Append(" ");
                }
                sb.Append("] " + Things[i].GetName());
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
