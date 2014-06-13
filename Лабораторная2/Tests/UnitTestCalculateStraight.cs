using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTestCalculateStraight
    {

        int k = 0; 
        bool ItsOK = false;
        Lab2.Form1 kas = new Lab2.Form1();
        Lab2.Point[] Points2Claculate = { new Lab2.Point(1, 3), new Lab2.Point(2, 5) };
        int NumberOfSeries1 = 1;
        Lab2.Point[] Points2 = { new Lab2.Point(1, 0), new Lab2.Point(2, 0) };
        decimal[] coefficients2 = new decimal[2] { 1, 2 };
        [TestMethod]
        public void ClaculatePointsStraightTest()
        {
            Lab2.Straight s = new Lab2.Straight(coefficients2, NumberOfSeries1);
            s.Function(Points2, kas);
            for (int i = 0; i < Points2.Length; i++)
            {
                if (Points2[i].x == Points2Claculate[i].x && Points2[i].y == Points2Claculate[i].y)
                {
                    k++;
                }
            }

            if (k == Points2.Length)
            {
                ItsOK = true;
            }

            Assert.IsTrue(ItsOK);
        }
    }
}
