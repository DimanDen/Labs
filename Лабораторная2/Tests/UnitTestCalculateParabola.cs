using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTestCalculateParabola
    {
        int k = 0;
        bool ItsOK = false;
        Lab2.Form1 kas = new Lab2.Form1();
        Lab2.Point[] Points1Claculate = { new Lab2.Point(1, 6), new Lab2.Point(2, 17) };
        int NumberOfSeries0 = 0;
        Lab2.Point[] Points1 = { new Lab2.Point(1, 0), new Lab2.Point(2, 0) };
        decimal[] coefficients1 = new decimal[3] { 1, 2, 3 };
        [TestMethod]
        public void ClaculatePointsParabolaTest()
        {
            Lab2.Parabola p = new Lab2.Parabola(coefficients1, NumberOfSeries0);
            p.Function(Points1, kas);
            for (int i = 0; i < Points1.Length; i++)
            {
                if (Points1[i].x == Points1Claculate[i].x && Points1[i].y == Points1Claculate[i].y)
                {
                    k++;
                }
            }

            if (k == Points1.Length)
            {
                ItsOK = true;
            }

            Assert.IsTrue(ItsOK);
        }
    }
}
