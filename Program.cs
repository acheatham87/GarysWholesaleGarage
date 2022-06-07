using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                CurrentChargePercentage = 65
            };
            Zero fx = new Zero()
            {
                CurrentChargePercentage = 75
            };
            Tesla modelS = new Tesla()
            {
                CurrentChargePercentage = 15
            };

            List<IElectric> electricVehicles = new List<IElectric>()
            {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectric ev in electricVehicles)
            {
                ev.ChargeBattery();
            }

            foreach(IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /*****************************************************************/

            Ram ram = new Ram()
            {
                CurrentTankPercentage = 50
            };
            Cessna cessna150 = new Cessna()
            {
                CurrentTankPercentage = 25
            };

            List<IGas> gasVehicles = new List<IGas>()
            {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IGas gv in gasVehicles)
            {
                gv.RefuelTank();
            }

            foreach(IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}


