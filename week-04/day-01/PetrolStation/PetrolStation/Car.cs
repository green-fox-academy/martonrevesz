namespace PetrolStation
{
    public class Car
    {
        public int GasAmount { get; set; }
        public int Capacity { get; set; }

        public Car()
        {
            GasAmount = 0;
            Capacity = 100;
        }
    }
}