using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaditCard
{
    interface ICreditCardy
    {
        int GetSumCVV();

        string GetNameCardholder();

        string GetCodeAccount();

        int CumeSumCVV(string codeAccount);

        string Tostring();
    }
}
