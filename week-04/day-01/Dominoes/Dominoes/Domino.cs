using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino 
{
    class Domino : IComparable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo(object obj)
        {
            if (Values[0] <  ((Domino)obj).Values[0] )
            {
                return -1;
            }
            else if(Values[0] > ((Domino)obj).Values[0])
            {
                return 1;
            }
            if (Values[1] < ((Domino)obj).Values[1])
            {
                return -1;
            }
            else if (Values[1] > ((Domino)obj).Values[1])
            {
                return 1;
            }
            return 0;

        }

        public int[] GetValues()
        {
            return Values;
        }

       
    }
}
