using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Counter
    {
        public int CurrentValue { get; set; }

        public Counter()
        {
            CurrentValue = 0;
        }

        public Counter(int currentValue)
        {
            CurrentValue = currentValue;
        }

        public void Add(int number)
        {
            CurrentValue += number;
        }

        public void Add()
        {
            CurrentValue++;
        }

        public string Get()
        {
            return CurrentValue.ToString();
        }

        public void Reset()
        {
            CurrentValue = 0;
        }
    }
}
