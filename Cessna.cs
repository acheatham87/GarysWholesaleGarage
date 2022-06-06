using System;

namespace Garage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity {get; set;}

        public void RefuelTank()
        {
            // method difinition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna went zzzzzzzzzzooooooooomm!");
        }
    }
}