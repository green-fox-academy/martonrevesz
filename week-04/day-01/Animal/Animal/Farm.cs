using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmNS
{
    public class Farm
    {
        public List<Animal> AnimalList { get; set; }
        public int FreePlaces { get; set; }

        public Farm(List<Animal> animalList, int freePlaces)
        {
            AnimalList = animalList;
            FreePlaces = freePlaces - animalList.Count;
        }

        public int Breed()
        {
            if (FreePlaces > 0)
            {
                AnimalList.Add(new Animal());
                FreePlaces--;
            }
            return AnimalList.Count;
        }
        public Animal Slaughter()
        {
            var theLeastHungry = AnimalList[0];
            foreach (Animal item in AnimalList)
            {
                if (theLeastHungry.HungerValue > item.HungerValue)
                {
                    theLeastHungry = item;
                }
            }
            
            AnimalList.Remove(theLeastHungry);
            FreePlaces++;
            return theLeastHungry;
        }
    }
}
