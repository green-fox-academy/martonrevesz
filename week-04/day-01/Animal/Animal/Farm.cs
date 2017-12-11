using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Farm
    {
        public List<Animal> AnimalList { get; set; }
        public int FreePlaces { get; set; }

        public Farm(List<Animal> animalList, int freePlaces)
        {
            AnimalList = animalList;
            FreePlaces = freePlaces - animalList.Count;
        }

        public void Breed()
        {
            if (FreePlaces > 0)
            {
                AnimalList.Add(new Animal());
                FreePlaces--;
            }
        }
        public void Slaughter()
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
        }
    }
}
