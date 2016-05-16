using System;

namespace DiplomaSolutions
{
    public class CalculationControls
    {
        private readonly CalculatedData calculatedData;
        private readonly InputData inputData;

        public CalculationControls(InputData inputData, CalculatedData calculatedData)
        {
            this.calculatedData = calculatedData;
            this.inputData = inputData;
        }

        public void invokeCalculations()
        {
            calculationWormStep();
            calculationSpinStep();
            calculationDivisionWormSpin();
            calculationChordusHeight();
            calculationRollerWormDim();
        }


        private void calculationWormStep()
        {
            calculatedData.p1 = Math.PI*inputData.m;
        }

        private void calculationSpinStep()
        {
            calculatedData.pz1 = calculatedData.p1*inputData.z1;
        }

        private void calculationDivisionWormSpin()
        {
            calculatedData.sa1 = inputData.m*Math.Cos(calculatedData.gamma)*inputData.sAstrx;
        }

        private void calculationChordusHeight()
        {
            var tgs =
                Math.Tan(0.5*Math.Asin(calculatedData.sa1*Math.Pow(Math.Sin(calculatedData.gamma), 2)/calculatedData.d1));
            calculatedData.ha1 = inputData.hAstrxAL*inputData.m + 0.5*calculatedData.sa1*tgs;
        }

        private void calculationRollerDimensions()
        {
            calculatedData.D = 1.67*inputData.m;
        }

        private void calculationRollerWormDim()
        {
            calculatedData.M1 = calculatedData.d1 -
                                (calculatedData.p1 - inputData.sAstrx*inputData.m)*Math.Cos(calculatedData.gamma)/
                                Math.Tan(calculatedData.alphaN) +
                                calculatedData.D*(1/Math.Sin(calculatedData.alphaN) + 1);
            if (inputData.gearType == WormGearTypes.GearTypes.ZA)
            {
                calculatedData.M1 = calculatedData.d1 -
                                    (calculatedData.p1 - inputData.sAstrx*inputData.m)*Math.Cos(calculatedData.gamma)/
                                    Math.Tan(calculatedData.alphaX) +
                                    calculatedData.D*(1/Math.Sin(calculatedData.alphaX) + 1);
            }
        }
    }
}