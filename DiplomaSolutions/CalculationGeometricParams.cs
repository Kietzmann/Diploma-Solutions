using System;

namespace DiplomaSolutions
{
    public class CalculationGeometricParams
    {
        public CalculatedData calculatedData;
        public InputData inputData;


        public CalculationGeometricParams(InputData inputData, CalculatedData calculatedData)
        {
            this.inputData = inputData;
            this.calculatedData = calculatedData;
        }

        public void invokeCalculations()
        {
            //calculateQuantityOfTeeth();
            calculateWormDrag();
            calculateTransmitionCoef();
            calculateInteraxalDistance();
            calculateDividerLiftAngle();
            calculateMainLiftAngle();
            calculateBeginingStartCoef();
            calculateAngleAxisCutting();
            calculateAngleNormalCutting();
            calculateMinCoefDrag();
            calculateMaxCoefDrag();
        }


        public void calculateQuantityOfTeeth()
        {
            calculatedData.z2 = inputData.z1*calculatedData.uCurr;
        }

        public void calculateWormDrag()
        {
            calculatedData.x = inputData.aW/inputData.m - 0.5*(inputData.z2 + inputData.q);
        }

        public void calculateTransmitionCoef()
        {
            calculatedData.u = inputData.z2/inputData.z1;
        }

        public void calculateInteraxalDistance()
        {
            calculatedData.alphaW = 0.5*(inputData.z2 + inputData.q + 2*inputData.x)*inputData.m;
        }

        public void calculateDividerLiftAngle()
        {
            calculatedData.gamma = Math.Atan(inputData.z1/inputData.q);
        }

        public void calculateMainLiftAngle()
        {
            if (inputData.gearType == "ZI")
            {
                calculatedData.gammaB = Math.Acos(Math.Cos(inputData.alphaN) * Math.Cos(calculatedData.gamma));
            }
        }

        public void calculateBeginingStartCoef()
        {
            calculatedData.gammaOmega = Math.Atan((double)inputData.z1/(double)(inputData.q + 2*inputData.x));
        }

        public void calculateAngleAxisCutting()
        {
            if (inputData.gearType != "ZA")
            {
                calculatedData.alphaX = Math.Atan(Math.Tan(inputData.alphaN)/Math.Cos(calculatedData.gamma));
            }
        }

        public void calculateAngleNormalCutting()
        {
            if (inputData.gearType == "ZA")
            {
                calculatedData.alphaN = Math.Atan(Math.Tan(calculatedData.alphaX)*Math.Cos(calculatedData.gamma));
            }
        }

        public void calculateMinCoefDrag()
        {
            if(inputData.gearType != "ZT1" || inputData.gearType != "ZT2") { 
            calculatedData.xMin = inputData.hAstrxAL - inputData.z2*Math.Pow(Math.Sin(calculatedData.alphaX), 2)/2.0;
        }
        }

        public void calculateMaxCoefDrag()
        {
            if (inputData.gearType != "ZT1" || inputData.gearType != "ZT2") {
                
                    double degrees = calculatedData.alphaX/0.01745329;
                calculatedData.xMax = 0.05*inputData.z2 - 0.64 + inputData.hAstrxAL - 0.024*degrees;

                }
            }
    }
}