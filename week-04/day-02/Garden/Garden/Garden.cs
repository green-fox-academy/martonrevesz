using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Garden
    {
        public List<Plant> PlantList { get; set; }

        public Garden()
        {
            PlantList = new List<Plant>();
        }

        public void AddPlant(Plant plant)
        {
            if (!PlantList.Contains(plant))
            {
                PlantList.Add(plant);
            }
        }

        public void Water(int amount)
        {
            Console.WriteLine("Watering with " + amount);
            int countThirsty = 0;
            foreach (Plant plant in PlantList)
            {
                if (plant.Treshold > plant.CurrentWater)
                {
                    countThirsty++;
                }
            }
            foreach (Plant plant in PlantList)
            {
                if (plant.Treshold > plant.CurrentWater)
                {
                    plant.AbsorbWater(amount / (double)countThirsty);
                }
            }
        }

        public void PrintStatus()
        {
            foreach (Plant plant in PlantList)
            {
                string waterStatus;
                if (plant.CurrentWater < plant.Treshold)
                {
                    waterStatus = "needs water";
                }
                else
                {
                    waterStatus = "doesnt need water";
                }
                Console.WriteLine("The {0} {1} {2}", plant.Color, plant.GetType().ToString().Substring(7), waterStatus);
            }
        }
    }
}
