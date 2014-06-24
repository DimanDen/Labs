using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2
{
    [TestClass]
    public class UnitTestInpuData
    {
        public decimal[] xTest = { -2, -1, 0, 1, 2 };
        decimal[] coefficients1 = new decimal[3] { 1, 2, 3 };
        decimal[] coefficients2 = new decimal[2] { 1, 2 };
        decimal SinusoidFreeTerm1 = 5.0m;
        public bool ItsOK = true;
        [TestMethod]
        public void InputDataParabola()
        {
            Lab2.Parabola parabola = null;

            try
            {
                parabola = new Parabola(coefficients1, xTest);
            }
            catch (System.Exception e)
            {
                ItsOK = false;
            }

            Assert.IsTrue(ItsOK);
        }

        [TestMethod]
        public void InputDataStraight()
        {
            Lab2.Straight straight = null;

            try
            {
                straight = new Straight(coefficients2, xTest);
            }
            catch (System.Exception e)
            {
                ItsOK = false;
            }

            Assert.IsTrue(ItsOK);
        }

        [TestMethod]
        public void InputDataSinusoidWrong()
        {
            Lab2.Sinusoid sinusoid = null;

            try
            {
                sinusoid = new Sinusoid(SinusoidFreeTerm1, xTest);
            }
            catch (System.Exception e)
            {
                ItsOK = false;
            }

            Assert.IsTrue(ItsOK);
        }
    }
}
