using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2
{
    [TestClass]
    public class UnitTestInpuDataWrong
    {
        public decimal[] xTest = { -2, -1, 0, 1, 2 };
        public decimal[] coefficientsWrong = { 0, 1, 2, 3 };
        public bool ItsOK = true;
        [TestMethod]
        public void InputDataParabolaWrong()
        {
            Lab2.Parabola parabola = null;

            try
            {
                parabola = new Parabola(coefficientsWrong, xTest);
            }
            catch (System.Exception e)
            {
                ItsOK = false;
            }

            Assert.IsFalse(ItsOK);
        }

        [TestMethod]
        public void InputDataStraightWrong()
        {
            Lab2.Straight straight = null;

            try
            {
                straight = new Straight(coefficientsWrong, xTest);
            }
            catch (System.Exception e)
            {
                ItsOK = false;
            }

            Assert.IsFalse(ItsOK);
        }
    }
}
