using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaditCard
{
    class CreditCardApp
    {
        static void Main(string[] args)
        {
            var list = new List<Card>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Card("ABC" + i.ToString()));
            }

            foreach (Card item in list)
            {
                Console.WriteLine(item.Tostring()); ;
            }
            Console.ReadLine();
        }
    }
}
