using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                BatterKWh = 2.00,
                MainColor = "red",
                MaximumOccupancy = 2
            };
            Tesla modelS = new Tesla()
            {
                BatterKWh = 5.00,
                MainColor = "white",
                MaximumOccupancy = 4
            };
            Cessna mx410 = new Cessna()
            {
                FuelCapacity = 15.00,
                MainColor = "blue",
                MaximumOccupancy = 10
            };
            Ram trx1500 = new Ram()
            {
                FuelCapacity = 75.00,
                MainColor = "silver",
                MaximumOccupancy = 5
            };

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
            Console.WriteLine();
            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            Console.WriteLine();
            mx410.Drive();
            mx410.Turn("around");
            mx410.Stop();
            Console.WriteLine();
            trx1500.Drive();
            trx1500.Turn("left");
            trx1500.Stop();
        }
    }
}


