using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2
{
    /// <summary>
    /// Проверка правильности подсчета значений функци
    /// </summary>
    [TestClass]
    public class UnitTestCalculate
    {
        //Входные параметры
        public decimal[] xTest = { -2, -1, 0, 1, 2 };
        decimal[] coefficients1 = new decimal[3] { 1, 2, 3 };
        decimal[] coefficients2 = new decimal[2] { 1, 2 };
        decimal SinusoidFreeTerm1 = 5.0m;

        /// <summary>
        /// Тест подсчета значений функции параболы
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateParabola()
        {
            Lab2.Parabola parabola = null;

            parabola = new Parabola(coefficients1, xTest);

            Assert.IsTrue((Math.Round(parabola.Points[0].x) == -2) && Math.Round(parabola.Points[0].y) == 9 &&
                Math.Round(parabola.Points[1].x) == -1 && Math.Round(parabola.Points[1].y) == 2);
        }

        /// <summary>
        /// Тест подсчета значений функции прямой
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateStraight()
        {
            Lab2.Straight straight = null;

            straight = new Straight(coefficients2, xTest);

            Assert.IsTrue((Math.Round(straight.Points[0].x) == -2) && Math.Round(straight.Points[0].y) == -3 &&
                Math.Round(straight.Points[1].x) == -1 && Math.Round(straight.Points[1].y) == -1);
        }

        /// <summary>
        /// Тест подсчета значений функции синусойды
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateSinusoid()
        {
            Lab2.Sinusoid sinusoid = null;

            sinusoid = new Sinusoid(SinusoidFreeTerm1, xTest);
            Assert.IsTrue((Math.Round(sinusoid.Points[0].x, 2) == -2) && Math.Round(sinusoid.Points[0].y, 2) == 4.09m &&
                Math.Round(sinusoid.Points[1].x, 2) == -1 && Math.Round(sinusoid.Points[1].y, 2) == 4.16m);
        }
    }
}
