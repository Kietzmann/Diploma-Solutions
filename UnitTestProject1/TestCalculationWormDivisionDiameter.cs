using DiplomaSolutions;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class TestCalculationWormDivisionDiameter
    {
        [Test]
        public void TestCalculationBeginDiameter()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationDiameters(inputData, calculatedData);
            inputData.q = 10;
            inputData.m = 5;
            inputData.x = -1;
            calc.calculateBeginDiameter();
            Assert.AreEqual(40, calculatedData.dW1);
        }

        [Test]
        public void TestCalculationDivisionWheelDiameter()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationDiameters(inputData, calculatedData);
            inputData.z2 = 56;
            inputData.m = 5;
            calc.calculateDivisionDiameterWormWheel();
            Assert.AreEqual(280.0, calculatedData.d2);
        }

        [Test]
        public void TestCalculationMainDiameter()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationDiameters(inputData, calculatedData);
            inputData.z1 = 4;
            inputData.m = 5;
            calculatedData.gammaB = 0.510537895029208;
            calc.calculateMainDiameter();
            Assert.AreEqual(35.710133069102234d, calculatedData.dB);
        }

        [Test]
        public void TestCalculationWormDivDiameter()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationDiameters(inputData, calculatedData);
            inputData.q = 10;
            inputData.m = 5;
            calc.calculateWormDivisionDiameter();
            Assert.AreEqual(50, calculatedData.d1);
        }

        [Test]
        public void TestCalculationWormSpinHeight()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationDiameters(inputData, calculatedData);
            inputData.h1 = 2.186;
            inputData.m = 5;
            calc.calculateWormSpinHeight();
            Assert.AreEqual(10.93, calculatedData.h1);
        }
        [Test]
        public void TestCalculationHeadWormSpinHeight()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationDiameters(inputData, calculatedData);
            inputData.hAstrxAL = 1;
            inputData.m = 5;
            calc.calculateHeadWormSpinHeight();
            Assert.AreEqual(5, calculatedData.hAL);
        }

        [Test]
        public void TestCalculationDiameterPeakWormSpin()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationDiameters(inputData, calculatedData);
            calculatedData.d1 = 50;
            inputData.hAstrxAL = 1;
            inputData.m = 5;
            calc.calculateDiameterPeakWormSpin();
            Assert.AreEqual(60, calculatedData.dA1);
        }
        [Test]
        public void TestCalculationDiametersToothWormGear()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationDiameters(inputData, calculatedData);
            calculatedData.d2 = 280;
            inputData.hAstrxAL = 1;
            inputData.m = 5;
            inputData.x = -1;
            calc.calculateDiametersToothWormGear();
            Assert.AreEqual(280, calculatedData.dA2);
        }

        [Test]
        public void TestCalculationBiggestWormDiameter()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationDiameters(inputData, calculatedData);
            calculatedData.dA2 = 280;
            inputData.m = 5;
            inputData.z1 = 4;
            inputData.x = -1;
            inputData.gearType = "ZI";
            calc.calculateBiggestWormDiameter();
            Assert.AreEqual(285, calculatedData.dAE2);
        }
    }
}