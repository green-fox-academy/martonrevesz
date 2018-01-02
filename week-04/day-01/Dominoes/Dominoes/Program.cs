using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domino;

namespace Domino
{
    class Program
    {
        static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            dominoes = OrderDominoes(dominoes);
            Console.WriteLine("***");
            foreach (Domino item in dominoes)
            {
                Console.WriteLine("[" + item.GetValues()[0] + ", " + item.GetValues()[1] + "]");
            }
            Console.ReadLine();
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            dominoes.Sort();
            foreach (Domino item in dominoes)
            {
                Console.WriteLine("[" + item.GetValues()[0] + ", " + item.GetValues()[1] + "]");
            }
            return dominoes;
        }

        static List<Domino> OrderDominoes(List<Domino> dominoList)
        {
            for (int i = 1; i < dominoList.Count; i++)
            {
                for (int j = i; j < dominoList.Count; j++)
                {
                    if (dominoList[i - 1].GetValues()[1] == dominoList[j].GetValues()[0])
                    {
                        var tempDomino = dominoList[i];
                        dominoList[i] = dominoList[j];
                        dominoList[j] = tempDomino;
                    }
                }
            }
            return dominoList;
        }
    }
}
