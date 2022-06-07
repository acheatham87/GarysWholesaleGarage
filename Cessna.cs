using System;

namespace Garage
{
    public class Cessna : Vehicle, IGas // Propellor light aircraft
    {
        public double FuelCapacity {get; set;}

        public int CurrentTankPercentage {get; set;} = 100;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna went zzzzzzzzzzooooooooomm!");
        }
    }
}