using System;

namespace Garage
{
    public interface IElectric
    {
        public int CurrentChargePercentage {get; }

        public void ChargeBattery();
    }

    public interface IGas
    {
        public int CurrentTankPercentage {get; }

        public void RefuelTank();
    }
}