using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    public class SumElements
    {
        public int Sum(List<int> list)
        {
            int sum = 0;
            foreach (int item in list)
            {
                sum += item;
            }
            return sum;
        }
    }
}
