using System;

namespace DiplomaSolutions
{
    public class CalculateWormDimensions
    {
        public readonly CalculateDiameters calculationDiameters;
        public readonly CalculationGeometricParams calculationGeometric;
        private double b1;
        private double b2;
        private double cU;
        private double gammaU;
        private double rK;
        private double Ro;
        private double RoAstrxF1;

        private double RoF1;

        public CalculateWormDimensions(CalculationGeometricParams calculationGeometric,
            CalculateDiameters calculationDiameters)
        {
            this.calculationGeometric = calculationGeometric;
            this.calculationDiameters = calculationDiameters;
        }

        public void calculateWormGearRadius()
        {
            RoF1 = RoAstrxF1*calculationGeometric.M;
        }

        public void calculateWormCutLength()
        {
            var firstAdd = Math.Pow(calculationDiameters.DAe2/2.0, 2);
            var secondAdd = Math.Pow(calculationGeometric.AW - calculationDiameters.DA1/2.0, 2);
            var thirdAdd = Math.PI*calculationGeometric.M/2.0;
            b1 = 2*Math.Sqrt(firstAdd - secondAdd + thirdAdd);
        }

        public void calculateWormGearWidth(WormGearTypes.GearTypes gearType)
        {
            //TODO: check variants with another z1;
            if (gearType != WormGearTypes.GearTypes.ZT1 || gearType != WormGearTypes.GearTypes.ZT2)
            {
                if (calculationGeometric.Z1 <= 4)
                {
                    b2 = 0.67*calculationDiameters.DA1;
                }
                if (calculationGeometric.Z1 <= 3)
                {
                    b2 = 0.75*calculationDiameters.DA1;
                }
            }
            else
            {
                b2 = (0.7 - 0.1*calculationGeometric.X)*calculationDiameters.DA1;
            }
        }

        public void calculateNotchRadius()
        {
            //TODO: ask about ha1
            rK = 0.5*calculationDiameters.D1 - calculationDiameters.HAl;
        }

        public void calculateAxisToCenterDistance(WormGearTypes.GearTypes gearType)
        {
            if (gearType == WormGearTypes.GearTypes.ZT1 || gearType == WormGearTypes.GearTypes.ZT2)
            {
                cU = calculationDiameters.D1/2.0 + Ro*Math.Sin(calculationGeometric.AlphaN);
            }
        }

        public void calculateAngleCrossingWormCircle(WormGearTypes.GearTypes gearType)
        {
            if (gearType == WormGearTypes.GearTypes.ZT2)
            {
                gammaU = calculationGeometric.M*calculationGeometric.Z1/(2*cU);
            }
            if (gearType == WormGearTypes.GearTypes.ZT1)
            {
                gammaU = calculationGeometric.Gamma;
            }
        }
    }
}