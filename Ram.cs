using System;

namespace Garage
{
    public class Ram : Vehicle, IGas // Gas powered truck
    {
        public double FuelCapacity {get; set;}

        public int CurrentTankPercentage {get; set;} = 100;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram went RRrrrruuuuuummmmbble!");
        }
        
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram quickly turns {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram slams on the breaks");
        }
    }
}