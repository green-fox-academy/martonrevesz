using System;

namespace PetrolStation
{
    public class Station
    {
        public int GasAmount { get; set; }

        public Station(int gasAmount)
        {
            GasAmount = gasAmount;
        }

        public void Refill(Car car)
        {
            int fuelToFill = Math.Min(car.Capacity, GasAmount);
            GasAmount -= fuelToFill;
            car.GasAmount += fuelToFill;
        }
    }
}

