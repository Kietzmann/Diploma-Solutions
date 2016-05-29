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

        public void invokeCalculations()
        {
            calculateCurveRadius();
            calculateWormCutLength();
            calculateWormGearWidth();
            calculateNotchRadius();
            calculateAxisToCenterDistance();
            calculateAngleCrossingWormCircle();
        }

        public void calculateCurveRadius()
        {
            calculatedData.RoF1 = inputData.RoAstrxF1*inputData.m;
        }

        public void calculateWormCutLength()
        {
            var firstAdd = Math.Pow(calculatedData.dAE2/2.0, 2);
            var secondAdd = Math.Pow(inputData.aW - calculatedData.dA1/2.0, 2);
            var thirdAdd = Math.PI*inputData.m/2.0;
            calculatedData.b1 = 2*Math.Sqrt(firstAdd - secondAdd + thirdAdd);
        }

        public void calculateWormGearWidth()
        {
            //TODO: check variants with another z1;
            if (inputData.gearType != "ZT1" || inputData.gearType != "ZT2")
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
            calculatedData.rK = 0.5*calculatedData.d1 - 5;
        }

        public void calculateAxisToCenterDistance()
        {
            if (inputData.gearType == "ZT1" || inputData.gearType == "ZT2")
            {
                calculatedData.cU = calculatedData.d1/2.0 + inputData.Ro*Math.Sin(inputData.alphaN);
            }
        }

        public void calculateAngleCrossingWormCircle()
        {
            if (inputData.gearType == "ZT2")
            {
                calculatedData.gammaU = inputData.m*inputData.z1/(2*calculatedData.cU);
            }
            if (inputData.gearType == "ZT1")
            {
                calculatedData.gammaU = calculatedData.gamma;
            }
        }
    }
}