using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Класс, в котором траектория представлена в виде параболы
    /// </summary>
    public class Parabola : Polynomial
    {
        /// <summary>
        /// Конструктор параболы
        /// </summary>
        /// <param name="coefficients">Коэффициенты многочлена</param>
        /// <param name="x">Массив абсцисс</param>
        public Parabola(decimal[] coefficients, decimal[] x)
            : base(coefficients, x)
        {
            if (coefficients.Length != 3)
            {
                throw new Exception("Ошибка в длине массива коэффициентов!!!");
            }
        }
    }
}
