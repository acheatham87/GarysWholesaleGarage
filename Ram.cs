using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity {get; set;}

        public void RefuelTank()
        {
            // method definition omitted
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