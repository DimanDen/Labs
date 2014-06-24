using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Класс, представляющий траекторию в виде многочлена
    /// </summary>
    public class Polynomial : Trajectory
    {
        /// <summary>
        /// Базовый конструктор для параболы и прямой
        /// </summary>
        /// <param name="coefficients">Коэффициенты многочлена/param>
        /// <param name="x">Массив асцисс</param>
        public Polynomial(decimal[] coefficients, decimal[] x)
        {
            this.coefficients = coefficients;
            this.Points = this.BuiltPoints(x);
        }

        protected Polynomial()
        { }
        /// <summary>
        /// Метод построения точек, специализированный под многочлен
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public override Point[] BuiltPoints(decimal[] x)
        {
            Points = new Point[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                Points[i] = new Point(x[i], 0);
                for (int j = 0; j < coefficients.Length; j++)
                {
                    Points[i].y = Points[i].y + coefficients[j] * (decimal)Math.Pow((double)Points[i].x, j);
                }
            }
            return Points;
        }
    }
}
