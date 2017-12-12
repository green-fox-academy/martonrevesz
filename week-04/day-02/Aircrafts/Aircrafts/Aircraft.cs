using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircrafts
{
    public abstract class Aircraft
    {
        public int MaxAmmo { get; set; }
        public int BaseDamage { get; set; }
        public int CurrentAmmo { get; set; }
        public int AllDamage { get; set; } = 0;

        public Aircraft()
        {
            CurrentAmmo = 0;
        }

        public int Fight()
        {
            int damageCaused = CurrentAmmo * BaseDamage;
            CurrentAmmo = 0;
            return damageCaused;
        }

        public int Refill(int amount)
        {
            int toLoad = Math.Min(amount, MaxAmmo - CurrentAmmo);
            CurrentAmmo += toLoad;
            return amount - toLoad;
        }

        public string GetAircraftType()
        {
            return this.GetType().ToString().Substring(10);
        }

        public string GetStatus()
        {
            return String.Format("Type {0}, Ammo: {1}, Base Damage: {2}, All Damage: {3}", GetAircraftType(), CurrentAmmo, BaseDamage, AllDamage);
        }
    }
}
