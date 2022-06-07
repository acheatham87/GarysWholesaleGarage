using System;

namespace Garage
{
    public class Zero : Vehicle, IElectric // Electric motorcycle
    {
        public double BatterKWh {get; set;}

        public int CurrentChargePercentage {get; set;} = 100;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero went Vrrrrooooooooommmmm!");
        }
    }
}