using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Main
{
    [TestClass]
    public class UnitTestPoints
    {
        bool ItsOK = true;
        Lab2.Form1 kas = new Lab2.Form1();
        int NumberOfSeries0 = 0, NumberOfSeries1 = 1; 
        Lab2.Point[] Points1 = { new Lab2.Point(-2.789m, 0), new Lab2.Point(-1.456m, 0), new Lab2.Point(-0.123m, 0) };
        decimal[] coefficients1 = new decimal[3] { 1, 2, 3 };
        Lab2.Point[] Points2 = { new Lab2.Point(-2.789m, 0), new Lab2.Point(-1.456m, 0), new Lab2.Point(-0.123m, 0) };
        decimal[] coefficients2 = new decimal[2] { 1, 2 };
        [TestMethod]
        public void InputPointsTest()
        {
            try
            {
                Lab2.Parabola p = new Lab2.Parabola(coefficients1, NumberOfSeries0);
                p.Function(Points1, kas);
            }
            catch (System.Exception e)
            {
                ItsOK = false;
            }

            try
            {
                Lab2.Straight s = new Lab2.Straight(coefficients2, NumberOfSeries1);
                s.Function(Points2, kas);
            }
            catch (System.Exception e)
            {
                ItsOK = false;
            }

            Assert.IsTrue(ItsOK);
        }
    }
}
