using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2
{
    [TestClass]
    public class UnitTestCollision
    {
        public decimal[] xTest = { -2, -1, 0, 1, 2 };
        decimal[] coefficients1 = new decimal[3] { 1, 2, 3 };
        decimal[] coefficients2 = new decimal[2] { 1, 2 };
        decimal SinusoidFreeTerm1 = 5.0m;
        Point TestPoint1 = new Point(-1, 2);
        Point TestPoint2 = new Point(-1, -1);
        Point TestPoint3 = new Point(0, 5);
        public bool ItsOK = true;
        [TestMethod]
        public void TestMethodCollisionParabola()
        {
            Lab2.Parabola parabola = null;

            parabola = new Parabola(coefficients1, xTest);
            Assert.IsTrue(parabola.Collision(TestPoint1));
        }

        [TestMethod]
        public void TestMethodCollisionStraight()
        {
            Lab2.Straight straight = null;

            straight = new Straight(coefficients2, xTest);
            Assert.IsTrue(straight.Collision(TestPoint2));
        }

        [TestMethod]
        public void TestMethodCollisionSinusoid()
        {
            Lab2.Sinusoid sinusoid = null;

            sinusoid = new Sinusoid(SinusoidFreeTerm1, xTest);
            Assert.IsTrue(sinusoid.Collision(TestPoint3));
        }
    }
}
