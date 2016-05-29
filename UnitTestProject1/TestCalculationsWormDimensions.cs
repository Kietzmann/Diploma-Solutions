using DiplomaSolutions;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    internal class TestCalculationsWormDimensions
    {
        [Test]
        public void TestCalculationCurveRadius()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationWormDimensions(calculatedData, inputData);
            inputData.RoAstrxF1 = 0.3;
            inputData.m = 5;
            calc.calculateCurveRadius();
            Assert.AreEqual(1.5, calculatedData.RoF1);
        }
        [Test]
        public void TestCalculationWormCutLength()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationWormDimensions(calculatedData, inputData);
            calculatedData.dAE2 = 285;
            inputData.aW = 160;
            calculatedData.dA1 = 60;
            inputData.aW= 160;
            calc.calculateWormCutLength();
            Assert.AreEqual(116.72617529928752d, calculatedData.b1);
        }
        [Test]
        public void TestCalculationWormCutWidth()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationWormDimensions(calculatedData, inputData);
            inputData.gearType = "ZI";
            inputData.z1 = 4;
            calculatedData.dA1 = 60;
            calc.calculateWormGearWidth();
            Assert.AreEqual(40.2, calculatedData.b2);
        }
        [Test]
        public void TestCalculationNotchRadius()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationWormDimensions(calculatedData, inputData);
            calculatedData.d1 = 50;
            calc.calculateNotchRadius();
            Assert.AreEqual(20, calculatedData.rK);
        }
        [Test]
        public void TestCalculationAxisToCenterDistance()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationWormDimensions(calculatedData, inputData);
            inputData.gearType = "ZT1";
            calculatedData.d1 = 50;
            inputData.Ro = 30;
            inputData.alphaN = 0.3491;
            calc.calculateAxisToCenterDistance();
            Assert.AreEqual(35.261566997632599d, calculatedData.cU);
        }
        [Test]
        public void TestCalculationAngleCrossingWormCircle()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationWormDimensions(calculatedData, inputData);
            inputData.gearType = "ZT2";
            calculatedData.cU = 35.261566997632599d;
            inputData.m = 5;
            inputData.z1 = 4;
            calc.calculateAngleCrossingWormCircle();
            Assert.AreEqual(0.2835948839333029d, calculatedData.gammaU);
        }
    }
}