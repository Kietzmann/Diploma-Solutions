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


        public void calculationWormStep()
        {
            calculatedData.p1 = Math.PI*inputData.m;
        }

        public void calculationSpinStep()
        {
            calculatedData.pz1 = calculatedData.p1*inputData.z1;
        }

        public void calculationDivisionWormSpin()
        {
            calculatedData.sa1 = inputData.m*Math.Cos(calculatedData.gamma)*inputData.sAstrx;
        }

        public void calculationChordusHeight()
        {
            var tgs =
                Math.Tan(0.5*Math.Asin(calculatedData.sa1*Math.Pow(Math.Sin(calculatedData.gamma), 2)/calculatedData.d1));
            calculatedData.ha1 = inputData.hAstrxAL*inputData.m + 0.5*calculatedData.sa1*tgs;
        }

        public void calculationRollerDimensions()
        {
            calculatedData.D = 1.67*inputData.m;
        }

        public void calculationRollerWormDim()
        {
            var firstAdd = Utils.chooseRollerDimension(inputData.m)*(1/Math.Sin(inputData.alphaN) + 1);
            var secondAdd = calculatedData.p1 - inputData.sAstrx*inputData.m;

            calculatedData.M1 = calculatedData.d1 - secondAdd*Math.Cos(calculatedData.gamma)/Math.Tan(inputData.alphaN) +
                                firstAdd;
        }
    }
}