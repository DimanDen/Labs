using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2
{
    /// <summary>
    /// Тест работы конструкторов и основных методов классов при определенных параметрах
    /// </summary>
    [TestClass]
    public class UnitTestInpuDataWrong
    {
        //Входные параметры
        public decimal[] xTest = { -2, -1, 0, 1, 2 };
        public decimal[] coefficientsWrong = { 0, 1, 2, 3 };
        public bool ItsOK = true;

        /// <summary>
        /// Метод проверки с непригодными параметрами для параболы
        /// </summary>
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

            //Если при данных параметрах во время создания экземпляра или в ходе работы методов будет ошибка, то будет пройден.
            Assert.IsFalse(ItsOK);
        }

        /// <summary>
        /// Метод проверки с непригодными параметрами для прямой
        /// </summary>
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

            //Если при данных параметрах во время создания экземпляра или в ходе работы методов будет ошибка, то будет пройден
            Assert.IsFalse(ItsOK);
        }
    }
}
