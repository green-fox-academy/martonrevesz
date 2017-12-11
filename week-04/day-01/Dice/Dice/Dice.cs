using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Dice
    {
        private int currentNumber;
        Random random = new Random();

        public int GetCurrentNumber()
        {
            return currentNumber;
        }

        public void Roll()
        {
            currentNumber = random.Next(1, 7);
        }

        public void ReRoll()
        {
            currentNumber = random.Next(1, 7);
        }
    }
}
