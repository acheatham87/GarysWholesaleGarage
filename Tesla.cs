using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectric // Electric car
    {
        public double BatterKWh {get; set;}
        public int CurrentChargePercentage {get; set;} = 100;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla went .... I'm silent!");
        }
    }
}