using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Класс, в котором траектория представлена в виде прямой
    /// </summary>
    public class Straight : Polynomial
    {
       /// <summary>
       /// Конструктор прямой
       /// </summary>
       /// <param name="coefficients">Коэффициенты многочлена</param>
       /// <param name="x">Массив абсцисс</param>
        public Straight(decimal[] coefficients, decimal[] x)
            : base(coefficients, x)
        {
            if (coefficients.Length != 2)
            {
                throw new Exception("Ошибка в длине массива коэффициентов!!!");
            }
        }
    }
}
