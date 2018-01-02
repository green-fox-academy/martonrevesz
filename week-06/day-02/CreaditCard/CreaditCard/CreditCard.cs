using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaditCard
{
    class Card : ICreditCardy
    {
        public string Name { get; set; }
        public string CcNumber { get; set; }
        static Random random = new Random();

        public Card(string name)
        {
            Name = name;
            CcNumber = GenerateCcNumber();
        }

        private string GenerateCcNumber()
        {
            string ccNumber = string.Empty;
            for (int i = 0; i < 16; i++)
            {
                ccNumber += random.Next(10).ToString();
            }
            return ccNumber;
        }

        public int CumeSumCVV(string codeAccount)
        {
            int sum = 0;
            for (int i = 0; i < codeAccount.Length; i++)
            {
                sum += int.Parse(codeAccount[i].ToString());
            }
            return sum;
        }

        public string GetCodeAccount()
        { 
            return CcNumber;
        }

        public string GetNameCardholder()
        {
            return Name;
        }

        public int GetSumCVV()
        {
            return CumeSumCVV(CcNumber);
        }

        public string Tostring()
        {
            return $"Name={Name} CC#={GetCodeAccount()} CCV={GetSumCVV()} (validated)";
        }
    }
}
