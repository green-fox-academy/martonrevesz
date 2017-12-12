using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircrafts
{
    class Carrier
    {
        public List<Aircraft> AircraftList { get; set; }
        public int AmmoStore { get; set; }
        public int HP { get; set; }
        public int AllDamage { get; set; }

        public Carrier(int ammoStore, int hp)
        {
            AircraftList = new List<Aircraft>();
            AmmoStore = ammoStore;
            HP = hp;
        }

        public void AddAircraft(Aircraft aircraft)
        {
            if (!AircraftList.Contains(aircraft))
            {
                AircraftList.Add(aircraft);
            }
        }

        public void Fill()
        {
            try
            {
                if (AmmoStore == 0)
                {
                    throw new Exception();
                }
                foreach (Aircraft aircraft in AircraftList)
                {
                    if (aircraft.GetAircraftType() == "F35")
                    {
                        AmmoStore = aircraft.Refill(AmmoStore);
                    }
                }
                foreach (Aircraft aircraft in AircraftList)
                {
                    if (aircraft.GetAircraftType() == "F16")
                    {
                        AmmoStore = aircraft.Refill(AmmoStore);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Fight(Carrier anotherCarrier)
        {
            foreach (Aircraft aircraft in AircraftList)
            {
                int actualDamage = aircraft.Fight();
                anotherCarrier.HP -= Math.Min(actualDamage, anotherCarrier.HP);
                AllDamage += actualDamage;
            }
        }

        public string GetStatus()
        {
            var sb = new StringBuilder();
            sb.Append(String.Format("HP: {0}, Aircraft count: {1}, Ammo Storage: {2}, Total damage: {3}", HP, AircraftList.Count, AmmoStore, AllDamage));
            sb.Append("\nAircrafts \n");
            foreach (Aircraft aircraft in AircraftList)
            {
                sb.Append(aircraft.GetStatus() + "\n");
            }
            if (HP <= 0)
            {
                sb.Append("It's dead Jim :(");
            }
            return sb.ToString();
        }
    }
}
