using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2
{
    /// <summary>
    /// Проверка на непринадлежность точки траектории
    /// </summary>
    [TestClass]
    public class UnitTestCollisionWrong
    {
        //Входные параметры
        public decimal[] xTest = { -2, -1, 0, 1, 2 };
        decimal[] coefficients1 = new decimal[3] { 1, 2, 3 };
        decimal[] coefficients2 = new decimal[2] { 1, 2 };
        decimal SinusoidFreeTerm1 = 5.0m;
        Point TestPoint = new Point(-521, 237);
        /// <summary>
        /// Тест проверки непринадлежности точки параболе
        /// </summary>
        [TestMethod]
        public void TestMethodCollisionParabolaWrong()
        {
            Lab2.Parabola parabola = null;

            parabola = new Parabola(coefficients1, xTest);
            Assert.IsFalse(parabola.Collision(TestPoint));
        }

        /// <summary>
        /// Тест проверки непринадлежности точки прямой
        /// </summary>
        [TestMethod]
        public void TestMethodCollisionStraightWrong()
        {
            Lab2.Straight straight = null;

            straight = new Straight(coefficients2, xTest);
            Assert.IsFalse(straight.Collision(TestPoint));
        }

        /// <summary>
        /// Тест проверки непринадлежности точки синусойде
        /// </summary>
        [TestMethod]
        public void TestMethodCollisionSinusoidWrong()
        {
            Lab2.Sinusoid sinusoid = null;

            sinusoid = new Sinusoid(SinusoidFreeTerm1, xTest);
            Assert.IsFalse(sinusoid.Collision(TestPoint));
        }
    }
}
