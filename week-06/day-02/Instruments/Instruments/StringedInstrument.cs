using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings;

        public StringedInstrument(int numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
        }

        public StringedInstrument()
        {

        }

        public override void Play()
        {
            Console.WriteLine($"{GetType().Name}, a {numberOfStrings}-stringed instrument that {Sound()}s");
        }

        public abstract string Sound();


    }
}
