using System;

namespace DiplomaSolutions
{
    public class CalculationWormDimensions
    {
        public CalculatedData calculatedData;
        public InputData inputData;


        public CalculationWormDimensions(CalculatedData calculatedData, InputData inputData)
        {
            this.calculatedData = calculatedData;
            this.inputData = inputData;
        }


        public void calculateWormCutLength()
        {
            var firstAdd = Math.Pow(calculatedData.dAE2/2.0, 2);
            var secondAdd = Math.Pow(inputData.aW - calculatedData.dA1/2.0, 2);
            var thirdAdd = Math.PI*inputData.m/2.0;
            calculatedData.b1 = 2*Math.Sqrt(firstAdd - secondAdd + thirdAdd);
        }

        public void calculateWormGearWidth(WormGearTypes.GearTypes gearType)
        {
            //TODO: check variants with another z1;
            if (gearType != WormGearTypes.GearTypes.ZT1 || gearType != WormGearTypes.GearTypes.ZT2)
            {
                if (inputData.z1 <= 4)
                {
                    calculatedData.b2 = 0.67*calculatedData.dA1;
                }
                if (inputData.z1 <= 3)
                {
                    calculatedData.b2 = 0.75*calculatedData.dA1;
                }
            }
            else
            {
                calculatedData.b2 = (0.7 - 0.1*inputData.x)*calculatedData.dA1;
            }
        }

        public void calculateNotchRadius()
        {
            //TODO: ask about ha1
            calculatedData.rK = 0.5*calculatedData.d1 - calculatedData.hAL;
        }

        public void calculateAxisToCenterDistance(WormGearTypes.GearTypes gearType)
        {
            if (gearType == WormGearTypes.GearTypes.ZT1 || gearType == WormGearTypes.GearTypes.ZT2)
            {
                calculatedData.cU = calculatedData.d1/2.0 + inputData.Ro*Math.Sin(calculatedData.alphaN);
            }
        }

        public void calculateAngleCrossingWormCircle(WormGearTypes.GearTypes gearType)
        {
            if (gearType == WormGearTypes.GearTypes.ZT2)
            {
                calculatedData.gammaU = inputData.m*inputData.z1/(2*calculatedData.cU);
            }
            if (gearType == WormGearTypes.GearTypes.ZT1)
            {
                calculatedData.gammaU = calculatedData.gamma;
            }
        }
    }
}