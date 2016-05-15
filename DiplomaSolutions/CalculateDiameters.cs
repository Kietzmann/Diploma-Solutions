using System;

namespace DiplomaSolutions
{
    public class CalculateDiameters
    {
        private readonly CalculationGeometricParams calculationGeometric;

        private double d1;
        private double d2;
        private double dA1;
        private double dA2;
        private double dAE2;
        private double dB;
        private double dW1;
        private double h1;
        private double hAL;

        public double D1
        {
            get { return d1; }
            set { d1 = value; }
        }

        public double D2
        {
            get { return d2; }
            set { d2 = value; }
        }

        public double DA1
        {
            get { return dA1; }
            set { dA1 = value; }
        }

        public double DA2
        {
            get { return dA2; }
            set { dA2 = value; }
        }

        public double DAe2
        {
            get { return dAE2; }
            set { dAE2 = value; }
        }

        public double DB
        {
            get { return dB; }
            set { dB = value; }
        }

        public double DW1
        {
            get { return dW1; }
            set { dW1 = value; }
        }

        public double H1
        {
            get { return h1; }
            set { h1 = value; }
        }

        public double HAl
        {
            get { return hAL; }
            set { hAL = value; }
        }

        public CalculateDiameters(CalculationGeometricParams calculationGeometric)
        {
            this.calculationGeometric = calculationGeometric;
        }

        public void calculateWormDivisionDiameter()
        {
            d1 = calculationGeometric.Q*calculationGeometric.M;
        }

        public void calculateDivisionDiameterWormGear()
        {
            d2 = calculationGeometric.Z2*calculationGeometric.M;
        }

        public void calculateBeginDiameter()
        {
            dW1 = (calculationGeometric.Q + calculationGeometric.X*2)*calculationGeometric.M;
        }

        public void calculateMainDiameter()
        {
            dB = calculationGeometric.Z1*calculationGeometric.M/Math.Tan(calculationGeometric.GammaB);
        }

        public void calculateWormSpinHeight()
        {
            h1 = calculationGeometric.HAstrxAl*calculationGeometric.M;
        }

        public void calculateHeadWormSpinHeight()
        {
            hAL = calculationGeometric.HAstrxAl*calculationGeometric.M;
        }

        public void calculateDiameterPeakWormSpin()
        {
            dA1 = d1 + 2*calculationGeometric.HAstrxAl*calculationGeometric.M;
        }

        public void calculateDiametersToothWormGear()
        {
            dA2 = d2 + 2*(calculationGeometric.HAstrxAl + calculationGeometric.X)*calculationGeometric.M;
        }

        public void calculateBiggestWormDiameter(WormGearTypes.GearTypes gear)
        {
            var K = 2;
            if (gear == WormGearTypes.GearTypes.ZN1 || gear == WormGearTypes.GearTypes.ZN2 ||
                gear == WormGearTypes.GearTypes.ZN3)
            {
                K = 1;
            }
            if (gear == WormGearTypes.GearTypes.ZT1 || gear == WormGearTypes.GearTypes.ZT2)
            {
                K = 4;
            }
            dAE2 = dA2 + 6*calculationGeometric.M/(calculationGeometric.Z1 + K);
        }
    }
}