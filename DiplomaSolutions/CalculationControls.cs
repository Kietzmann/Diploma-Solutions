using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            calculatedData.sa1 = inputData.m*Math.Cos(calculationGeometric.Gamma)*inputData.sAstrx;
        }

        private void calculationRollerDimensions()
        {
            calculatedData.D = 1.67*inputData.m;
        }
    }
}
