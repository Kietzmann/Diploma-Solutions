using DiplomaSolutions;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class TestCalculationControls
    {
        [Test]
        public void TestCalculationChordusHeight()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationControls(inputData, calculatedData);
            inputData.hAstrxAL = 1;
            inputData.m = 5;
            calculatedData.sa1 = 7.288560615241666d;
            calculatedData.gamma = 0.3805;
            calculatedData.d1 = 50;
            calc.calculationChordusHeight();
            Assert.AreEqual(5.0366391665764789d, calculatedData.ha1);
        }

        [Test]
        public void TestCalculationDivisionWormSpin()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationControls(inputData, calculatedData);
            inputData.m = 5;
            calculatedData.gamma = 0.3805;
            inputData.sAstrx = 1.57;
            calc.calculationDivisionWormSpin();
            Assert.AreEqual(7.288560615241666d, calculatedData.sa1);
        }

        [Test]
        public void TestCalculationRollerWordDim()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationControls(inputData, calculatedData);
            inputData.hAstrxAL = 1;
            inputData.m = 5;
            calculatedData.p1 = 15.707963267948966d;
            calculatedData.gamma = 0.3805;
            calculatedData.d1 = 50;
            inputData.alphaN = 0.3490658503988659;
            inputData.sAstrx = 1.57;
            calc.calculationRollerWormDim();
            Assert.AreEqual(5.0366391665764789d, calculatedData.M1);
        }

        [Test]
        public void TestCalculationSpinStep()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationControls(inputData, calculatedData);
            inputData.z1 = 4;
            calculatedData.p1 = 15.707963267948966d;
            calc.calculationSpinStep();
            Assert.AreEqual(62.831853071795862d, calculatedData.pz1);
        }

        [Test]
        public void TestCalculationWormStep()
        {
            var calculatedData = new CalculatedData();
            var inputData = new InputData();
            var calc = new CalculationControls(inputData, calculatedData);
            inputData.m = 5;
            calc.calculationWormStep();
            Assert.AreEqual(15.707963267948966d, calculatedData.p1);
        }
    }
}