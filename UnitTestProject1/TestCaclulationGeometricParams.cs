using System;
using DiplomaSolutions;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class TestCaclulationGeometricParams
    {
        [Test]
        public void TestCalculationTransmitionCoef()
        {
            CalculatedData calculatedData = new CalculatedData();
            InputData inputData = new InputData();
            CalculationGeometricParams calc = new CalculationGeometricParams(inputData,calculatedData);
            inputData.z2 = 56;
            inputData.z1 = 4;
            calc.calculateTransmitionCoef();
            Assert.AreEqual(14.0,calculatedData.u);
        }
        [Test]
        public void TestCalculationWormDrag()
        {
            CalculatedData calculatedData = new CalculatedData();
            InputData inputData = new InputData();
            CalculationGeometricParams calc = new CalculationGeometricParams(inputData, calculatedData);
            inputData.m = 5;
            inputData.q = 10;
            inputData.z2 = 56;
            inputData.aW = 160;
            calc.calculateWormDrag();
            Assert.AreEqual(-1, calculatedData.x);
        }
        [Test]
        public void TestCalculationBetweenAxes()
        {
            CalculatedData calculatedData = new CalculatedData();
            InputData inputData = new InputData();
            CalculationGeometricParams calc = new CalculationGeometricParams(inputData, calculatedData);
            inputData.m = 5;
            inputData.q = 10;
            inputData.z2 = 56;
            inputData.x = -1;
            calc.calculateInteraxalDistance();
            Assert.AreEqual(160, calculatedData.alphaW);
        }
        [Test]
        public void TestCalculationLiftAngle()
        {
            CalculatedData calculatedData = new CalculatedData();
            InputData inputData = new InputData();
            CalculationGeometricParams calc = new CalculationGeometricParams(inputData, calculatedData);
            inputData.q = 10;
            inputData.z1 = 4;
            calc.calculateDividerLiftAngle();
            Assert.AreEqual(0.3805063771123649d, calculatedData.gamma);
        }
        [Test]
        public void TestCalculationMainLiftAngle()
        {
            CalculatedData calculatedData = new CalculatedData();
            InputData inputData = new InputData();
            CalculationGeometricParams calc = new CalculationGeometricParams(inputData, calculatedData);
            inputData.alphaN = 0.3490658503988659;
            calculatedData.gamma = 0.3805063771123649;
            inputData.gearType = "ZI";
            calc.calculateMainLiftAngle();
           
            Assert.AreEqual(0.51053604970756783d, calculatedData.gammaB);
        }


        [Test]
        public void TestCalculationBeginingStartCoef()
        {
            CalculatedData calculatedData = new CalculatedData();
            InputData inputData = new InputData();
            CalculationGeometricParams calc = new CalculationGeometricParams(inputData, calculatedData);
            inputData.z1 = 4;
            inputData.q = 10;
            inputData.x = -1;
            calc.calculateBeginingStartCoef();
            Assert.AreEqual(0.46364760900080609d, calculatedData.gammaOmega);
        }

        [Test]
        public void TestCalculationAngleAxisCutting()
        {
            CalculatedData calculatedData = new CalculatedData();
            InputData inputData = new InputData();
            CalculationGeometricParams calc = new CalculationGeometricParams(inputData, calculatedData);
            inputData.gearType = "ZI";
            inputData.alphaN = 0.3490658503988659;
            calculatedData.gamma = 0.3805063771123649d;
            calc.calculateAngleAxisCutting();
            Assert.AreEqual(0.37359773981548156d, calculatedData.alphaX);


        }

        [Test]
        public void TestCalculationAngleNormalCutting()
        {
            CalculatedData calculatedData = new CalculatedData();
            InputData inputData = new InputData();
            CalculationGeometricParams calc = new CalculationGeometricParams(inputData, calculatedData);
            inputData.gearType = "ZA";
            calculatedData.alphaX = 0.37359773981548156d;
            calculatedData.gamma = 0.3805063771123649d;
            calc.calculateAngleNormalCutting();
            Assert.AreEqual(0.3490658503988659d, calculatedData.alphaN);

        }
        [Test]
        public void TestCalculationMinCoefDrag()
        {
            CalculatedData calculatedData = new CalculatedData();
            InputData inputData = new InputData();
            CalculationGeometricParams calc = new CalculationGeometricParams(inputData, calculatedData);
            inputData.hAstrxAL = 1;
            inputData.z2 = 56;
            calculatedData.alphaX = 0.37359773981548156d;
            calc.calculateMinCoefDrag();
            Assert.AreEqual(-2.7296327786524883d, calculatedData.xMin);

        }

        [Test]
        public void TestCalculationMaxCoefDrag()
        {
            CalculatedData calculatedData = new CalculatedData();
            InputData inputData = new InputData();
            CalculationGeometricParams calc = new CalculationGeometricParams(inputData, calculatedData);
            inputData.hAstrxAL = 1;
            inputData.z2 = 56;
            calculatedData.alphaX = 0.37359773981548156d;
            calc.calculateMaxCoefDrag();
            Assert.AreEqual(2.6462661563767318d, calculatedData.xMax);
        }
    }
}
