using System;

namespace Garage
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatterKWh {get; set;}

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla went .... I'm silent!");
        }
    }
}