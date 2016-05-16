﻿using System;

namespace DiplomaSolutions
{
    public class CalculationDiameters
    {
        public CalculatedData calculatedData;

        public InputData inputData;

        public CalculationDiameters(InputData inputData, CalculatedData calculatedData)
        {
            this.inputData = inputData;
            this.calculatedData = calculatedData;
        }

        public void invokeCalculations()
        {
            calculateWormDivisionDiameter();
            calculateDivisionDiameterWormGear();
            calculateBeginDiameter();
            calculateMainDiameter();
            calculateWormSpinHeight();
            calculateHeadWormSpinHeight();
            calculateDiameterPeakWormSpin();
            calculateDiametersToothWormGear();
            calculateBiggestWormDiameter();
        }


        public void calculateWormDivisionDiameter()
        {
            calculatedData.d1 = inputData.q*inputData.m;
        }

        public void calculateDivisionDiameterWormGear()
        {
            calculatedData.d2 = inputData.z2*inputData.m;
        }

        public void calculateBeginDiameter()
        {
            calculatedData.dW1 = (inputData.q + inputData.x*2)*
                                 inputData.m;
        }

        public void calculateMainDiameter()
        {
            calculatedData.dB = inputData.z1*inputData.m/
                                Math.Tan(calculatedData.gammaB);
        }

        public void calculateWormSpinHeight()
        {
            calculatedData.h1 = inputData.hAstrxAL*inputData.m;
        }

        public void calculateHeadWormSpinHeight()
        {
            calculatedData.hAL = inputData.hAstrxAL*inputData.m;
        }

        public void calculateDiameterPeakWormSpin()
        {
            calculatedData.dA1 = calculatedData.d1 + 2*inputData.hAstrxAL*inputData.m;
        }

        public void calculateDiametersToothWormGear()
        {
            calculatedData.dA2 = calculatedData.d2 +
                                 2*(inputData.hAstrxAL + inputData.x)*
                                 inputData.m;
        }

        public void calculateBiggestWormDiameter()
        {
            var K = 2;
            if (inputData.gearType == WormGearTypes.GearTypes.ZN1 || inputData.gearType == WormGearTypes.GearTypes.ZN2 ||
                inputData.gearType == WormGearTypes.GearTypes.ZN3)
            {
                K = 1;
            }
            if (inputData.gearType == WormGearTypes.GearTypes.ZT1 || inputData.gearType == WormGearTypes.GearTypes.ZT2)
            {
                K = 4;
            }
            calculatedData.dAE2 = calculatedData.dA2 + 6*inputData.m/(inputData.z1 + K);
        }
    }
}