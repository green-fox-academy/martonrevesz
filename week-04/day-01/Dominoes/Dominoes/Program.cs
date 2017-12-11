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
            var finalList = OrderDominoes(dominoes);
            foreach (Domino item in finalList)
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
            return dominoes;
        }

        static List<Domino> OrderDominoes(List<Domino> dominoList)
        {
            var newList = new List<Domino>();
            int originalListLength = dominoList.Count;

            newList.Add(dominoList[0]);
            dominoList.Remove(dominoList[0]);
            for (int i = 1; i < originalListLength - 1; i++)
            {
                for (int j = 0; j < dominoList.Count; j++)
                {
                    if (newList[newList.Count - 1].GetValues()[1] == dominoList[j].GetValues()[0])
                    {
                        newList.Add(dominoList[j]);
                        dominoList.Remove(dominoList[j]);
                    }
                }
            }
            return newList;
        }
    }
}
